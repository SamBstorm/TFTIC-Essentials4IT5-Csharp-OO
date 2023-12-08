namespace Demo_Delegue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Legrain","Samuel",new DateOnly(1987,9,27));
            e1.AjoutTache(e1.FairePhotocopie);
            e1.AjoutTache(e1.FaireRevenu);
            e1.AjoutTache(e1.SeCacherAuWC);
            e1.AjoutTache(e1.FairePhotocopie);
            e1.AjoutTache(e1.FaireGreve);
            e1.AjoutTache(e1.Promouvoir("Récurer les toilettes du boss..."));
            try
            {
                e1.ExecuteTaches();
            }
            catch (MaterielException ex)
            {
                Console.WriteLine(ex.Message);
                e1.FaireGreve();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Aie! Tous se passe pas comme prévu, votre employé rentre chez lui... ({ex.Message})");
            }
        }
    }
}
