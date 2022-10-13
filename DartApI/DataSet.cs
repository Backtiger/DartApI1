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
    {
        WebClient wc = new WebClient();
        XmlDocument xml = new XmlDocument();
        DataTable dt = new DataTable();
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

    }
}
