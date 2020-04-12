using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StuMSModels;

namespace StuMSDal
{
    public class CourseDal
    {
        //添加课程、老师、限制人数
        public int InsCourse(Course c)
        {
            string sql = "insert into Course values(" + c.Tid + ",'" + c.Cname + "'," + c.Climit + ")";
            return ADOTools.ExcuteNoQuery(sql);
        }
        //单独删除课程
        //public int DelCourseByID(int cid)
        //{
        //    string sql = "delete from Course where cid=" + cid;
        //    return ADOTools.ExcuteNoQuery(sql);
        //}
        //删除课程
        public int DelCourse(SqlTransaction tran, int cid)
        {
            string sql = "delete from Course where cid=" + cid;
            return ADOTools.ExcuteNoQuery(tran, sql);
        }
        //查询课程
        public List<Course> SelCourse()
        {
            string sql = "select * from course";
            SqlDataReader dr = null;
            List<Course> list = null;
            try
            {
                dr = ADOTools.ExcuteReader(sql);
                list = new List<Course>();
                while (dr.Read())
                {
                    list.Add
                        (
                            new Course()
                            {
                                Cid = Convert.ToInt32(dr["cid"]),
                                Tid = Convert.ToInt32(dr["tid"]),
                                Cname = dr["cname"].ToString(),
                                Climit=Convert.ToInt32(dr["climit"])
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
        //显示DataTable课程
        public DataTable SelCourseDT()
        {
            string sql = @"select cid,t.tname,cname from course as c inner join teacher as t on t.tid=c.tid";
            return ADOTools.ExcuteDataTable(sql);
        }
        public DataTable SelCT(int cid,string tname,string cname)
        {
            string sql = "exec CoursePor "+cid+",'"+tname+"','"+cname+"'";
            return ADOTools.ExcuteDataTable(sql);
        }
    }
}
