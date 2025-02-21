namespace _02._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cica cica = new Cica("Mici", 3, 5, "Sziámi", "Fehér", 20, 2, "Nőstény");

            Console.WriteLine("A cica adatai:");
            Console.WriteLine($"Név: {cica.Nev}");
            Console.WriteLine($"Kor: {cica.Kor}");
            Console.WriteLine($"Súly: {cica.Suly}");
            Console.WriteLine($"Fajta: {cica.Fajta}");
            Console.WriteLine($"Szín: {cica.Szin}");
            Console.WriteLine($"Rendetlenségszint: {cica.Rendetlensegszint}");
            Console.WriteLine($"Fogyasztás: {cica.Fogyasztas}");
            Console.WriteLine($"Nem: {cica.Nem}");
            Console.WriteLine($"Éhes: {cica.Ehes}");

            cica.Ebredes();
            Console.WriteLine("\nA cica felébred:");
            Console.WriteLine($"Rendetlenségszint: {cica.Rendetlensegszint}");
            Console.WriteLine($"Éhes: {cica.Ehes}");

            while (cica.Rendetlensegszint > 0)
            {
                if (cica.Ehes)
                {
                    Console.WriteLine("\nA cica eszik:");
                    cica.Eves(0.5);
                    Console.WriteLine($"Súly: {cica.Suly}");
                    Console.WriteLine($"Rendetlenségszint: {cica.Rendetlensegszint}");
                }

                Console.WriteLine("\nA cica játszik:");
                cica.Jatek();

                if (cica.Ehes)
                {
                    Console.WriteLine("\nA cica eszik játék után:");
                    cica.Eves(0.5);
                    Console.WriteLine($"Súly: {cica.Suly}");
                    Console.WriteLine($"Rendetlenségszint: {cica.Rendetlensegszint}");
                }
            }

            Console.WriteLine("\nA cica lefeküdt aludni");
            cica.Alvas();

        }
    }
}