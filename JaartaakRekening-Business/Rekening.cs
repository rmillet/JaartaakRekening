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

        //Properties
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

            return 5; //moet nog aangepast
        }

        public override string ToString()
        {
            return "...";
        }
    }
}
