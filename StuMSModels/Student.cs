using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuMSModels
{
    public class Student
    {
        private int _sid;
        private string _sname; 
        private string _sbirthday;
        private string _ssex;
        private string _spassword;

        public int Sid { get => _sid; set => _sid = value; }
        public string Sname { get => _sname; set => _sname = value; }
        public string Sbirthday { get => _sbirthday; set => _sbirthday = value; }
        public string Ssex { get => _ssex; set => _ssex = value; }
        public string Spassword { get => _spassword; set => _spassword = value; }
        
    }
}
