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

        public int Binnentafels17 { get; set; } = 15;
        public int Buitentafels17 { get; set; } = 30;
        public int Binnentafels18 { get; set; } = 15;
        public int Buitentafels18 { get; set; } = 30;
        public int Binnentafels19 { get; set; } = 15;
        public int Buitentafels19 { get; set; } = 30;
        public int Binnentafels20 { get; set; } = 15;
        public int Buitentafels20 { get; set; } = 30;
        public int Binnentafels21 { get; set; } = 15;
        public int Buitentafels21 { get; set; } = 30;

        public List<ReserverenForms> reserveringen = new List<ReserverenForms>();

        public int AantalTafelsVrij { get; set; } = 0;

        public int AantalVrijeTafel { get; set; } = 0;

        //2 integers hierboven zijn alvast gedeclareerd hebben nog niet een waarde.

        public int tafelsBezetBinnen17 = 0;
        public int tafelsBezetBuiten17 = 0;
        public int tafelsBezetBinnen18 = 0;
        public int tafelsBezetBuiten18 = 0;
        public int tafelsBezetBinnen19 = 0;
        public int tafelsBezetBuiten19 = 0;
        public int tafelsBezetBinnen20 = 0;
        public int tafelsBezetBuiten20 = 0;
        public int tafelsBezetBinnen21 = 0;
        public int tafelsBezetBuiten21 = 0;

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

        //Aantalvrijetafels geeft terug hoeveel tafels er niet bezet zijn door van het totale aantal tafels de bezette af te halen.
        public int AantalVrijeTafels(int tijdKeuze, bool binnenBuiten)
        {
            if (tijdKeuze == 17)
            {
                if (binnenBuiten)
                {
                    return Binnentafels17 - tafelsBezetBinnen17;
                }
                else
                {
                    return Buitentafels17 - tafelsBezetBuiten17;
                }
            }
            else if (tijdKeuze == 18)
            {
                if (binnenBuiten)
                {
                    return Binnentafels18 - tafelsBezetBinnen18;
                }
                else
                {
                    return Buitentafels18 - tafelsBezetBuiten18;
                }
            }
            else if (tijdKeuze == 19)
            {
                if (binnenBuiten)
                {
                    return Binnentafels19 - tafelsBezetBinnen19;
                }
                else
                {
                    return Buitentafels19 - tafelsBezetBuiten19;
                }
            }
            else if (tijdKeuze == 20)
            {
                if (binnenBuiten)
                {
                    return Binnentafels20 - tafelsBezetBinnen20;
                }
                else
                {
                    return Buitentafels20 - tafelsBezetBuiten20;
                }
            }
            else
            {
                if (binnenBuiten)
                {
                    return Binnentafels21 - tafelsBezetBinnen21;
                }
                else
                {
                    return Buitentafels21 - tafelsBezetBuiten21;
                }
            }
        }

        //Geeft terug hoeveel tafels er vrij zijn op het gevraagde moment/plek en dus of je kunt reserveren.

        public bool KanIkReserveren(int tijdKeuze, bool binnenBuiten, double aantalPers)
        {
            double aantalTafelsNodig = Math.Ceiling(aantalPers / 6);
            if (tijdKeuze == 17)
            {
                if (binnenBuiten == true)
                {
                    if (AantalVrijeTafels(tijdKeuze, binnenBuiten) >= aantalTafelsNodig)//als het kan
                    {
                        tafelsBezetBinnen17 += Convert.ToInt32(aantalTafelsNodig);
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
                        tafelsBezetBuiten17 += Convert.ToInt32(aantalTafelsNodig);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            } else if (tijdKeuze == 18)
            { 
                if (binnenBuiten == true)
                {
                    if (AantalVrijeTafels(tijdKeuze, binnenBuiten) >= aantalTafelsNodig)//als het kan
                    {
                        tafelsBezetBinnen18 += Convert.ToInt32(aantalTafelsNodig);
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
                        tafelsBezetBuiten18 += Convert.ToInt32(aantalTafelsNodig);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            } else if (tijdKeuze == 19)
            {
                if (binnenBuiten == true)
                {
                    if (AantalVrijeTafels(tijdKeuze, binnenBuiten) >= aantalTafelsNodig)//als het kan
                    {
                        tafelsBezetBinnen19 += Convert.ToInt32(aantalTafelsNodig);
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
                        tafelsBezetBuiten19 += Convert.ToInt32(aantalTafelsNodig);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            } else if (tijdKeuze == 20)
            {
                if (binnenBuiten == true)
                {
                    if (AantalVrijeTafels(tijdKeuze, binnenBuiten) >= aantalTafelsNodig)//als het kan
                    {
                        tafelsBezetBinnen20 += Convert.ToInt32(aantalTafelsNodig);
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
                        tafelsBezetBuiten20 += Convert.ToInt32(aantalTafelsNodig);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            } else
            {
                if (binnenBuiten == true)
                {
                    if (AantalVrijeTafels(tijdKeuze, binnenBuiten) >= aantalTafelsNodig)//als het kan
                    {
                        tafelsBezetBinnen21 += Convert.ToInt32(aantalTafelsNodig);
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
                        tafelsBezetBuiten21 += Convert.ToInt32(aantalTafelsNodig);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        //Deze functie geeft door of je de 10 persoon bent die reserveerd, dit is mijn zelfbedachte functie.
    }
}

