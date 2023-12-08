namespace Demo_Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bucheron b = new Bucheron();
            b.VeutCouperArbre += delegate (object bucheron, BucheronEventArgs args)
            {
                Console.WriteLine(args.Message);
            };
            b.Couper();

            Arbre a = new Arbre();
            a.VaTomber += delegate (object arbre, BucheronEventArgs args)
            {
                Console.WriteLine(args.Message);
            };

            b.ChoisiArbre(a);
            b.Couper();
            b.Couper();
            b.Couper();
            b.Couper();
        }
    }
}
