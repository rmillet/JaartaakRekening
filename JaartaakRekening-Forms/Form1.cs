using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using JaartaakRekening_Business;

namespace JaartaakRekening_Forms
{
    public partial class Form1 : Form
    {
        private Rekening _rekening;
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string omschrijving = Interaction.InputBox("geef een omschrijving in: ");
            double bedrag = Convert.ToDouble(Interaction.InputBox("Geef het bedrag in: "));
            DateTime datum = Convert.ToDateTime(Interaction.InputBox("Geef de datum in (dd/mm/jjjj): "));

            

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lstInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
