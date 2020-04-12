using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuMSModels
{
    public class Teacher
    {
        private int _tid;
        private string _tname;
        private string _tProfession;
        private string _tPassword;

        public int Tid { get => _tid; set => _tid = value; }
        public string Tname { get => _tname; set => _tname = value; }
        public string TProfession { get => _tProfession; set => _tProfession = value; }
        public string TPassword { get => _tPassword; set => _tPassword = value; }
    }
}
