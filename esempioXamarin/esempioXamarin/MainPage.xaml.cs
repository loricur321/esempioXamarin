using esempioXamarin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace esempioXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //programma orari autobus
        }

        private void btnCalcola_Clicked(object sender, EventArgs e)
        {
            Orario orarioPartenzaPennabilli160 = new Orario(6, 13); //creo i due orari
            Orario orarioArrivoCentroStudi160 = new Orario(7, 42);

            int delta = orarioPartenzaPennabilli160.DeltaOrario(orarioArrivoCentroStudi160); //tramite la classe calcolo la differenza tra i due orari

            lblRisultato.Text = $"{delta.ToString()} minuti"; //e tramite la label stampo una stringa
        }
    }
}
