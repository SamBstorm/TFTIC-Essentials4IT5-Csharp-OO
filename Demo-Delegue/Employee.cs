using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Delegue
{
    internal class Employee
    {

        public string Nom {  get; private set; }
        public string Prenom { get; private set; }
        public DateOnly DateNaissance { get; private set; }

        private EmployeeAction _taches;

        public Employee(string nom, string prenom, DateOnly dateNaissance)
        {
            if (nom is null) throw new ArgumentNullException(nameof(nom));
            if (prenom is null) throw new ArgumentNullException(nameof(nom));
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
        }
        
        public void AjoutTache(EmployeeAction tache)
        {
            _taches += tache;
        }

        public void FairePhotocopie()
        {
            Console.WriteLine("Je vais faire une copie...");
            if(new Random().Next(5) == 0) throw new MaterielException("Bourrage papier");
        }

        public void FaireGreve()
        {
            Console.WriteLine("Pas content!");
        }

        public void FaireRevenu()
        {
            Console.WriteLine("Je bosse sans arrêt!");
        }

        public void SeCacherAuWC()
        {
            Console.WriteLine("Je ne suis plus là!");
        }

        public void ExecuteTaches()
        {
            Console.WriteLine("Je démarre la journée...");
            if (_taches is null) Console.WriteLine("Je n'ai rien à faire!");
            else _taches();
            Console.WriteLine("Dure journée...");
        }

        public EmployeeAction Promouvoir(string nouvelleTache)
        {
            return delegate ()
            {
                Console.WriteLine(nouvelleTache);
            };
        }
    }
}
