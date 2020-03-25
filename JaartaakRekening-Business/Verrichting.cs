using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaartaakRekening_Business
{
    public class Verrichting
    {
        
        private string _omschrijving;
        private double _bedrag;
        private DateTime _datum;

        //constructor
        public Verrichting(string omschrijving, double bedrag, DateTime datum)
        {
            _omschrijving = omschrijving;
            _bedrag = bedrag;
            _datum = datum;
        }


        // alle eigenschappen  nog maken R+W


        //we hebbben nood aan en eigen ToString om de waarden van de lijsten te kunnen presenteren
        public override string ToString()
        {
            // zie oppgave screenshot p.6 omschrijving (bedrag) + datum
            return "...";
        }
    }
}
