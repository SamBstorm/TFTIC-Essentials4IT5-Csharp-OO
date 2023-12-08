using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Event
{
    internal class BucheronEventArgs : EventArgs
    {

        public Bucheron Bucheron { get; set; }
        public Arbre Arbre { get; set; }
        public string Message { get; set; }

        public BucheronEventArgs(Bucheron bucheron, Arbre arbre, string message)
        {
            Bucheron = bucheron;
            Arbre = arbre;
            Message = message;
        }
        
    }
}
