using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Event
{
    delegate void ArbreAction(object objet, BucheronEventArgs args);
    internal class Arbre
    {

        public event ArbreAction VaTomber;

        private int _resistance;

        public int Resistance
        {
            get { return _resistance; }
            private set { 
                if(value < 0) value = 0;
                _resistance = value;
                if (_resistance == 0) VaTomber(this, new BucheronEventArgs(null,this,"Je tombe!") );
            }
        }

        public Arbre()
        {
            _resistance = 3;
        }

        public void EtreCouper(object bucheron, BucheronEventArgs args)
        {
            Resistance--;
        }
    }
}
