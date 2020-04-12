using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuMSModels
{
    public class SC_Mapping
    {
        private int _scid;
        private int _sid;
        private int _cid;
        private int _score;

        public int Scid { get => _scid; set => _scid = value; }
        public int Sid { get => _sid; set => _sid = value; }
        public int Cid { get => _cid; set => _cid = value; }
        public int Score { get => _score; set => _score = value; }
    }
}
