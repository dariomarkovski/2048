using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    class Score
    {
        public string name { get; set; }
        public string score { get; set; }
        public string mode { get; set; }


        public Score(string n, string s, string m)
        {
            name = n;
            score = s;
            mode = m;
        }
    }
}
