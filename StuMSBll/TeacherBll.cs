using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StuMSDal;
using StuMSModels;
using System.Data.SqlClient;

namespace StuMSBll
{
    public class TeacherBll
    {
        private TeacherDal td = new TeacherDal();
        private CourseDal c = new CourseDal();
        private SC_MappingDal scm = new SC_MappingDal();
        public bool SelUsers(string tid, string tPassword)
        {
            return td.SelUsers(tid,tPassword)>0;
        }
        public bool InsTeacher(Teacher t)
        {
            return td.InsTeacher(t)>0;
        }
        public bool DelTeacher( int tid)
        {
            SqlConnection conn = null;
            SqlTransaction tran = null;
            bool flag = false;
            try
            {
                conn = new SqlConnection(ADOTools.connStr);
                conn.Open();
                tran = conn.BeginTransaction();
                c.DelCourse(tran,tid);
                td.DelTeacher(tran, tid);
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
        public List<Teacher> SelTeacher()
        {
            return td.SelTeacher();
        }
        public bool DelTeacherByTid(int tid)
        {
            return td.DelTeacherByTid(tid)>0;
        }
    }
}
