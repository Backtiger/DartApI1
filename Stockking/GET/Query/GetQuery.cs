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
    }
}        