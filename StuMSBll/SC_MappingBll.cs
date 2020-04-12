using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StuMSDal;
using StuMSModels;
using System.Data;
using System.Data.SqlClient;


namespace StuMSBll
{
    public class SC_MappingBll
    {
        private SC_MappingDal scd = new SC_MappingDal();
        public bool InsSC_Mapping(SC_Mapping sc)
        {
            return scd.InsSC_Mapping(sc) > 0;
        }
        public bool DelSC_Mapping(int scid)
        {
            return scd.DelSC_Mapping(scid) > 0;
        }
        public DataTable SelSC_Mapping()
        {
            return scd.SelSC_MAPPING();
        }
        public DataTable SelSC_Mapping2()
        {
            return scd.SelSC_Mapping2();
        }
        public DataTable SelSC_Mapping3()
        {
            return scd.SelSC_Mapping3();
        }
        public DataTable SelSC()
        {
            return scd.SelSC();
        }
    }
}
