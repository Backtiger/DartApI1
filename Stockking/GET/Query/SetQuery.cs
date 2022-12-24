using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stockking
{
    class SetQuery
    {
        DBconnect dbc = new DBconnect();
        DataTable dt = new DataTable();

        public DataTable Select_stockList()
        {
            string query = @"with temp as
                           (
                           select distinct 
                                   REPLACE(REPLACE(StockCode,'[',''),']','') as stock_code
                                 , STNAME
                           	  from dbo.cashFlow
                           )select b.stock_code
                              from temp a
                                 , master.dbo.StockList b 
                             where a.stock_code = b.stock_code";

            return dbc.DataAdapter(query);
        }
        public void insert_cash(string stockcode)
        {
            try
            {
                string query = @"INSERT INTO [dbo].[CASHFLOW_BACK]
                              SELECT CA.StKind
                                   , REPLACE(REPLACE(StockCode,'[',''),']','') AS STCOD
                                   , STNAME
                                   , MarketClass
                                   , IndustryCode
                                   , IndustryName
                                   , ClosingMonth
                                   , ClosingDate
                                   , rpKind
                                   , Currency
                                   , ItemCode
                                   , ItemName	  
                                   , ISNULL(REPLACE(CA.Endquater,',',''),0) '당기'
                                   , ISNULL(REPLACE(CA.EndFirstPeroid,',',''),0)'전기'
                                   , ISNULL(REPLACE(CA.EndPreviousPeroid,',',''),0)'1년실적'
                                   , ISNULL(REPLACE(CA.Yearmanufacture,',',''),0)'작년실적'
                                FROM DBO.cashFlow CA 
                               WHERE StockCode='["+ stockcode +"]' ";

                dbc.ExcuteNonquery(query);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(stockcode);
            }           
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

            System.Windows.Forms.MessageBox.Show(Name);
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
