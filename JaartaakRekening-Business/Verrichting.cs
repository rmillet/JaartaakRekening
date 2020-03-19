using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaartaakRekening_Business
{
    public class Verrichting
    {
        //de private fields

        private double _bedrag;
        private DateTime _datum;
        private string _omschrijving;



        //methode (override)

        public override string ToString()
        {
            return _omschrijving + " (" + _bedrag.ToString("C") + " )  op " + _datum.ToString("d");
        }
    }
}
