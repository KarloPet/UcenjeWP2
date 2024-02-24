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
        public int[] Zad5(int Broj1, int Broj2) //5. Ruta prima dva parametra koji su cijeli brojevi
                                                       //i vra?a niz s svim parnim brojevima izme?u primljenih brojeva
        {
            int Index = 0;
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

            int[] Niz = new int[(VeciBroj - ManjiBroj + 1) / 2];

            for (int i = ManjiBroj; i <= VeciBroj; i++)
            {

                if (i % 2 == 0)
                {
                    Niz[Index++] = i++;
                }

            }
            return Niz;
        }

        [HttpGet]
        [Route("Zad6")]
        public int[] Zad6(int Broj1, int Broj2)//6. Ruta prima dva parametra koji su cijeli
                                                      //brojevi i vra?a niz s svim neparnim brojevima izme?u primljenih brojeva
        {
            int Index = 0;
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

            int[] Niz = new int[(VeciBroj - ManjiBroj + 1) / 2];

            for (int i = ManjiBroj; i <= VeciBroj; i++)
            {

                if (i % 2 != 0)
                {
                    Niz[Index++] = i++;
                }

            }
            return Niz;
        }

        [HttpGet]
        [Route("Zad7")]
        public int Zad7(int Broj1, int Broj2) //7. Ruta prima dva parametra koji su cijeli
                                              //brojevi i vra?a zbroj svih brojeva izme?u primljenih brojeva
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
        public int Zad8(int Broj1, int Broj2)//8. Ruta prima dva parametra koji su cijeli
                                             //brojevi i vra?a zbroj svih brojeva izme?u primljenih
                                             //brojeva koji su cjelobrojno djeljivi s 3
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
        public int Zad9(int Broj1, int Broj2)//9. Ruta prima dva parametra koji su cijeli brojevi
                                             //i vra?a zbroj svih brojeva izme?u primljenih brojeva
                                             //koji su cjelobrojno djeljivi s 3 i 5
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
        public string Zad10(int Broj1, int Broj2)//10. Ruta prima dva parametra koji su cijeli brojevi
                                                 //i vraća dvodimenzionalni niz (matricu) koja sadrži tablicu
                                                 //množenja za dva primljena broja
        {
            int[] Stupac1 = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Stupac1[i] = (i + 1) * Broj1; 
            }

            int[] Stupac2 = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Stupac2[i] = (i + 1) * Broj2;
            }

            string[,] tablica = new string[Broj1, Broj2];
            for (int i = 0; i < Broj1; i++)
            {
                for (int j = 0; j < Broj2; j++)
                {
                    tablica[i, j] = ((i + 1) * (j + 1)).ToString();
                }
            }

            string TablicaNiz = "";

            for (int i = 0; i < Broj1; i++)
            {
                for (int j = 0; j < Broj2; j++)
                {
                    TablicaNiz += tablica[i, j] + "\t";
                }
                TablicaNiz += "\n";
            }
            return TablicaNiz;
        }



        [HttpGet]
        [Route("Zad11")]
        public int[] Zad11(int Broj)//11. Ruta prima jedan parametar koji je cijeli broj i
                                    //vra?a niz cijelih brojeva koji su složeni od primljenog broja do broja 1
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
        public bool Zad12(int Broj)//12. Ruta prima cijeli broj i
                                   //vra?a logi?ku istinu ako je primljeni broj
                                   //prosti (prim - prime) broj, odnosno logi?ku laž ako nije
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
        public string CiklicnaMatrica(int redovi, int stupac)//13. Ruta prima dva parametra koji su cijeli brojevi te vraća dvodimenzionalni
                                                             //niz (matricu) cijelih brojeva koji su složeni
                                                             //prema slici zadatka: Ciklična matrica
        {
            int[,] matrica = new int[redovi, stupac];
            int brojac = 1;
            int redPocetak = 0;
            int redKraj = redovi - 1;
            int stuPocetak = 0;
            int stuKraj = stupac - 1;

            while (stuPocetak <= redKraj && stuPocetak <= stuKraj)
            {


                // Popuni gornji redak matrice slijeva nadesno.
                for (int j = stuPocetak; j <= stuKraj; j++)
                    matrica[redPocetak, j] = brojac++;

                redPocetak++;

                // Popuni desni stupac matrice odozgo prema dolje.
                for (int i = redPocetak; i <= redKraj; i++)
                    matrica[i, stuKraj] = brojac++;

                stuKraj--;

                // Provjeri i popuni donji redak matrice zdesna ulijevo.
                if (redPocetak <= redKraj)
                {
                    for (int j = stuKraj; j >= stuPocetak; j--)
                        matrica[redKraj, j] = brojac++;

                    redKraj--;
                }

                // Provjeri i popuni lijevi stupac matrice odozdo prema gore.
                if (stuPocetak <= stuKraj)
                {
                    for (int i = redKraj; i >= redPocetak; i--)
                        matrica[i, stuPocetak] = brojac++;

                    stuPocetak++;
                }
            }
            string res = "";

            for (int i = 0; i < redovi; i++)
            {
                for (int j = 0; j < stupac; j++)
                {
                    res += matrica[i, j] + "\t";
                }
                res += "\n";
            }

            return res;
        }


        [HttpGet]
        [Route("Zad14")]
        public string CiklicnaMatrica2(int redovi, int stupac)
        {
            int[,] matrica = new int[redovi, stupac];
            int brojac = redovi * stupac;
            int redPocetak = 0;
            int redKraj = redovi - 1;
            int stuPocetak = 0;
            int stuKraj = stupac - 1;

            while (brojac >= 1)
            {

                // Popunjava desni rub matrice odozgo prema dolje.
                for (int i = stuKraj; i >= stuPocetak; i--)
                    matrica[redKraj, i] = brojac--;

                // Popunjava donji rub matrice zdesna ulijevo.
                for (int i = redKraj - 1; i >= redPocetak; i--)
                    matrica[i, stuPocetak] = brojac--;

                // Popunjava gornji rub matrice slijeva nadesno.
                for (int i = stuPocetak + 1; i <= stuKraj; i++)
                    matrica[redPocetak, i] = brojac--;

                // Popunjava lijevi rub matrice odozdo prema gore.
                for (int i = redPocetak + 1; i < redKraj; i++)
                    matrica[i, stuKraj] = brojac--;


                redPocetak++;
                redKraj--;
                stuPocetak++;
                stuKraj--;
            }

            string res = "";

            for (int i = 0; i < redovi; i++)
            {
                for (int j = 0; j < stupac; j++)
                {
                    res += matrica[i, j] + "\t";
                }
                res += "\n";
            }

            return res;
        }

        [HttpGet]
        [Route("Zad15")]
        public string CiklicnaMatrica3(int redovi, int stupac)
        {
            int[,] matrica = new int[redovi, stupac];
            int brojac = 1;
            int redPocetak = 0;
            int redKraj = redovi - 1;
            int stuPocetak = 0;
            int stuKraj = stupac - 1;

            while (redPocetak <= redKraj && stuPocetak <= stuKraj)
            {

                // Popuni lijevi stupac matrice odozgo prema dolje.
                for (int i = redPocetak; i <= redKraj; i++)
                    matrica[i, stuPocetak] = brojac++;

                stuPocetak++;

                // Popuni donji redak matrice slijeva nadesno.
                for (int j = stuPocetak; j <= stuKraj; j++)
                    matrica[redKraj, j] = brojac++;

                redKraj--;

                // Provjeri i popuni desni stupac matrice odozdo prema gore.
                if (stuPocetak <= stuKraj)
                {
                    for (int i = redKraj; i >= redPocetak; i--)
                        matrica[i, stuKraj] = brojac++;

                    stuKraj--;
                }

                // Provjeri i popuni gornji redak matrice slijeva nadesno.
                if (redPocetak <= redKraj)
                {
                    for (int j = stuKraj; j >= stuPocetak; j--)
                        matrica[redPocetak, j] = brojac++;

                    redPocetak++;
                }
            }

            // Generiranje stringa iz matrice
            string res = "";

            for (int i = 0; i < redovi; i++)
            {
                for (int j = 0; j < stupac; j++)
                {
                    res += matrica[i, j] + "\t";
                }
                res += "\n";
            }

            return res;
        }




    }
}