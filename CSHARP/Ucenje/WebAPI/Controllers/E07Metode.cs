using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E07")]
    public class E07Metode:ControllerBase
    {
        [HttpGet]
        [Route("zad1")]
        public int Zad1(int PrviBroj, int DrugiBroj)
        {
            
            return Zbroji(PrviBroj, DrugiBroj);            
        }
        private int Zbroji (int PrviBroj, int DrugiBroj)
        {
            return PrviBroj + DrugiBroj;
        }

        [HttpGet]
        [Route("zad2")]
        public int Zad2(int PrviBroj, int DrugiBroj, int TreciBroj, int CetvrtiBroj)
        {
            //int Zbroj2 = TreciBroj + CetvrtiBroj;
            //int Zbroji3 = Zbroji(PrviBroj, DrugiBroj) - Zbroj2;
            return Zbroji(PrviBroj, DrugiBroj)-Zbroji(TreciBroj, CetvrtiBroj);
        }
        private int Brojac (string Grad, string Slovo)
        {
            int Ukupno = 0;
            foreach (char c in Grad)
            {
                if (c == Slovo[0])
                {
                    Ukupno++;
                }
            }


            return Ukupno;
        }


        [HttpGet]
        [Route("zad3")]
        public int Zad3(string Grad, string Slovo)
        {
            return Brojac(Grad, Slovo);
        }

    }
}
