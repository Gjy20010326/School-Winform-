using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StuMSModels;


namespace StuMSDal
{
    public class TeacherDal
    {
        //查询是否有账号密码
        public int SelUsers(string tid, string tPassword)
        {
            string sql = "select * from Teacher where tid='" + tid + "' and tPassword ='" + tPassword + "'";
            SqlDataReader dr = null;
            var a = 0;
            try
            {
                dr = ADOTools.ExcuteReader(sql);
                if (dr.HasRows)
                {
                    a = 1;
                }
                else
                {
                    a = 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
            return a;
        }
        //添加成绩
        public int InsSC_Mapping(SC_Mapping sc)
        {
            string sql = "insert into SC_Mapping values("+sc.Scid+","+sc.Sid+","+sc.Cid+","+sc.Score+");";
            return ADOTools.ExcuteNoQuery(sql);
        }
        //添加老师
        public int InsTeacher(Teacher t)
        {
            string sql = "insert into teacher values('" + t.Tname + "','" + t.TProfession + "','" + t.TPassword + "');";
            return ADOTools.ExcuteNoQuery(sql);
        }
        //删除老师
        public int DelTeacher(SqlTransaction tran, int tid)
        {
            string sql = "delete from teacher where tid=" + tid;
            return ADOTools.ExcuteNoQuery(tran, sql);
        }
        /// <summary>
        /// 按ID删除教师
        /// </summary>
        /// <param name="tid"></param>
        /// <returns></returns>
        public int DelTeacherByTid(int tid)
        {
            string sql = "delete from teacher where tid=" + tid;
            return ADOTools.ExcuteNoQuery(sql);
        }
        /// <summary>
        /// 查询教师
        /// </summary>
        /// <returns></returns>
        public List<Teacher> SelTeacher()
        {
            string sql = "select * from teacher";
            SqlDataReader dr = null;
            List<Teacher> list = null;
            try
            {
                dr = ADOTools.ExcuteReader(sql);
                list = new List<Teacher>();
                while (dr.Read())
                {
                    list.Add
                    (
                        new Teacher()
                        {
                            Tid = Convert.ToInt32(dr["tid"]),
                            Tname = dr["tname"].ToString(),
                            TProfession = dr["tProfession"].ToString(),
                            TPassword = dr["tpassword"].ToString()
                        }
                    );
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dr.Dispose();
            }
            return list;
        }
    }
}
