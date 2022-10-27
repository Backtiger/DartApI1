using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DartApI
{
    class DataSet
    {   //xml파싱 객체 선언
        WebClient wc = new WebClient();
        XmlDocument xml = new XmlDocument();
        DataTable dt = new DataTable();
        
        //크롤링 객체 선언
        ChromeDriverService _driverService = null;
        ChromeOptions _options = null;

        DAL DAL = new DAL();

        public DataTable Getmulticorps(string corpscode, string year, string reportcode)
        {
            string url = "https://opendart.fss.or.kr/api/fnlttMultiAcnt.xml";
            url += "?crtfc_key=948cf4289418562aa37eea79fdbad0cb93a46797";
            url += "&corp_code=" + corpscode + "";
            url += "&bsns_year=" + year + "";
            url += "&reprt_code=" + reportcode + "";

            return Getxml(url);
        }

        private DataTable Getxml(string url)
        {

            wc.Headers["User-Agent"] = "Mozilla/4.0 (Compatible; Windows NT 5.1; MSIE 6.0) " +
                                       "(compatible; MSIE 6.0; Windows NT 5.1; " +
                                       ".NET CLR 1.1.4322; .NET CLR 2.0.50727)";
            wc.Encoding = Encoding.UTF8;
            string xml2 = wc.DownloadString(url);

            xml.LoadXml(xml2);

            XmlNodeList nodlist = xml.SelectNodes("/result/list"); //xml노드 셀렉 result 노드의 list노드들을 가져옴                     );

            List<String> list = new List<string>(); //api 호출시 노드명이 없는 부분이 있어 비교를 위한 list선언

            list.Add("rcept_no");
            list.Add("bsns_year");
            list.Add("stock_code");
            list.Add("reprt_code");
            list.Add("account_nm");
            list.Add("fs_div");
            list.Add("fs_nm");
            list.Add("sj_div");
            list.Add("sj_nm");
            list.Add("thstrm_nm");
            list.Add("thstrm_dt");
            list.Add("frmtrm_amount");
            list.Add("frmtrm_add_amount");
            list.Add("bfefrmtrm_nm");
            list.Add("bfefrmtrm_dt");
            list.Add("bfefrmtrm_amount");
            list.Add("ord");
            list.Add("currency");

            dt.Columns.Add("rcept_no", typeof(string));
            dt.Columns.Add("bsns_year", typeof(string));
            dt.Columns.Add("stock_code", typeof(string));
            dt.Columns.Add("reprt_code", typeof(string));
            dt.Columns.Add("account_nm", typeof(string));
            dt.Columns.Add("fs_div", typeof(string));
            dt.Columns.Add("fs_nm", typeof(string));
            dt.Columns.Add("sj_div", typeof(string));
            dt.Columns.Add("sj_nm", typeof(string));
            dt.Columns.Add("thstrm_nm", typeof(string));
            dt.Columns.Add("thstrm_dt", typeof(string));
            dt.Columns.Add("frmtrm_amount", typeof(string));
            dt.Columns.Add("frmtrm_add_amount", typeof(string));
            dt.Columns.Add("bfefrmtrm_nm", typeof(string));
            dt.Columns.Add("bfefrmtrm_dt", typeof(string));
            dt.Columns.Add("bfefrmtrm_amount", typeof(string));
            dt.Columns.Add("ord", typeof(string));
            dt.Columns.Add("currency", typeof(string));
            DataRow dr = dt.NewRow();

            string aa = null;
    

            foreach (XmlNode node in nodlist)
            {
                foreach (XmlElement no in node)
                {
                    //for (int i = 0; i < list.Count; i++)
                    //{
                    //if (no.Name.Contains(list[i].ToString()))
                    //{
                        if(list.Contains(no.Name))      // 리스트에 저장된 값들중 노드명이 포함되면 화면에 뿌려주는 로직             
                            dr[no.Name] = no.InnerText.ToString();
                            // System.Windows.Forms.MessageBox.Show(dr[list[i].ToString()].ToString()); 
                    //}
                        if(no.Name == "currency")
                        {
                            //dt.NewRow();
                           // dt.ImportRow(dr);
                            dt.Rows.Add(dr.ItemArray);

                            for(int k = 0; k < dr.Table.Columns.Count; k++)
                                Console.WriteLine(dr[k].ToString());

                            aa = dt.Rows.Count.ToString();
                        }
                    //}
                }

               //     node["bsns_year"].InnerText.ToString(),
               // node["stock_code"].InnerText.ToString(),
               // node["reprt_code"].InnerText.ToString(),
               // node["account_nm"].InnerText.ToString(),
               // node["fs_div"].InnerText.ToString(),
               // node["fs_nm"].InnerText.ToString(),
               // node["sj_div"].InnerText.ToString(),
               // node["sj_nm"].InnerText.ToString(),
               // node["thstrm_nm"].InnerText.ToString(),
               // node["thstrm_dt"].InnerText.ToString(),
               // node["thstrm_amount"].InnerText.ToString(),
               // //    dt.Rows.Add(node["thstrm_add_amount"].InnerText.ToString());              
               // node["frmtrm_nm"].InnerText.ToString(),
               // node["frmtrm_dt"].InnerText.ToString(),
               // node["frmtrm_amount"].InnerText.ToString(),
               ////    dt.Rows.Add(node["frmtrm_add_amount"].InnerText.ToString());        
               ////    dt.Rows.Add(node["bfefrmtrm_nm"].InnerText.ToString());        
               ////    dt.Rows.Add(node["bfefrmtrm_dt"].InnerText.ToString());        
               ////    dt.Rows.Add(node["bfefrmtrm_amount"].InnerText.ToString());            
               //node["ord"].InnerText.ToString(),
               //node["currency"].InnerText.ToString());
            }

            return dt;

        }

        public void ToDayStockData()
        {

            //_options.AddArgument("headless"); // 창을 숨기는 옵션입니다.

            _driverService = ChromeDriverService.CreateDefaultService();
            _driverService.HideCommandPromptWindow = true;

            _options = new ChromeOptions();
            _options.AddArgument("disable-gpu");
            
            ChromeDriver _driver = new ChromeDriver(_driverService ,_options); //크롬드라이버 다운받고 버젼 맞춰줘야함
            _driver.Navigate().GoToUrl("https://finance.naver.com/sise/sise_market_sum.naver?sosok=0");//네이버 종목정보 코스피 sosok=0 코스탁 sosok=1

            _driver.FindElement(By.XPath("//*[@id='contentarea_left']/div[2]/form/div/div/div/a[2]")); //초기 항목으로 클릭

            _driver.FindElement(By.Id("option1")).Click(); //거래량 체크박스 해제
            _driver.FindElement(By.Id("option15")).Click(); //외국인비율 체크박스 해제

            // _driver.FindElement(By.Id("option4")).Click(); //시가총액 체크박스 클릭
            // _driver.FindElement(By.Id("option6")).Click(); //per 체크박스 클릭
            //  _driver.FindElement(By.Id("option12")).Click(); //roe 체크박스 클릭
            //  _driver.FindElement(By.Id("option21")).Click(); //상장주식수 체크박스 클릭

            _driver.FindElement(By.Id("option18")).Click(); //roa 체크박스 선택
            _driver.FindElement(By.Id("option22")).Click(); //매출액 체크박스 선택

            _driver.FindElement(By.XPath("//*[@id='contentarea_left']/div[2]/form/div/div/div/a[1]")).Click();

            //마지막페이지 수를 가져오기위한 로직
            var href = _driver.FindElement(By.ClassName("pgRR"));
            var tagA = href.FindElement(By.TagName("a"));
            var strlink  = tagA.GetAttribute("href");
            int page = strlink.IndexOf("page=")+5;   //'page=' 길이가 5이기 때문에 5추가
            int PGcount = Convert.ToInt32(strlink.Substring(page,strlink.Length- page));

            int count = 0; //한줄씩 인서트하기위한 갯수를 세기위한 변수 
            int show = 0;

            //마지막 페이지까지 데이터 가져오는 로직
            for (int i = 1; i <= PGcount; i++)
            {
                _driver.Navigate().GoToUrl("https://finance.naver.com/sise/sise_market_sum.naver?sosok=0&page=" + i + "");//네이버 종목정보 코스피 sosok=0 코스탁 sosok=1

                var table = _driver.FindElement(By.XPath("//*[@id='contentarea']/div[3]/table[1]")); //종목정보 테이블 xpath
                var tbody = table.FindElement(By.TagName("tbody"));
                var tr = tbody.FindElements(By.TagName("tr"));

                //var table = _driver.FindElement(By.ClassName("type_2"));
                //var tbody = table.FindElement(By.TagName("tbody"));

                string Todaydata=null;
                string test = null;
                foreach (var dr in tr)
                {
                  
                    var td = dr.FindElements(By.TagName("td"));
                    //var stockname = td.FindElement(By.ClassName("title"));

                   // System.Windows.Forms.MessageBox.Show(stockname.ToString());
                    //var data=td.FindElements(By.ClassName("number"));
                    foreach (var cell in td)
                    {
                     
                        test = cell.Text.ToString();
                       
                        Console.WriteLine( test);
                        Console.WriteLine("카운트:"+count);
                        if (!string.IsNullOrEmpty(cell.Text))
                        {
                            count++;
                            Todaydata += "'" + cell.Text.ToString().Replace(",", "") + "',";

                            if (count % 12 == 0)
                            {
                                show += DAL.Insert_MarketData(Todaydata.TrimEnd(','));
                                Todaydata = null;
                                count = 0;
                            }
                        }

               
                    }
            
                }
           
            }
            System.Windows.Forms.MessageBox.Show(show.ToString());
            _driver.Quit();
            _driver.Dispose();
            _driverService.Dispose();            

        }

    }
}
