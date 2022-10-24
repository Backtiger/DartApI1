using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartApI
{
    class DAL
    {
        DBconnect dbc = new DBconnect();
        DataTable dt = new DataTable();

        public DataTable SelectInCome()
        {
            string query = "select * from IncomeStatement";

            dt = dbc.ExcuteDataAdapter(query);

            return dt;
        }

        public int Bulkinsert_IncomeStatement(string Name,string dbName)
        {
            string query = @"bulk insert " + dbName +
                            "     from '"+Name+"'" +
                            "     with(codepage = '65001'" +            //utf - 8형식 한글은 깨지므로 utf -8로 하고 테이블 컬럼은 nvarchar로 맞춰야함
                            "    , fieldterminator = '\\t'" +           //tab 을 구분지어 열에 입력
                            "    , firstrow = 2          "    +         //시작행
                            "    , rowterminator = '\\n'   "   +         //행구분은 엔터키 기준
                            "    , BATCHSIZE = 100)";                   //100개 행씩 작동    


            return dbc.ExcuteNonquery(query);
        }

        public int Insert_stockList(string corpcode, string corpname,string stockcode,string modifydate)
        {
            string query =@" insert into master.dbo.StockList(corp_code, corp_name, stock_code, modifydate) values('"+corpcode+"','"+ corpname + "','"+stockcode+"','"+ modifydate + "')";
           

            return dbc.ExcuteNonquery(query);
        }
        public int Insert_MarketCapital(string StName, string sharescount, string totalshares, string per,string roe,string roa)
        {
           string query =@" insert into dbo.MarketCapital(StName, makedate, sharescount, totalshares, per, roe, roa)values()";

           return dbc.ExcuteNonquery(query);
        }
    }
}
