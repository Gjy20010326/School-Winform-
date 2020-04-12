using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StuMSDal;
using StuMSModels;
using System.Data;

namespace StuMSBll
{
    public class CourseBll
    {
        private CourseDal cd = new CourseDal();
        private SC_MappingDal scm = new SC_MappingDal();
        public bool InsCourse(Course c)
        {
            return cd.InsCourse(c)>0;
        }
        public bool DelCourse(int cid)
        {
            SqlConnection conn = null;
            SqlTransaction tran = null;
            bool flag = false;
            try
            {
                conn = new SqlConnection(ADOTools.connStr);
                conn.Open();
                tran = conn.BeginTransaction();
                scm.DelSC_MappingByCID(tran,cid);
                cd.DelCourse(tran,cid);
                flag = true;
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                throw ex;
            }
            finally
            {
                tran.Dispose();
                conn.Dispose();
            }
            return flag;

        }
        public List<Course> SelCourse()
        {
            return cd.SelCourse();
        }
        public DataTable SelCourseDT()
        {
            return cd.SelCourseDT();
        }
        public DataTable SelCT(int cid,string tname,string cname)
        {
            return cd.SelCT(cid,tname,cname);
        }
        /// <summary>
        /// 按tid删除course表里的数据
        /// </summary>
        /// <param name="tran"></param>
        /// <param name="tid"></param>
        /// <returns></returns>
        public int DelCourseByTid(int tid)
        {
            return cd.DelCourseByTid(tid);
            //SqlConnection conn = null;
            //SqlTransaction tran = null;
            //bool flag = false;
            //try
            //{
            //    conn = new SqlConnection(ADOTools.connStr);
            //    conn.Open();
            //    tran = conn.BeginTransaction();
            //    scm.DelSC_MappingByCID(tran, tid);
            //    cd.DelCourse(tran, tid);
            //    flag = true;
            //    tran.Commit();
            //}
            //catch (Exception ex)
            //{
            //    tran.Rollback();
            //    throw ex;
            //}
            //finally
            //{
            //    tran.Dispose();
            //    conn.Dispose();
            //}
            //return flag;
        }

    }
}
