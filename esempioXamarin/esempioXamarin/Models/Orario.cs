using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace esempioXamarin.Models
{
    class Orario
    {
        public int ore;
        public int minuti;


        public Orario() //costruttore di default
        {
            ore = 0;
            minuti = 0;
        }


        public Orario(int o, int m)//costruttore
        {
            ore = o;
            minuti = m;
        }

        public int DeltaOrario(Orario o)//metodo che calcola la differnza in minuti tra due orari
        {
            int m1 = this.ToMinutes(); 
            int m2 = o.ToMinutes();

            return Math.Abs(m1-m2);//ritorno un valore assoluto per evitare che il risultato venga negativo
        }

        private int ToMinutes()//tramite questo metodo converto un'orario in minuti
        {
            return ore * 60 + minuti;
        }

        

        
        public string Stampa() //metodo che restituisce una stringa che verrà usata per stampare l'orario
        {
            return $"{this.ore} : {this.minuti}";
        }
    }

}
