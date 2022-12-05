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
        static DataTable dt = new DataTable();

        GetQuery getQuery = new GetQuery();



        public static GetFacturing ALLDATA()
        {
            if (Alldata == null)
                Alldata = new GetFacturing();

            return Alldata;
        }

        public void GetAlldata()
        {
           dt = getQuery.AlltiemScreennig();
      
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
