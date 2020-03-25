using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaartaakRekening_Business
{
    public class Rekening
    {
        List<Verrichting> _verrichting;

        //Constructor
        public Rekening()
        {
            _verrichting = new List<Verrichting>();
        }

        //Methodes

        public void voegVerrichtingToe(Verrichting verrichting)
        {
            _verrichting.Add(verrichting);
        }

        public double vraagRekeningstandOp()
        {
            double saldo=0;
            
            // vraag voor elke verrichting het bedrag op en telop/trek af bij je saldo
            
            return saldo; 
        }

        public List<string>  vraagVerrichtingenOp()
        {
            List<string> temp = new List<string>();

            // foreach om alle verrichtingen op te vragen --> zie tostring bij verrichting
            // en voeg ze toe aan temp
            //zie cursus

            return temp;
        }


    }
}
