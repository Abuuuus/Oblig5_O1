using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Oblig5_O1
{
    internal class Banken : IBankOperasjon
    {
        private double saldo;

        public void LoggeUt()
        {
            Application.Exit();
        }

        public bool Autentifisere(String bruker)
        {
            bool svar = false;
            if (bruker == "Pablo Escobar")
            {
                svar = true;
            }
            else
            {
                svar = false;
            }
            return svar;
        }

        public void SettInPenger(double beløp)
        {
            if (beløp < 0)
            {
                MessageBox.Show("Beløpet du har oppgit er ugyldig, og vi kan ikkje gjennomføre dette inskuddet");
            }
            else
            {
                this.saldo = this.saldo + beløp;
                MessageBox.Show("Innskudded er gyldig, " + Convert.ToString(beløp) + " NOK er satt inn på konto");
            }
        }

        public double SaldoUpdate
        {
            get { return saldo; } 
            
            set
            {
                if (saldo < 0)
                {
                    saldo = 0;
                }
                else
                {
                    saldo = value;
                }
            }
        }


        public bool TaUtPenger(double beløp)
        {
            bool svar = false;
            if(beløp < saldo)
            {
                svar = true;
            }
            else if (beløp < 0)
            {
                svar = false;
            }
            else { svar = false; }
            return svar;
        }

        public double Saldo()
        {
            double svar = this.saldo;
            return svar;
            
        }
    }
}
