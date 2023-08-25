using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Insan insan = new Insan();

            // insan.SetAdi("Zeynep");
            //insan.SetSoyAdi("Cankus");
            //insan.SetYasi(38);

            insan.Adi = "Zeynep";
            insan.SoyAdi = "Cankus";
            insan.Yasi = 38;

            Console.WriteLine("Adi : " + insan.Adi);
            Console.WriteLine("SoyAdi : " + insan.SoyAdi);
            Console.WriteLine("Yas : " + insan.Yasi);


            Console.Read();
        }
    }

    class Insan
    {
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
        public int Yasi { get; set; }
    }   
}
