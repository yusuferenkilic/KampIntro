﻿using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyaçKrediManager = new IhtiyacKrediManager();   //IhtiyacKrediManager ihtiyaçKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(konutKrediManager);


            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyaçKrediManager };

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
