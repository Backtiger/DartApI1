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
            string squery = @"	
                         SELECT a.stkind 
							  , A.STNAME
                              , A.STOCKCODE
                         	  , A.RPKIND
                              , LEFT(A.CLOSINGDATE,4) ClosingDate
                         	  , A.ENDQUATER
							  , A.ItemName
							  , A.ITEMCODE
                           FROM DBO.INCOMESTATEMENT_Q1 A
                          WHERE  STKIND_CODE ='연결' 
						    AND A.item_stat IS NOT NULL
                          UNION ALL
                         SELECT b.StKind
						      , B.STNAME
                              , B.STOCKCODE
                         	  , B.RPKIND
                              , LEFT(B.CLOSINGDATE,4) ClosingDate
                         	  , B.ENDQUATER
							  , B.ItemName
							   , B.ITEMCODE
                           FROM DBO.INCOMESTATEMENT_Q2 B
                          WHERE STKIND_CODE ='연결'
						    AND B.item_stat IS NOT NULL
                          UNION ALL
                         SELECT c.StKind
						      , C.STNAME						      
                              , C.STOCKCODE
                         	  , C.RPKIND
                              , LEFT(C.CLOSINGDATE,4) ClosingDate
                         	  , C.ENDQUATER
							  , C.ItemName
							  , C.ITEMCODE
                           FROM DBO.INCOMESTATEMENT_Q3 C
                          WHERE STKIND_CODE ='연결'
						    AND C.item_stat IS NOT NULL
						  UNION ALL
						  SELECT * FROM
						 ( select  b.StKind	
								 , b.StName
								 , B.StockCode
								 , b.rpKind
								 , LEFT(B.ClosingDate,4) AS CLOSINGDATE
								 , b.Accquater- abs(isnull(a.Accquater,0)) as endquater
								 , b.ItemCode	 
								 , b.ItemName	 
							  from dbo.IncomeStatement_Q3 a
							 right outer join dbo.IncomeStatement_Q4 b 
							    on a.Stkind_code = b.Stkind_code
							   and trim(a.StockCode) = trim(b.StockCode)
							   and a.ItemCode = b.ItemCode
							   and left(a.ClosingDate,4) = left(b.ClosingDate,4)
							   AND B.Stkind_code = '연결'
							   AND A.Stkind_code = '연결'
							   AND A.item_stat IS NOT NULL
							   AND B.item_stat IS NOT NULL)D           ";

            dt = dbc.DataAdapter(squery);
            return dt;
        }
    }
}        