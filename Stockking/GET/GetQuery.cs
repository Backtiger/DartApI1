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
        public void get_screening()
        {
            string squery = @"select * from (
                    select ROW_NUMBER() OVER (PARTITION BY a.stockcode ORDER BY A.StockCode,A.ClosingDate DESC) as disp
                         , a.stname
                         , a.StockCode
                             	 , a.rpKind
                                  , a.closingdate
                             	 , a.Endquater
                                  , b.totalshares
                             	 , b.sharescount
                             	 , b.per
                             	 , b.roa
                             	 , b.roe
                               from (select a.stname
                                  , a.StockCode
                             	 , a.rpKind
                                  , a.closingdate
                             	 , a.Endquater
                               from dbo.IncomeStatement_Q1 a
                              where item_stat   ='매출'
                                and Stkind_code ='별도' 
                              union all
                             select b.stname
                                  , b.StockCode
                             	 , b.rpKind
                                  , b.closingdate
                             	 , b.Endquater
                               from dbo.IncomeStatement_Q2 b
                              where item_stat   ='매출'
                                and Stkind_code ='별도'
                                 union all
                             select c.stname
                                  , c.StockCode
                             	 , c.rpKind
                                  , c.closingdate
                             	 , c.Endquater
                               from dbo.IncomeStatement_Q3 c
                              where item_stat   ='매출'
                                and Stkind_code ='별도'
                                    union all
                             select d.stname
                                  , d.StockCode
                                  , d.rpKind
                                  , d.closingdate
                             	 , d.Accquater as Endquater
                               from dbo.IncomeStatement_Q4 d
                              where item_stat   ='매출'
                                and Stkind_code ='별도')A 
                                  , dbo.Marketdata B
                              where a.StName=b.StName   ) AC
                              where AC.disp <5   
                              order by AC.StockCode,AC.disp";
        }
    }
}      }        