using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stockking.GET
{
    class GetFacturing
    {
        private static GetFacturing Alldata =null;
        DataTable dtincome = new DataTable();
        DataTable dtcash = new DataTable();
        DataTable dtstat = new DataTable();

        public string[] equalsign = { "=", "<=", ">=", ">", "<", "~" };

        GetQuery getQuery = new GetQuery();

        public enum incomeitemstat
        {
            매출 ,
            영업이익,
            총포괄손익,
            당기순이익,
            매출원가,
            판관비,
            qoq,
            yoy
        }
        



        enum cashitemstat
        {
            영업활동현금흐름,
            투자활동현금흐름,
            무형자산처분,
            재무활동현금흐름,
            유형자산취득,
            무형자산취득,     
            qoq,
            yoy
                
        }
        enum statitemstat
        {
          자산총계,
          유동부채,
          매출채권,
          재고자산,
          유동자산,
          부채총계,
          부채,
          비유동자산,
          자산,
          자본과부채총계,
          qoq,
          yoy             
        }
    


        public GetFacturing ALLDATA()
        {
            if (Alldata == null)
                Alldata = new GetFacturing();

            dtincome = getQuery.AlltiemScreennig();

            return Alldata;
        }

    
        public DataTable Calculation(string where)
        {
            
            DataTable dtscreen = new DataTable();
            dtscreen = dtincome.Copy();



            Dictionary<string, string> Diclist = new Dictionary<string, string>();

            dtscreen.Columns.Add("qoq");
            dtscreen.Columns.Add("yoy");

            double qoq;
            double yoy;

            string beforeyear;
            string aftteryear;

            foreach (DataRow dr in dtscreen.Rows)
            {
                qoq = comparison(Convert.ToDouble(dr["ENDQUATER"]), Convert.ToDouble(dr["LASTQUATER"]));
                dr["qoq"] = qoq;

                if (dr["RPKIND"].ToString() == "사업보고서")
                {                    
                    yoy = comparison(Convert.ToDouble(dr["AccQuater"]), Convert.ToDouble(dr["Lastyear"]));                    
                    dr["yoy"] = yoy;
                }
                else
                {
                    yoy = comparison(Convert.ToDouble(dr["EndQuater"]), Convert.ToDouble(dr["Lastyear"]));
                    dr["yoy"] = yoy;
                }
            }

           DataTable dt =  dtscreen.Select(where).CopyToDataTable();

            //var query =
            //from dr in dtscreen.AsEnumerable()
            //where dr.Field<string>("item_stat")   == "A" &&
            //      dr.Field<string>("closingdate") == " " &&                 
            //    dr.Field<double>("qoq") == 123 &&
            //    dr.Field<double>("yoy") == 12
                

            //select new
            //{
            //    lot  = dr.Field<string>("lot"),
            //    data = dr.Field<double>("data")
            //};



            return dt;
        }
        
        private double comparison(double afterward,double previous)
        {
            double dod = 0;
            if (afterward != 0 && previous != 0)
            {
                dod = (afterward - previous) / previous ;
                dod = Convert.ToDouble(dod.ToString("F1"));
            }

            return dod;
        }

        // category & column type은 선택적 파라미터로 설정하고, 디폴트 값은 null로 처리

        public DataTable ConvertXY(DataTable org, string cat = "", string col_type = "")

        {
            DataTable dst = new DataTable();
            DataRow dr;
            DataColumn dc;

            int idx; // 분류값 추가여부에 따른 컬럼 생성 위치

            // 기존 테이블의 컬럼명은 새로운 테이블의 첫 번째 컬럼값으로 가야 하므로 'CATx' 컬럼으로 명명
            if (string.IsNullOrWhiteSpace(cat))  // 선택적 인수에 값이 없으면
            {
                idx = 1;
                dc = dst.Columns.Add("CAT1");
            }
            else
            {
                idx = 2;
                dc = dst.Columns.Add("CAT1");
                dc = dst.Columns.Add("CAT2");
            }

            // 기존 테이블의 각 행의 첫번째 컬럼값을, 새로운 테이블 컬럼명으로 세팅

            for (int r = 0; r < org.Rows.Count; r++)
                // 컬럼 타입은 자동으로 알 수 없으므로, 파라미터로 받아서 처리 (필요시 CASE 추가, 디폴트는 문자열)
                switch (col_type)

                {
                    case "decimal":
                        dc = dst.Columns.Add(org.Rows[r][0].ToString(), typeof(decimal));
                        break;
                    default:
                        dc = dst.Columns.Add(org.Rows[r][0].ToString(), typeof(string));
                        break;

                }

            // 첫 번째 컬럼은 컬럼명으로 변환 되었으므로, 두 번째 컬럼부터 데이터 생성
            for (int c = 1; c < org.Columns.Count; c++)
            {
                dr = dst.NewRow();
                if (cat == "")
                {
                    dr[0] = org.Columns[c].ColumnName;
                }
                else
                {
                    dr[0] = cat;
                    dr[1] = org.Columns[c].ColumnName;
                };

                for (int r = 0; r < org.Rows.Count; r++)
                    dr[r + idx] = org.Rows[r][c];  // 인덱스 위치에서부터 컬럼 생성

                dst.Rows.Add(dr);
            }

            dst.AcceptChanges();
            return dst;

        }


    }
}
