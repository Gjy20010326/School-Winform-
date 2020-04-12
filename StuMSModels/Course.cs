using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuMSModels
{
    public class Course
    {
        private int _cid;
        private int _tid;
        private string _cname;
        private int _climit;

        public int Cid { get => _cid; set => _cid = value; }
        public int Tid { get => _tid; set => _tid = value; }
        public string Cname { get => _cname; set => _cname = value; }
        public int Climit { get => _climit; set => _climit = value; }
    }
}
