using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    internal class URL : IURL
    {
        private string DNS;

        public URL(string dNS)
        {
            DNS1 = dNS;
        }

        public string DNS1 { get => DNS; set => DNS = value; }
    }
}
