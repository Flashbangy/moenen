using System;
using System.Collections.Generic;
using System.Text;

namespace Reserveren_restaurant_Moenen
{
    class Restaurant
    {
        public bool Stoppen = false;

        public int Binnentafels { get; set; } = 15;

        public int Buitentafels { get; set; } = 30;

        public List<Reserveren> reserveringen = new List<Reserveren>();

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
            foreach (Reserveren reserveringen in reserveringen)
            {
                if(reserveringen.Tijd == tijdKeuze && reserveringen.Binnen == binnenBuiten)
                {
                    tafelsBezet += 1;
                }
            }
            return tafelsBezet;
        }
        //Een foreach doen om te checken hoeveel tafels er bezet zijn.

        public int aantalVrijeTafels(int tijdKeuze, bool binnenBuiten)
        {
            if (binnenBuiten)
            {
                return Binnentafels - tafelsBezetBinnen;
            } else
            {
                return Buitentafels - tafelsBezetBuiten;
            }
        } 

        //Geeft terug hoeveel tafels er vrij zijn en dus of je kunt reserveren.

        public bool kanIkReserveren(int tijdKeuze, bool binnenBuiten, double aantalPers)
        {
            double aantalTafelsNodig = Math.Ceiling(aantalPers / 6);
            if (binnenBuiten == true)
            {
                if (aantalVrijeTafels(tijdKeuze, binnenBuiten) >= aantalTafelsNodig)//als het kan
                {
                    tafelsBezetBinnen += Convert.ToInt32(aantalTafelsNodig);
                    return true;
                    
                } else //als het niet kan
                {
                    return false;
                }
            } else
            {
                if (aantalVrijeTafels(tijdKeuze, binnenBuiten) >= aantalTafelsNodig)
                {
                    tafelsBezetBuiten += Convert.ToInt32(aantalTafelsNodig); 
                    return true;
                } else
                {
                    return false;
                }
            }
        }

        public bool tiendeReservering()
        {
            int aantalReserveringen = 0;
            foreach (Reserveren reserveringen in reserveringen)
            {
                aantalReserveringen += 1;
            }

            if(aantalReserveringen == 10)
            {
                return true;
            } else
            {
                return false;
            }
        }
        //Deze functie geeft door of je de 10 persoon bent die reserveerd, dit is mijn zelfbedachte functie.
    }
}
