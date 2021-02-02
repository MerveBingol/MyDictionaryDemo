using System;
using System.Collections.Generic;

namespace MyDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<int, string> sehirVeYemek = new MyDictionary<int, string>();
            sehirVeYemek.Add(25," Cağ Kebabı");
            sehirVeYemek.Add(16," İskender");
            sehirVeYemek.Add(33," Tantuni");
            sehirVeYemek.Add(01,"  Adana Kebap");
            sehirVeYemek.Add(61," Mıhlama");

            sehirVeYemek.Write();
            Console.ReadKey();



        }
    }

}



    




