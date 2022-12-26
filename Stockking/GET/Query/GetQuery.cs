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
            string squery = @"					      SELECT AC.STOCKCODE
                         	   , AC.STNAME
							   , AC.RPKIND
                               , AC.CLOSINGDATE AS CLOSINGDATE
                         	   , AC.ENDQUATER
							   , AC.ENDFIRSTPEROID
							   , AC.LASTYEAR
							   , AC.ITEMNAME
							   , AC.ITEMCODE						
							   , AC.ITEM_STAT
							   , ISNULL(LAG(AC.ENDQUATER)OVER(PARTITION BY AC.STNAME,AC.ITEM_STAT ORDER BY AC.STNAME, AC.ITEM_STAT,AC.CLOSINGDATE,AC.RPKIND),0)	AS LASTQUATER							 								
						    FROM
						 (SELECT A.STNAME
						       , A.STOCKCODE
                         	   , A.RPKIND
                               , A.CLOSINGDATE 
                         	   , A.ENDQUATER
							   , A.ENDFIRSTPEROID
							   , A.LASTYEARQUATER AS LASTYEAR
							   , A.ITEMNAME
							   , A.ITEMCODE
							   , A.ITEM_STAT
							   , A.STKIND_CODE
                           FROM DBO.INCOMESTATEMENT_Q1 A
                          WHERE  STKIND_CODE ='연결' 
						    AND A.ITEM_STAT IS NOT NULL
                          UNION ALL
                         SELECT B.STNAME
                              , B.STOCKCODE
                         	  , B.RPKIND
                              , B.CLOSINGDATE							
                         	  , B.ENDQUATER
							  , B.ENDFIRSTPEROID
							  , B.LASTYEARQUATER AS LASTYEAR
							  , B.ITEMNAME
							   , B.ITEMCODE
							     , B.ITEM_STAT
								 , B.STKIND_CODE
								 FROM DBO.INCOMESTATEMENT_Q2 B
                          WHERE STKIND_CODE ='연결'
						    AND B.ITEM_STAT IS NOT NULL
                          UNION ALL
                         SELECT C.STNAME						      
                              , C.STOCKCODE
                         	  , C.RPKIND
                              , C.CLOSINGDATE
                         	  , C.ENDQUATER
							  , C.ENDFIRSTPEROID
							  , C.LASTYEARQUATER AS LASTYEAR
							  , C.ITEMNAME
							  , C.ITEMCODE
							    , C.ITEM_STAT
								, C.STKIND_CODE
                           FROM DBO.INCOMESTATEMENT_Q3 C
                          WHERE STKIND_CODE ='연결'
						    AND C.ITEM_STAT IS NOT NULL
						  UNION ALL
						 SELECT * FROM
					    (SELECT B.STNAME
			   				  , B.STOCKCODE
			   				  , B.RPKIND
			   				  , B.CLOSINGDATE
			   				  , B.ACCQUATER- ABS(ISNULL(A.ACCQUATER,0)) AS ENDQUATER
			   				  , B.ENDFIRSTPEROID
			   				  , B.LASTYEAR
			   				  , B.ITEMCODE	 
			   				  , B.ITEMNAME
			   				  , B.ITEM_STAT
			   				  , B.STKIND_CODE
			   			   FROM DBO.INCOMESTATEMENT_Q3 A
			   			  RIGHT OUTER JOIN DBO.INCOMESTATEMENT_Q4 B 
			   			     ON A.STKIND_CODE = B.STKIND_CODE
			   			    AND TRIM(A.STOCKCODE) = TRIM(B.STOCKCODE)
			   			    AND A.ITEMCODE = B.ITEMCODE
			   			    AND LEFT(A.CLOSINGDATE,4) = LEFT(B.CLOSINGDATE,4)
			   			    AND B.STKIND_CODE = '연결'
			   			    AND A.STKIND_CODE = '연결'
				       	    AND A.ITEM_STAT IS NOT NULL
							AND B.ITEM_STAT IS NOT NULL)D)  AC
						  WHERE AC.ITEM_STAT IS NOT NULL
				     	    AND AC.STKIND_CODE = '연결'
						    AND ENDQUATER <> '0'";

            dt = dbc.DataAdapter(squery);
            return dt;
        }
    }
}        