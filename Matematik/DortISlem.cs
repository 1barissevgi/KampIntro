﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortISlem
    {
       public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç : " + toplam);
        }

        public void Cikar(int sayi1, int sayi2)
        {
            int cikarma = sayi1 - sayi2;
            Console.WriteLine("Sonuç : " + cikarma);
        }

        public void Carp(int sayi1, int sayi2)
        {
            int carpma = sayi1 * sayi2;
            Console.WriteLine("Sonuç : " + carpma);
        }

        public void Bol(int sayi1, int sayi2)
        {
            int bolme = sayi1 / sayi2;
            Console.WriteLine("Sonuç : " + bolme);
        }
    }
}
