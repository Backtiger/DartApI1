using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stockking.GET
{
    class GetQuery
    {
        DBconnect dbc = new DBconnect();

        public DataTable get_screening()
        {
            DataTable dt = new DataTable();
            string squery = @"SELECT * FROM (
                    SELECT ROW_NUMBER() OVER (PARTITION BY A.STOCKCODE ORDER BY A.STOCKCODE,A.CLOSINGDATE DESC) AS DISP
                         , A.STNAME
                         , A.STOCKCODE
                             	 , A.RPKIND
                                  , A.CLOSINGDATE
                             	 , A.ENDQUATER
                                  , B.TOTALSHARES
                             	 , B.SHARESCOUNT
                             	 , B.PER
                             	 , B.ROA
                             	 , B.ROE
                               FROM (SELECT A.STNAME
                                  , A.STOCKCODE
                             	 , A.RPKIND
                                  , A.CLOSINGDATE
                             	 , A.ENDQUATER
                               FROM DBO.INCOMESTATEMENT_Q1 A
                              WHERE ITEM_STAT   ='매출'
                                AND STKIND_CODE ='별도' 
                              UNION ALL
                             SELECT B.STNAME
                                  , B.STOCKCODE
                             	 , B.RPKIND
                                  , B.CLOSINGDATE
                             	 , B.ENDQUATER
                               FROM DBO.INCOMESTATEMENT_Q2 B
                              WHERE ITEM_STAT   ='매출'
                                AND STKIND_CODE ='별도'
                                 UNION ALL
                             SELECT C.STNAME
                                  , C.STOCKCODE
                             	 , C.RPKIND
                                  , C.CLOSINGDATE
                             	 , C.ENDQUATER
                               FROM DBO.INCOMESTATEMENT_Q3 C
                              WHERE ITEM_STAT   ='매출'
                                AND STKIND_CODE ='별도'
                                    UNION ALL
                             SELECT D.STNAME
                                  , D.STOCKCODE
                                  , D.RPKIND
                                  , D.CLOSINGDATE
                             	 , D.ACCQUATER AS ENDQUATER
                               FROM DBO.INCOMESTATEMENT_Q4 D
                              WHERE ITEM_STAT   ='매출'
                                AND STKIND_CODE ='별도')A 
                                  , DBO.MARKETDATA B
                              WHERE A.STNAME=B.STNAME   ) AC
                              WHERE AC.DISP <5   
                              ORDER BY AC.STOCKCODE,AC.DISP";

            dt = dbc.DataAdapter(squery);
            return dt;
        }
        public DataTable AlltiemScreennig()
        {
            DataTable dt = new DataTable();
            string squery = @"						     SELECT A.STNAME
                              , A.STOCKCODE
                         	  , A.RPKIND
                              , LEFT(A.CLOSINGDATE,4) ClosingDate
                         	  , A.ENDQUATER
							  , a.Accquater						
							  , A.EndFirstPeroid
							  , a.Lastyear
							  , A.ItemName
							  , A.ITEMCODE
                           FROM DBO.INCOMESTATEMENT_Q1 A
                          WHERE  STKIND_CODE ='연결' 
						   and stname = '경방'
						    AND A.item_stat IS NOT NULL
                          UNION ALL
                         SELECT b.STNAME
                              , B.STOCKCODE
                         	  , B.RPKIND
                              , LEFT(B.CLOSINGDATE,4) ClosingDate
                         	  , B.ENDQUATER
							  , b.Accquater
							  , b.EndFirstPeroid
							  , b.Lastyear
							  , B.ItemName
							   , B.ITEMCODE
                           FROM DBO.INCOMESTATEMENT_Q2 B
                          WHERE STKIND_CODE ='연결'
						   and stname = '경방'
						    AND B.item_stat IS NOT NULL
                          UNION ALL
                         SELECT C.STNAME						      
                              , C.STOCKCODE
                         	  , C.RPKIND
                              , LEFT(C.CLOSINGDATE,4) ClosingDate
                         	  , C.ENDQUATER
							  , c.Accquater
							  , c.EndFirstPeroid
							  , c.Lastyear
							  , C.ItemName
							  , C.ITEMCODE
                           FROM DBO.INCOMESTATEMENT_Q3 C
                          WHERE STKIND_CODE ='연결'
						   and stname = '경방'
						    AND C.item_stat IS NOT NULL
						  UNION ALL						 
						 select    b.StName
								 , B.StockCode
								 , b.rpKind
								 , LEFT(B.ClosingDate,4) AS CLOSINGDATE
								 , B.endquater	
								 , b.Accquater
								 , b.EndFirstPeroid
								 , b.Lastyear
								 , b.ItemCode	 
								 , b.ItemName	 
							  from dbo.IncomeStatement_all_Q4 b 
							 WHERE B.STKIND_CODE ='연결'
							   and stname = '경방'
						    AND B.item_stat IS NOT NULL
						";

            dt = dbc.DataAdapter(squery);
            return dt;
        }
    }
}        