using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_moenen_forms
{
    class Restaurant
    {
        public bool Stoppen = false;

        public int Binnentafels { get; set; } = 15;

        public int Buitentafels { get; set; } = 30;

        public List<ReserverenForms> reserveringen = new List<ReserverenForms>();

        public int aantalTafelsVrij { get; set; } = 0;

        public int aantalVrijeTafel { get; set; } = 0;

        //2 integers hierboven zijn alvast gedeclareerd hebben nog niet een waarde.

        public int tafelsBezetBinnen = 0;

        public int tafelsBezetBuiten = 0;

        public Restaurant()
        {

        }

        public int AantalTafelsBezet(bool binnenBuiten, int tijdKeuze)
        {
            int tafelsBezet = 0;
            foreach (ReserverenForms reserveringen in reserveringen)
            {
                if (reserveringen.Tijd == tijdKeuze && reserveringen.Binnen == binnenBuiten)
                {
                    tafelsBezet += 1;
                }
            }
            return tafelsBezet;
        }
        //Een foreach doen om te checken hoeveel tafels er bezet zijn.

        public int AantalVrijeTafels(int tijdKeuze, bool binnenBuiten)
        {
            if (binnenBuiten)
            {
                return Binnentafels - tafelsBezetBinnen;
            }
            else
            {
                return Buitentafels - tafelsBezetBuiten;
            }
        }

        //Geeft terug hoeveel tafels er vrij zijn en dus of je kunt reserveren.

        public bool KanIkReserveren(int tijdKeuze, bool binnenBuiten, double aantalPers)
        {
            double aantalTafelsNodig = Math.Ceiling(aantalPers / 6);
            if (binnenBuiten == true)
            {
                if (AantalVrijeTafels(tijdKeuze, binnenBuiten) >= aantalTafelsNodig)//als het kan
                {
                    tafelsBezetBinnen += Convert.ToInt32(aantalTafelsNodig);
                    return true;

                }
                else //als het niet kan
                {
                    return false;
                }
            }
            else
            {
                if (AantalVrijeTafels(tijdKeuze, binnenBuiten) >= aantalTafelsNodig)
                {
                    tafelsBezetBuiten += Convert.ToInt32(aantalTafelsNodig);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool TiendeReservering()
        {
            int aantalReserveringen = 0;
            return (reserveringen.Count % 10 == 0);

            foreach (ReserverenForms reservering in reserveringen)
            {
                aantalReserveringen += 1;
            }

            if (reserveringen.Count == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Deze functie geeft door of je de 10 persoon bent die reserveerd, dit is mijn zelfbedachte functie.
    }
}
