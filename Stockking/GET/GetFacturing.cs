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
        private static GetFacturing Alldata;

        GetQuery getQuery = new GetQuery();
        DataTable dt = new DataTable();

        private void GetAlldata()
        {
            dt = getQuery.AlltiemScreennig();         
        }
        public static GetFacturing ALLDATA()
        {
            if()
        }


        private DataTable Calculation_fourQuater()
        {
            DataTable dt = new DataTable();
            dt = getQuery.get_screening();

            int fourquater = 0;
            

            foreach (DataRow row in dt.Rows)
            {
                if (row["RPKIND"] == "사업보고서")
                {
                    fourquater = Convert.ToInt32(row["ENDQUATER"]);                        
                }
                else 
                {
                    fourquater -= Convert.ToInt32(row["ENDQUATER"]);
                }
            }


            return dt;
        }
    }
}
