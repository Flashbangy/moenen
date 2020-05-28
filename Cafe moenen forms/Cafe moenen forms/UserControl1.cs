using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_moenen_forms
{
    public partial class UserControl1: UserControl
    {
        Restaurant restaurant = new Restaurant();
        ReserverenForms reserveren1 = new ReserverenForms(17, true, 6, "proce", 0612345678);
        //restaurant.reserveringen.Add(new Reserveren(17, true, 10, "test", 0612345678));
        //restaurant.reserveringen.Add(reserveren1);
             
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            textBox1.BackColor = Color.FromName("LightBlue");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Naam_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void Reserveer_Click_1(object sender, EventArgs e)
        {
            decimal personen = AantalMensen.Value;
            double persoon = Convert.ToDouble(personen);
            string naam = NameInput.Text;
            string nummer = TelefoonNummer.Text;
            Int32.TryParse(nummer, out int telefoonNummer);
            string tijd = tijdKeuze.Text;
            Int32.TryParse(tijd, out int tijdkeuze);
            bool binnenBuiten;
            if (radioButton2.Checked)
            {
                binnenBuiten = true;
            }
            else
            {
                binnenBuiten = false;
            }
            if (restaurant.kanIkReserveren(tijdkeuze, binnenBuiten, persoon))
            {
                restaurant.reserveringen.Add(new ReserverenForms(tijdkeuze, binnenBuiten, persoon, naam, telefoonNummer));
                label6.Text = "U heeft gereserveerd";
            } else
            {
                label6.Text = "U kunt helaas niet reserveren";
            }
        }

        private void AantalMensen_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tijdKeuze_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TelefoonNummer_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Box1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
