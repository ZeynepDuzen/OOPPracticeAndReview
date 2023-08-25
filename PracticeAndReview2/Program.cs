using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndReview2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba1 = new Araba();
            araba1.Marka = "Mini";
            araba1.Model = "Cooper";
            araba1.TrafigeCikis = DateTime.Parse("07.02.2022");
            araba1.BeygirGucu = 184;
            //araba1.KapiSayisi;
            araba1.MotorHacmi = 1600;
            Console.WriteLine("Marka : " + araba1.Marka + "\n" + "Model : " + araba1.Model + "\n" +
            "Trafige Cikis : " + araba1.TrafigeCikis.ToString("dd.mm.yyyy") + "\n" + "Beygir Gucu : " + araba1.BeygirGucu + "\n" +
            "Kapi Sayisi : " + araba1.KapiSayisi + "\n" + "Motor Hacmi : " + araba1.MotorHacmi + "\n" +
            "Araba Tipi : " + araba1.Turu);

            Araba araba2 = new Araba();
            araba2.Marka = "Fiat";
            araba2.Model = "Doblo";
            araba2.Turu = ArabaTipi.Ticari;
            araba2.TrafigeCikis = DateTime.Parse("07.02.2023");
            araba2.BeygirGucu = 68;
            araba2.KapiSayisi = 5;
            araba2.MotorHacmi = 1300;
            Console.WriteLine();
            Console.WriteLine("Marka :" + araba2.Marka + "\n" + "Model : " + araba2.Model + "\n" +
            "Turu : " + araba2.Turu + "\n" + "Trafige Cikis : " + araba2.TrafigeCikis.ToString("dd/mm/yyyy") + "\n" +
            "Beygir Gucu : " + araba2.BeygirGucu + "\n" + "Kapi Sayisi : " + araba2.KapiSayisi + "\n" +
            "Motor Hacmi : " + araba2.MotorHacmi);
               
            

               
            Console.Read();
        }
    }
}
