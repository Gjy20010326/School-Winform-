using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using StuMSDal;
using StuMSModels;

namespace StuMSBll
{
    public class System_UsersBll
    {
        private System_UsersDal su = new System_UsersDal();
        //查询管理员账号密码是否存在
        public bool SelUsers(string ucode, string upwd)
        {
            return su.SelUsers(ucode, upwd) > 0;
        }

    }
}
