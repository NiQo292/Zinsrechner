using System.Collections;

namespace Zinsenrechner
{
    public class Zinsenrechner
    {
        double anfangskapital, zinssatz, endkapital, jahre, zinsen;
        int eingabe;
        static void Main()
        {
            Zinsenrechner prog = new Zinsenrechner();
            prog.calculate();
        }

        public void calculate()
        {
            System.Console.WriteLine("Bitte wählen Sie eine Option aus!");
            System.Console.WriteLine("1: Endkapital berechnen");
            System.Console.WriteLine("2: Anfangskapital berechnen");
            System.Console.WriteLine("3: Zinssatz berechnen");
            System.Console.WriteLine("4: Laufzeit berechnen (Zinseszins)");
            System.Console.WriteLine("5: Endkapital berechnen (Zinseszins)");
            System.Console.WriteLine("6: Anfangskapital berechnen (Zinseszins)");
            System.Console.WriteLine("7: Zinssatz berechnen (Zinseszins)");
            System.Console.WriteLine("----------------------");
            eingabe = Convert.ToInt32(Console.ReadLine());

            switch (eingabe)
            {
                case 1:
                    System.Console.WriteLine("Anfangskapital eingeben");
                    anfangskapital = Convert.ToDouble(Console.ReadLine());

                    System.Console.WriteLine("Zinssatz eingeben");
                    zinssatz = Convert.ToDouble(Console.ReadLine());

                    jahre = 1;

                    endkapital = anfangskapital * (1 + zinssatz * jahre / 100);
                    System.Console.WriteLine("Endkapital: " + endkapital);
                    break;
                case 2:
                    System.Console.WriteLine("Endkapital eingeben");
                    endkapital = Convert.ToDouble(Console.ReadLine());

                    System.Console.WriteLine("Zinssatz eingeben");
                    zinssatz = Convert.ToDouble(Console.ReadLine());

                    jahre = 1;

                    anfangskapital = endkapital / (1 + zinssatz * jahre / 100);
                    System.Console.WriteLine("Anfangskapital: " + anfangskapital);
                    break;
                case 3:
                    System.Console.WriteLine("Anfangskapital eingeben");
                    anfangskapital = Convert.ToDouble(Console.ReadLine());

                    System.Console.WriteLine("Endkapital eingeben");
                    endkapital = Convert.ToDouble(Console.ReadLine());

                    jahre = 1;

                    zinsen = endkapital - anfangskapital;

                    zinssatz = (zinsen * 100) / anfangskapital;
                    System.Console.WriteLine("Der Zinssatz ist: " + zinssatz + "%");
                    break;
                case 4:
                    System.Console.WriteLine("Anfangskapital eingeben");
                    anfangskapital = Convert.ToDouble(Console.ReadLine());

                    System.Console.WriteLine("Zinssatz eingeben");
                    zinssatz = Convert.ToDouble(Console.ReadLine());

                    System.Console.WriteLine("Endkapital eingeben");
                    endkapital = Convert.ToDouble(Console.ReadLine());

                    double laufzeit = Math.Log10(endkapital / anfangskapital) / Math.Log10(1+ zinssatz / 100);
                    System.Console.WriteLine("Die Laufzeit beträgt: " + laufzeit + " Jahre");
                    break;
                case 5:
                    System.Console.WriteLine("Anfangskapital eingeben");
                    anfangskapital = Convert.ToDouble(Console.ReadLine());

                    System.Console.WriteLine("Zinssatz eingeben");
                    zinssatz = Convert.ToDouble(Console.ReadLine());

                    System.Console.WriteLine("Laufzeit eingeben");
                    jahre = Convert.ToDouble(Console.ReadLine());

                    endkapital = anfangskapital * Math.Pow((1 + zinssatz / 100), jahre);
                    System.Console.WriteLine("Endkapital: " + endkapital);
                    break;
                case 6:
                    System.Console.WriteLine("Endkapital eingeben");
                    endkapital = Convert.ToDouble(Console.ReadLine());

                    System.Console.WriteLine("Zinssatz eingeben");
                    zinssatz = Convert.ToDouble(Console.ReadLine());

                    System.Console.WriteLine("Laufzeit eingeben");
                    jahre = Convert.ToDouble(Console.ReadLine());

                    anfangskapital = endkapital / Math.Pow((1 + zinssatz / 100), jahre);
                    System.Console.WriteLine("Anfangskapital: " + anfangskapital);
                    break;
                case 7:
                    System.Console.WriteLine("Anfangskapital eingeben");
                    anfangskapital = Convert.ToDouble(Console.ReadLine());

                    System.Console.WriteLine("Endkapital eingeben");
                    endkapital = Convert.ToDouble(Console.ReadLine());

                    System.Console.WriteLine("Laufzeit eingeben");
                    jahre = Convert.ToDouble(Console.ReadLine());

                    zinsen = endkapital - anfangskapital;

                    zinssatz = 100 * (Math.Pow(endkapital / anfangskapital, 1 / jahre) - 1 );
                    System.Console.WriteLine("Der Zinssatz ist:" + zinssatz + "%");
                    break;
            }
        }
    }
}