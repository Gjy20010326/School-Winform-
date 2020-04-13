using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StuMSModels;
using System.Data;
using System.Data.SqlClient;

namespace StuMSDal
{
    public class SC_MappingDal
    {
        //添加成绩
        public int UpdSC_Mapping(SC_Mapping sc)
        {
            string sql = "update SC_Mapping set score="+sc.Score+" where sid="+sc.Sid+" and cid="+sc.Cid+"";
            return ADOTools.ExcuteNoQuery(sql);
        }

        
        /// <summary>
        /// 选课
        /// </summary>
        /// <param name="sc"></param>
        /// <returns></returns>
        //public int InsSC_Mapping(SC_Mapping sc)
        //{
        //    string sql = "insert into SC_Mapping(tid,cid,score)values("+sc.Sid+","",null);";
        //}




        //按scid删除
        public int DelSC_Mapping(int scid)
        {
            string sql = "delete from SC_Mapping where scid=" + scid;
            return ADOTools.ExcuteNoQuery(sql);
        }
        //按cid删除
        public int DelSC_MappingByCID(SqlTransaction tran, int cid)
        {
            string sql = "delete from SC_Mapping where cid=" + cid;
            return ADOTools.ExcuteNoQuery(tran, sql);
        }
        //按sid删除
        public int DelSC_MappingBySID(SqlTransaction tran, int sid)
        {
            string sql = "delete from SC_Mapping where sid=" + sid;
            return ADOTools.ExcuteNoQuery(tran, sql);
        }
        public DataTable SelSC_MAPPING()
        {
            string sql = @"select scid ,c.cname,score from SC_Mapping as sc
                            inner join course as c on c.cid = sc.cid";
            return ADOTools.ExcuteDataTable(sql);
        }
        public DataTable SelSC_Mapping2()
        {
            string sql = @"select sid,sname,
                            case ssex
                            when'1' then'男'
                            else '女' end As ssex,
                            sbirthday,spassword from student";
            return ADOTools.ExcuteDataTable(sql);
        }
        public DataTable SelSC_Mapping3()
        {
            string sql = @"select scid,sname,c.cid,c.cname,score  from SC_Mapping as sc
                            inner join Student as s on s.sid = sc.sid
                            inner join Course as c on c.cid = sc.cid";
            return ADOTools.ExcuteDataTable(sql);
        }
        public DataTable SelSC()
        {
            string sql = @"select c.cid,c.cname,s.sname,tname  from SC_Mapping as sc
                            inner join student as s on s.sid=sc.sid
                            inner join course as c on c.cid=sc.cid
                            inner join teacher as t on t.tid=c.tid";
            return ADOTools.ExcuteDataTable(sql);
        }
        
    }
}
