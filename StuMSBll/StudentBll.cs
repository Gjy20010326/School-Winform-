using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StuMSDal;
using StuMSModels;
using System.Data.SqlClient;
using System.Data;

namespace StuMSBll
{
    public class StudentBll
    {
        private StudentDal sd = new StudentDal();
        private SC_MappingDal sc = new SC_MappingDal();
        //查看账号密码是否存在
        public bool SelStudent(string sid, string spassword)
        {
            return sd.SelStudent(sid, spassword) > 0;
        }
        //修改密码
        public bool UpdStudentPwd(string pwd, int sid)
        {
            return sd.UpdStudentPwd(pwd, sid) > 0;
        }
        //添加学生
        public bool InsStudent(Student s)
        {
            return sd.InsStudent(s) > 0;
        }
        //删除学生
        public bool DelStudent(int sid)
        {
            SqlConnection conn = null;
            SqlTransaction tran = null;
            bool flag = false;
            try
            {
                conn = new SqlConnection(ADOTools.connStr);
                conn.Open();
                tran = conn.BeginTransaction();
                sc.DelSC_MappingBySID(tran, sid);
                sd.DelStudent(tran, sid);
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
        
        //按name查询
        public DataTable SelStudentName(string sname)
        {
            return sd.SelStudentName(sname);
        }
        
        //public List<Student> UpdStudent(int id)
        //{
        //    return sd.UpdStudent(id);
        //}
        /// <summary>
        /// 修改基本信息
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool UpdStudent(Student s)
        {
            return sd.UpdStudent(s)>0;
        }
    }
}
