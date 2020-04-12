using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuMSModels
{
    public class System_Users
    {
        private int _uid;
        private string _ucode;
        private string _upwd;

        public int Uid { get => _uid; set => _uid = value; }
        public string Ucode { get => _ucode; set => _ucode = value; }
        public string Upwd { get => _upwd; set => _upwd = value; }
    }
}
