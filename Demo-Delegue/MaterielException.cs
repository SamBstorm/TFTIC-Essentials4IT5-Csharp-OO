using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Delegue
{
    internal class MaterielException : Exception
    {
        public MaterielException() : base("Matériel en panne!") { }

        public MaterielException(string detail) : base($"Matériel en panne : {detail} !") { }
    }
}
