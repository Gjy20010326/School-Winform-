using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StuMSModels;
using System.Data;

namespace StuMSDal
{
    public class StudentDal
    {
        public int SelStudent(string sid, string spassword)
        {
            //查询账号密码是否存在
            string sql = "select * from Student where sid='" + sid + "' and spassword ='" + spassword + "'";
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
                dr.Dispose();
            }
            return a;
        }
        //修改密码
        public int UpdStudentPwd(string pwd ,int sid)
        {
            string sql = "Update student set spassword='"+pwd+"' where sid="+sid;
            return ADOTools.ExcuteNoQuery(sql);
        }

        //添加学生
        public int InsStudent(Student s)
        {
            string sql = "insert into Student values('" + s.Sname + "','" + s.Sbirthday + "','" + s.Ssex + "','" + s.Spassword + "');";
            return ADOTools.ExcuteNoQuery(sql);
        }
        //删除学生
        public int DelStudent(SqlTransaction tran, int sid)
        {
            string sql = "delete from student where sid=" + sid;
            return ADOTools.ExcuteNoQuery(tran, sql);
        }
        
        //按name查询
        public DataTable SelStudentName(string sname)
        {
            string name = @"select sid,sname,
                            case ssex
                            when'1' then'男'
                            else '女' end As ssex,
                            sbirthday,spassword from student
                            where sname like '%"+sname+"%'";
            return ADOTools.ExcuteDataTable(name);
        }
        /// <summary>
        /// 修改基本信息
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int UpdStudent(Student s)
        {
            string sql = "update student set sname='" + s.Sname + "',sbirthday='" + s.Sbirthday + "',ssex='" + s.Ssex + "',spassword='" + s.Spassword + "' where sid=" + s.Sid + "";
            return ADOTools.ExcuteNoQuery(sql);
        }
        /// <summary>
        /// 按照学生ID查询成绩
        /// </summary>
        /// <returns></returns>
        public DataTable SearchStuID(int sid)
        {
            string sql = @"select s.sname,c.cname,sc.score from SC_Mapping as sc
                            inner join student as s on s.sid = sc.sid
                            inner join course as c on c.cid = sc.cid
                            where s.sid = "+sid;
            return ADOTools.ExcuteDataTable(sql);
        }

        //public List<Student> UpdStudent(int id)
        //{
        //    SqlConnection conn = new SqlConnection(ADOTools.connStr);
        //    conn.Open();
        //    string sql = "select sid,sname,sbirthday, ssex,spassword from student where sid = " + id;
        //    SqlCommand cmd = new SqlCommand(sql, conn);
        //    SqlDataReader dr = null;
        //    List<Student> list = new List<Student>();
        //    try
        //    {
        //        dr = cmd.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            list.Add
        //            (
        //                new Student()
        //                {
        //                    Sid = int.Parse(dr["sid"].ToString()),
        //                    Sname = dr["sname"].ToString(),
        //                    Sbirthday = dr["sbirthday"].ToString(),
        //                    Ssex = dr["ssex"].ToString(),
        //                    Spassword = dr["spassword"].ToString()
        //                }
        //            );
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        dr.Dispose();
        //        conn.Dispose();
        //    }
        //    return list;
        //}



    }
}
