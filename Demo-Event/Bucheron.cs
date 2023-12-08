using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Event
{
    delegate void BucheronAction(object objet, BucheronEventArgs args);
    internal class Bucheron
    {
        public event BucheronAction VeutCouperArbre;
        private Arbre _arbre;

        public void ChoisiArbre(Arbre arbre)
        {
            _arbre = arbre;
            VeutCouperArbre += _arbre.EtreCouper;
            _arbre.VaTomber += PlusArbre;
        }

        public void Couper()
        {
            if(_arbre == null) VeutCouperArbre(this, new BucheronEventArgs(this, _arbre,"Faudrait d'abord avoir un arbre!"));
            else VeutCouperArbre(this, new BucheronEventArgs(this, _arbre, "Je fends le bois!"));
        }

        public void PlusArbre(object arbre, BucheronEventArgs args)
        {
            VeutCouperArbre -= _arbre.EtreCouper;
            _arbre.VaTomber -= PlusArbre;
            _arbre = null;
        }
    }
}
