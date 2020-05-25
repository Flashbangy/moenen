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

        private void Reserveer_click(object sender, EventArgs e)
        {
            int aantalMensen = Convert.ToInt32(AantalMensen.Text);
            int tijd = int.Parse(tijdKeuze.Text);
            Box1.Items.Add(tijdKeuze);
        }

        private void Naam_Click(object sender, EventArgs e)
        {

        }
    }
}
