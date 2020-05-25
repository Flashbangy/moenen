using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_moenen_forms
{
    class ReserverenForms
    {
            public int Tijd { get; set; }

            public bool Binnen { get; set; }

            public double AantalPers { get; set; }

            public string GroepNaam { get; set; }

            public int TelefoonNummer { get; set; }

            const bool BINNEN = true;
            const bool BUITEN = false;

            public ReserverenForms(int tijd, bool binnen, double aantalPers, string groepNaam, int telefoonNummer)
            {
                this.Tijd = tijd;
                this.Binnen = binnen;
                this.AantalPers = aantalPers;
                this.GroepNaam = groepNaam;
                this.TelefoonNummer = telefoonNummer;
                //template voor de list om te reserveren.
            }
        }
    }
