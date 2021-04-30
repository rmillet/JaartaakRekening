using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaartaakRekening_Business
{
    public class Rekening
    {
        private List<Verrichting> _verrichting;

        //Constructor
        public Rekening()
        {
            _verrichting = new List<Verrichting>();
        }

        //Properties.
        public List<Verrichting> Verrichting
        {
            get { return _verrichting; } 
        }

        //Methodes
        public void voegVerrichtingToe(Verrichting verrichting)
        {
            _verrichting.Add(verrichting);
        }

        public double vraagRekeningstandOp()
        {
            // een berekening voor het bepalen van het saldo
            double saldo = 0;

            //uit de lijst van verrichtingen vraag je per verrichting telkens het bedrag op (for each)
            // cursus zie pag. 

            foreach (Verrichting temp in _verrichting)
            {
                saldo = saldo + temp.Bedrag;
            }               
            return saldo;
        }

        /// <summary>
        /// Vraagt een lijst van de verrichtingen op
        /// </summary>
        /// <returns>lijst van verrichtingen</returns>
        public List<string> vraagVerrichtingenOp()
        {
            List<string> temp = new List<string>();
            foreach (Verrichting opdr in _verrichting)
            {
                temp.Add(opdr.ToString());
            }
            return temp;
        }





    }
}
