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
            string query = "select * from 손익계산서1";

            dt = dbc.ExcuteDataAdapter(query);

            return dt;
        }

        public string Bulkinsert_IncomeStat()
        {
            string query = @"bulk insert dbo.손익계산1
                                  from 'C:\2016재무재표\2016손익계산서\2016_1Q_PL_20220212040443\2016_1분기보고서_03_포괄손익계산서_연결_20220212.txt'
                                  with(codepage = '65001'    --utf - 8형식 한글은 깨지므로 utf - 8로 하고 테이블 컬럼은 nvarchar로 맞춰야함
                                , fieldterminator = '\t'     -- tab 을 구분지어 열에 입력
                                , firstrow = 2               -- 시작행
                                , rowterminator = '\n        -- 행은 엔터키를 기준
                                , BATCHSIZE = 100)";         //100개행씩 입력

            

            return dbc.ExcuteNonquery(query);
        }
    }
}
