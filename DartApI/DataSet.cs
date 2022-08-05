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

            wc.Headers["User-Agent"] =
    "Mozilla/4.0 (Compatible; Windows NT 5.1; MSIE 6.0) " +
    "(compatible; MSIE 6.0; Windows NT 5.1; " +
    ".NET CLR 1.1.4322; .NET CLR 2.0.50727)";
            wc.Encoding = Encoding.UTF8;
            string xml2 =wc.DownloadString(url);

            xml.LoadXml(xml2);

            XmlNodeList nodlist = xml.SelectNodes("/result/list"); //xml노드 셀렉 result 노드의 list노드들을 가져옴                     );


            foreach (XmlNode node in nodlist)
            {
                
                
                if (string.IsNullOrEmpty(node["rcept_no"].InnerText.ToString()))
                    dt.Rows.Add(node["rcept_no"].InnerText.ToString());

                if (string.IsNullOrEmpty(node["bsns_year"].InnerText.ToString()))
                    dt.Rows.Add(node["bsns_year"].InnerText.ToString());

                if (string.IsNullOrEmpty(node["stock_code"].InnerText.ToString()))
                    dt.Rows.Add(node["stock_code"].InnerText.ToString());

                if (string.IsNullOrEmpty(node["reprt_code"].InnerText.ToString()))
                    dt.Rows.Add(node["reprt_code"].InnerText.ToString());

                if (string.IsNullOrEmpty(node["account_nm"].InnerText.ToString()))
                    dt.Rows.Add(node["account_nm"].InnerText.ToString());

                if (string.IsNullOrEmpty(node["fs_div"].InnerText.ToString()))
                    dt.Rows.Add(node["fs_div"].InnerText.ToString());

                if (string.IsNullOrEmpty(node["fs_nm"].InnerText.ToString()))
                    dt.Rows.Add(node["fs_nm"].InnerText.ToString());

                if (string.IsNullOrEmpty(node["sj_div"].InnerText.ToString()))
                    dt.Rows.Add(node["sj_div"].InnerText.ToString());

                if (string.IsNullOrEmpty(node["sj_nm"].InnerText.ToString()))
                    dt.Rows.Add(node["sj_nm"].InnerText.ToString());

                if (string.IsNullOrEmpty(node["thstrm_nm"].InnerText.ToString()))
                    dt.Rows.Add(node["thstrm_nm"].InnerText.ToString());

                if (string.IsNullOrEmpty(node["thstrm_dt"].InnerText.ToString()))
                    dt.Rows.Add(node["thstrm_dt"].InnerText.ToString());

                if (string.IsNullOrEmpty(node["thstrm_amount"].InnerText.ToString()))
                    dt.Rows.Add(node["thstrm_amount"].InnerText.ToString());

                //if (string.IsNullOrEmpty(node["thstrm_add_amount"].InnerText.ToString()))
                //    dt.Rows.Add(node["thstrm_add_amount"].InnerText.ToString());

                if (string.IsNullOrEmpty(node["frmtrm_nm"].InnerText.ToString()))
                    dt.Rows.Add(node["frmtrm_nm"].InnerText.ToString());

                if (string.IsNullOrEmpty(node["frmtrm_dt"].InnerText.ToString()))
                    dt.Rows.Add(node["frmtrm_dt"].InnerText.ToString());

                if (string.IsNullOrEmpty(node["frmtrm_amount"].InnerText.ToString()))
                    dt.Rows.Add(node["frmtrm_amount"].InnerText.ToString());

                //if (string.IsNullOrEmpty(node["frmtrm_add_amount"].InnerText.ToString()))
                //    dt.Rows.Add(node["frmtrm_add_amount"].InnerText.ToString());

                if (string.IsNullOrEmpty(node["bfefrmtrm_nm"].InnerText.ToString()))
                    dt.Rows.Add(node["bfefrmtrm_nm"].InnerText.ToString());

                if (string.IsNullOrEmpty(node["bfefrmtrm_dt"].InnerText.ToString()))
                    dt.Rows.Add(node["bfefrmtrm_dt"].InnerText.ToString());

                if (string.IsNullOrEmpty(node["bfefrmtrm_amount"].InnerText.ToString()))
                    dt.Rows.Add(node["bfefrmtrm_amount"].InnerText.ToString());

                if (string.IsNullOrEmpty(node["ord"].InnerText.ToString()))
                    dt.Rows.Add(node["ord"].InnerText.ToString());

                if (string.IsNullOrEmpty(node["currency"].InnerText.ToString()))
                    dt.Rows.Add(node["currency"].InnerText.ToString());

                //dt.Rows.Add( node["rcept_no"].InnerText.ToString()
                //           , node["bsns_year"].InnerText.ToString()
                //           , node["stock_code"].InnerText.ToString()
                //           , node["reprt_code"].InnerText.ToString()
                //           , node["account_nm"].InnerText.ToString()
                //           , node["fs_div"].InnerText.ToString()
                //           , node["fs_nm"].InnerText.ToString()
                //           , node["sj_div"].InnerText.ToString()
                //           , node["sj_nm"].InnerText.ToString()
                //           , node["thstrm_nm"].InnerText.ToString()
                //           , node["thstrm_dt"].InnerText.ToString()
                //           , node["thstrm_amount"].InnerText.ToString()
                //           , node["thstrm_add_amount"].InnerText.ToString()
                //           , node["frmtrm_nm"].InnerText.ToString()
                //           , node["frmtrm_dt"].InnerText.ToString()
                //           , node["frmtrm_amount"].InnerText.ToString()
                //           , node["frmtrm_add_amount"].InnerText.ToString()
                //           , node["bfefrmtrm_nm"].InnerText.ToString()
                //           , node["bfefrmtrm_dt"].InnerText.ToString()
                //           , node["bfefrmtrm_amount"].InnerText.ToString()
                //           , node["ord"].InnerText.ToString()
                //           , node["currency"].InnerText.ToString()
                //           );
            }

            return dt;

        }

    }
}
