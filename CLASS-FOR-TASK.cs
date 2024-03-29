using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    internal class CLASS_FOR_TASK
    {
        public string Name { get; set; }
        public string Opic { get; set; }
        public string _1Var { get; set; }
        public string _2Var { get; set; }
        public string _3Var { get; set; }
        public Enum Pravil { get; set; }

        public CLASS_FOR_TASK(string name, string opic, string _1var, string _2var, string _3var, Enum pravil)
        {
            Name = name;
            Opic = opic;
            _1Var = _1var;
            _2Var = _2var;
            _3Var = _3var;
            Pravil = pravil;
        }
    }
}
