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

        public int Select_stockList( string corpname)
        {
            string query = @" select * from master.dbo.StockList where corp_name ";


            return dbc.ExcuteNonquery(query);
        }

        public DataTable SELECT_SCREENNING()
        {
            string query = @" 
                    select distinct 
                           A.corp_code 
                    	 , B.StName
                         , B.makedate
                    	 , B.sharescount
                    	 , B.totalsales
                    	 , B.totalshares 
                    	 , B.per
                    	 , B.roe
                    	 , B.roa
                      from master.dbo.StockList A
                         , stock.dbo.Marketdata B
                     where A.corp_name = b.StName  ";

            return dbc.DataAdapter(query);
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





        public int Insert_MarketData(string insertdata)
        {
           string query = @" insert into dbo.Marketdata(makedate, disp  ,StName,todayprice ,lastdaychar , flucationlate,facevalue ,sharescount, totalshares,totalsales , per, roe, roa)
                              values( '" + DateTime.Now.ToString("yyyy-MM-dd")+"',"+insertdata+") ";

            return dbc.ExcuteNonquery(query);
        }
    }
}
