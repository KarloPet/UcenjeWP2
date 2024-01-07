using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("V02")]
    public class V02ZimskoVjezbanje : ControllerBase
    {

        [HttpGet]
        [Route("Zad1")]
        public int Zad1() //1. Ruta ne prima niti jedan parametar i vra?a zbroj prvih 100 brojeva

        {
            int Zbroj = 0;

            for (int i = 1; i <= 100; i++)
            {
                Zbroj += i;
            }
            return Zbroj;

        }

        [HttpGet]
        [Route("Zad2")]
        public int[] Zad2() //2. Ruta ne prima niti jedan parametar i vra?a niz s svim parnim brojevima od 1 do 57
        {
            int[] Niz = new int[28];
            int Index = 0;

            for (int i = 1; i <= 57; i++)
            {
                if (i % 2 == 0)
                {
                    Niz[Index++] = i;
                }
            }
            return Niz;
        }

        [HttpGet]
        [Route("Zad3")]
        public int Zad3() //3. Ruta ne prima niti jedan parametar i vra?a zbroj svih parnih brojeva od 2 do 18
        {
            int Zbroj = 0;
            for (int i = 0; i <= 18; i++)
            {
                if (i % 2 == 0)
                {
                    Zbroj += i;
                }
            }
            return Zbroj;
        }

        [HttpGet]
        [Route("Zad4")]
        public int Zad4(int x) //4. Ruta prima jedan parametar koji je cijli broj i vra?a zbroj svih brojava od 1 do primljenog broja
        {
            int Zbroj = 0;

            for (int i = 1; i <= x; i++)
            {
                Zbroj += i;
            }
            return Zbroj;
        }

        [HttpGet]
        [Route("Zad5")]
        public int[] Zad5(int ManjiBroj, int VeciBroj) //5. Ruta prima dva parametra koji su cijeli brojevi i vra?a niz s svim parnim brojevima izme?u primljenih brojeva
        {
            int[] Niz = new int[VeciBroj / 2];
            int Index = 0;

            for (int i = ManjiBroj; i <= VeciBroj; i++)
            {

                if (i % 2 == 0)
                {
                    Niz[Index++] = i;
                }

            }
            return Niz;
        }
        [HttpGet]
        [Route("Zad6")]
        public int[] Zad6(int ManjiBroj, int VeciBroj)//6. Ruta prima dva parametra koji su cijeli brojevi i vra?a niz s svim neparnim brojevima izme?u primljenih brojeva
        {
            int[] Niz = new int[(VeciBroj - ManjiBroj +1 ) / 2]; 
            int Index = 0;

            for (int i = ManjiBroj; i <= VeciBroj; i++)
            {

                if (i % 2 != 0)
                {
                    Niz[Index++] = i++;
                }

            }
            return Niz;
        }
        //[HttpGet]
        //[Route("Zad7")]
        //public int Zad7(int ManjiBroj, int VeciBroj)
        //{
        //    int Zbroj = 0;
        //    int MB = ManjiBroj;
        //    int VB = VeciBroj;

        //    for (int i=MB;i <= VB;i++)
        //    {
        //        Zbroj += i;
        //    }
        //    return Zbroj;
        //}

        [HttpGet]
        [Route("Zad7")]
        public int Zad7(int Broj1, int Broj2) //7. Ruta prima dva parametra koji su cijeli brojevi i vra?a zbroj svih brojeva izme?u primljenih brojeva
        {
            int Zbroj = 0;
            int ManjiBroj = 0;
            int VeciBroj = 0;

            if (Broj1 > Broj2)
            {
                VeciBroj = Broj1;
                ManjiBroj = Broj2;
            }
            else if (Broj1 < Broj2)
            {
                VeciBroj = Broj2;
                ManjiBroj = Broj1;
            }
            else
            {
                ManjiBroj = Broj1;
                VeciBroj = Broj2;
            }

            for (int i = ManjiBroj; i <= VeciBroj; i++)
            {
                Zbroj += i;
            }
            return Zbroj;
        }


        [HttpGet]
        [Route("Zad8")]
        public int Zad8(int Broj1, int Broj2)//8. Ruta prima dva parametra koji su cijeli brojevi i vra?a zbroj svih brojeva izme?u primljenih brojeva koji su cjelobrojno djeljivi s 3
        {
            int Zbroj = 0;
            int ManjiBroj = 0;
            int VeciBroj = 0;

            if (Broj1 > Broj2)
            {
                VeciBroj = Broj1;
                ManjiBroj = Broj2;
            }
            else if (Broj1 < Broj2)
            {
                VeciBroj = Broj2;
                ManjiBroj = Broj1;
            }
            else
            {
                ManjiBroj = Broj1;
                VeciBroj = Broj2;
            }

            for (int i = ManjiBroj; i <= VeciBroj; i++)
            {
                if (i % 3 == 0)
                {
                    Zbroj += i;
                }
            }
            return Zbroj;
        }
        [HttpGet]
        [Route("Zad9")]
        public int Zad9(int Broj1, int Broj2)//9. Ruta prima dva parametra koji su cijeli brojevi i vra?a zbroj svih brojeva izme?u primljenih brojeva koji su cjelobrojno djeljivi s 3 i 5
        {
            int Zbroj = 0;
            int ManjiBroj = 0;
            int VeciBroj = 0;

            if (Broj1 > Broj2)
            {
                VeciBroj = Broj1;
                ManjiBroj = Broj2;
            }
            else if (Broj1 < Broj2)
            {
                VeciBroj = Broj2;
                ManjiBroj = Broj1;
            }
            else
            {
                ManjiBroj = Broj1;
                VeciBroj = Broj2;
            }

            for (int i = ManjiBroj; i <= VeciBroj; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Zbroj += i;
                }
            }
            return Zbroj;
        }

        [HttpGet]
        [Route("Zad10")]
        public string Matrica2d(int a, int b)
        {
            int[] matricaA = new int[10];
            int[] matricaB = new int[10];

            for (int i = 0; i < 10; i++)
            {
                matricaA[i] = (i + 1) * a;
            }

            for (int i = 0; i < 10; i++)
            {
                matricaB[i] = (i + 1) * b;
            }

            string[,] tablica = new string[a, b];

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    tablica[i, j] = ((i + 1) * (j + 1)).ToString();
                }
            }

            StringBuilder matricaNiz = new StringBuilder();

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    matricaNiz.Append(tablica[i, j] + "\t");
                }
                matricaNiz.AppendLine();
            }
            return "Tablica množenja za dva broja" + "\n" + string.Join("\t", matricaA)
                + "\n" + string.Join("\t", matricaB) + "\n" + "Tablica množenja do dva broja" + "\n" + matricaNiz.ToString();
        }



        [HttpGet]
        [Route("Zad11")]
        public int[] Zad11(int Broj)//11. Ruta prima jedan parametar koji je cijeli broj i vra?a niz cijelih brojeva koji su složeni od primljenog broja do broja 1
        {
            int Brojac = 0;
            int[] Niz = new int[Broj];

            for (int i = Broj; i >= 1; i--)
            {
                Niz[Brojac++] = i;
            }
            return Niz;
        }
        [HttpGet]
        [Route("Zad12")]
        public bool Zad12(int Broj)//12. Ruta prima cijeli broj i vra?a logi?ku istinu ako je primljeni broj prosti (prim - prime) broj, odnosno logi?ku laž ako nije
        {
            for (int i = 2; i <= Broj / 2; i++)
            {
                if (Broj % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        [HttpGet]
        [Route("Zad13")]
        public int Zad13(int Broj)//13. Ruta prima dva parametra koji su cijeli brojevi te vra?a dvodimenzionalni niz (matricu) cijelih brojeva koji su složeni prema slici zadatka: Cikli?na matrica
        {

            return 0;

        }
    }
}