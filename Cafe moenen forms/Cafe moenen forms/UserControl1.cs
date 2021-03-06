﻿using System;
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
            Box1.DataSource = restaurant.reserveringen;
            //restaurant.reserveringen.Add(new ReserverenForms(17, true, 10, "test", 0612345678));
            TijdKeuze.SelectedIndex = 0;
            ComboBox1.SelectedIndex = 0;
            ComboBox2.SelectedIndex = 0;
            restaurant.KanIkReserveren(17, true, 5);
            restaurant.reserveringen.Add(new ReserverenForms(17, true, 5, "test", 121256789));

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {
            //label1.Text = textBox1.Text;
            //textBox1.BackColor = Color.FromName("LightBlue");
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Naam_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {
            
        }

        //dit is de functie die reserveerd
        private void Reserveer_Click_1(object sender, EventArgs e)
        {
            //alle informatie word opgehaald en er word gechecked of je kunt reserveren.
            decimal personen = AantalMensen.Value;
            int persoonchecked = Convert.ToInt32(personen);
            double persoon = Convert.ToDouble(personen);
            string naam = NameInput.Text;
            string nummer = TelefoonNummer.Text;
            Int32.TryParse(nummer, out int telefoonNummer);
            string tijd = TijdKeuze.Text;
            Int32.TryParse(tijd, out int tijdkeuze);
            bool binnenBuiten;
            //eerst checken we of alles is ingevuld.
            if (NameInput.Text == "")
            {
                Label6.Text = "vul uw naam in";
            }
            else
            {
                //if (telefoonNummer.ToString().Length < 9)
                //{
                    //Label6.Text = "telefoonnummer is niet lang genoeg";
                //} else if(telefoonNummer.ToString().Length > 9)
                //{
                    //als alles is ingevuld reserveren we.


                    if (RadioButton2.Checked)
                    {
                        binnenBuiten = true;
                    }
                    else
                    {
                        binnenBuiten = false;
                    }
                    if (restaurant.KanIkReserveren(tijdkeuze, binnenBuiten, persoonchecked))
                    {
                        restaurant.reserveringen.Add(new ReserverenForms(tijdkeuze, binnenBuiten, persoonchecked, naam, telefoonNummer));
                        Label6.Text = "U heeft gereserveerd";
                    }
                    else
                    {
                        Label6.Text = "U kunt niet reserveren, te weinig tafels";
                    }
                //}
            }
        
            Label2.Text = "0";
            Label7.Text = "0";
            string testTijd = ComboBox1.Text;
            Int32.TryParse(testTijd, out int checkTijd);

            bool binnenBuitenCheck = true;
            int binnenTafels = restaurant.AantalVrijeTafels(checkTijd, binnenBuitenCheck);
            Label2.Text = "binnen: " + binnenTafels.ToString();

            binnenBuitenCheck = false;
            int buitenTafels = restaurant.AantalVrijeTafels(checkTijd, binnenBuitenCheck);
            Label7.Text = "buiten: " + buitenTafels.ToString();


            //DataSource = MyList;
        }

        private void AantalMensen_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TijdKeuze_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void TelefoonNummer_TextChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Box1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //foreach (Reserveren reservering in reserveringen)
            //{
            //aantalReserveringen += 1;
            //}
        }


        //hieronder staan de functies die checken hoeveel tafels er beschikbaar zijn
        private void Button1_Click(object sender, EventArgs e)
        {
            //Label2.Text = "0";
            //Label7.Text = "0";
            //string testTijd = ComboBox1.Text;
            //Int32.TryParse(testTijd, out int checkTijd);

            //bool binnenBuitenCheck = true;
            //int binnenTafels = restaurant.AantalVrijeTafels(checkTijd, binnenBuitenCheck);
            //Label2.Text = "binnen: " + binnenTafels.ToString();

            //binnenBuitenCheck = false;
            //int buitenTafels = restaurant.AantalVrijeTafels(checkTijd, binnenBuitenCheck);
            //Label7.Text = "buiten: " + buitenTafels.ToString();

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label2.Text = "0";
            Label7.Text = "0";
            string testTijd = ComboBox1.Text;
            Int32.TryParse(testTijd, out int checkTijd);

            bool binnenBuitenCheck = true;
            int binnenTafels = restaurant.AantalVrijeTafels(checkTijd, binnenBuitenCheck);
            Label2.Text = "binnen: " + binnenTafels.ToString();

            binnenBuitenCheck = false;
            int buitenTafels = restaurant.AantalVrijeTafels(checkTijd, binnenBuitenCheck);
            Label7.Text = "buiten: " + buitenTafels.ToString();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //this.listView1.DataSource = null;
            this.ListView1.Items.Clear();

            string checkTijd = ComboBox2.Text;
            Int32.TryParse(checkTijd, out int ckeckedTijd);
            if (ckeckedTijd == 17)
            {
                int geldiger = 17;
                bool plaatscheck = true;
                List<ReserverenForms> reserveringen = restaurant.reserveringen.ToList();
                foreach (ReserverenForms p in reserveringen)
                {
                    ListViewItem tijd = new ListViewItem(p.Tijd.ToString());
                    ListViewItem binnen = new ListViewItem(p.Binnen.ToString());
                    ListViewItem personen = new ListViewItem(p.AantalPers.ToString());
                    ListViewItem naam = new ListViewItem(p.GroepNaam);
                    ListViewItem telefoonnummer = new ListViewItem(p.TelefoonNummer.ToString());
                    ListViewItem geldig = new ListViewItem(geldiger.ToString());
                    ListViewItem plaats = new ListViewItem(plaatscheck.ToString());

                    if (tijd.ToString() == geldig.ToString())
                    {
                        if (binnen.ToString() == plaats.ToString())
                        {
                            ListView1.Items.Add(tijd);
                            ListView1.Items.Add("binnen");
                            ListView1.Items.Add(personen);
                            ListView1.Items.Add(naam);
                            ListView1.Items.Add(telefoonnummer);
                        } else
                        {
                            ListView1.Items.Add(tijd);
                            ListView1.Items.Add("buiten");
                            ListView1.Items.Add(personen);
                            ListView1.Items.Add(naam);
                            ListView1.Items.Add(telefoonnummer);
                        }

                        //item.SubItems.Add(p.Binnen.ToString());
                        //item.SubItems.Add(p.AantalPers.ToString());
                        //item.SubItems.Add(p.GroepNaam);
                        //item.SubItems.Add(p.TelefoonNummer.ToString());
                   
                    }
                }






                //Box1.Items.Add(restaurant.reserveringen);
                //Box1.DataSource = restaurant.reserveringen;
                //restaurant.reserveringen.Add(new ReserverenForms() { Tijd = Int32.TryParse() });
                //Box1.Text = restaurant.reserveringen;
            //});
                //Box1.DisplayMember = "tijdkeuze";

                //string.Join(", ", restaurant.reserveringen);
                //listView1.Items.Add(restaurant.reserveringen.ToString());
            } else if (ckeckedTijd == 18)
            {
                int geldiger = 18;
                bool plaatscheck = true;
                List<ReserverenForms> reserveringen = restaurant.reserveringen.ToList();
                foreach (ReserverenForms p in reserveringen)
                {
                    ListViewItem tijd = new ListViewItem(p.Tijd.ToString());
                    ListViewItem binnen = new ListViewItem(p.Binnen.ToString());
                    ListViewItem personen = new ListViewItem(p.AantalPers.ToString());
                    ListViewItem naam = new ListViewItem(p.GroepNaam);
                    ListViewItem telefoonnummer = new ListViewItem(p.TelefoonNummer.ToString());
                    ListViewItem geldig = new ListViewItem(geldiger.ToString());
                    ListViewItem plaats = new ListViewItem(plaatscheck.ToString());

                    if (tijd.ToString() == geldig.ToString())
                    {
                        if (binnen.ToString() == plaats.ToString())
                        {
                            ListView1.Items.Add(tijd);
                            ListView1.Items.Add("binnen");
                            ListView1.Items.Add(personen);
                            ListView1.Items.Add(naam);
                            ListView1.Items.Add(telefoonnummer);
                        }
                        else
                        {
                            ListView1.Items.Add(tijd);
                            ListView1.Items.Add("buiten");
                            ListView1.Items.Add(personen);
                            ListView1.Items.Add(naam);
                            ListView1.Items.Add(telefoonnummer);
                        }

                        //item.SubItems.Add(p.Binnen.ToString());
                        //item.SubItems.Add(p.AantalPers.ToString());
                        //item.SubItems.Add(p.GroepNaam);
                        //item.SubItems.Add(p.TelefoonNummer.ToString());

                    }
                }

            } else if (ckeckedTijd == 19)
            {
                int geldiger = 19;
                bool plaatscheck = true;
                List<ReserverenForms> reserveringen = restaurant.reserveringen.ToList();
                foreach (ReserverenForms p in reserveringen)
                {
                    ListViewItem tijd = new ListViewItem(p.Tijd.ToString());
                    ListViewItem binnen = new ListViewItem(p.Binnen.ToString());
                    ListViewItem personen = new ListViewItem(p.AantalPers.ToString());
                    ListViewItem naam = new ListViewItem(p.GroepNaam);
                    ListViewItem telefoonnummer = new ListViewItem(p.TelefoonNummer.ToString());
                    ListViewItem geldig = new ListViewItem(geldiger.ToString());
                    ListViewItem plaats = new ListViewItem(plaatscheck.ToString());

                    if (tijd.ToString() == geldig.ToString())
                    {
                        if (binnen.ToString() == plaats.ToString())
                        {
                            ListView1.Items.Add(tijd);
                            ListView1.Items.Add("binnen");
                            ListView1.Items.Add(personen);
                            ListView1.Items.Add(naam);
                            ListView1.Items.Add(telefoonnummer);
                        }
                        else
                        {
                            ListView1.Items.Add(tijd);
                            ListView1.Items.Add("buiten");
                            ListView1.Items.Add(personen);
                            ListView1.Items.Add(naam);
                            ListView1.Items.Add(telefoonnummer);
                        }

                        //item.SubItems.Add(p.Binnen.ToString());
                        //item.SubItems.Add(p.AantalPers.ToString());
                        //item.SubItems.Add(p.GroepNaam);
                        //item.SubItems.Add(p.TelefoonNummer.ToString());

                    }
                }

            } else if (ckeckedTijd == 20)
            {
                int geldiger = 20;
                bool plaatscheck = true;
                List<ReserverenForms> reserveringen = restaurant.reserveringen.ToList();
                foreach (ReserverenForms p in reserveringen)
                {
                    ListViewItem tijd = new ListViewItem(p.Tijd.ToString());
                    ListViewItem binnen = new ListViewItem(p.Binnen.ToString());
                    ListViewItem personen = new ListViewItem(p.AantalPers.ToString());
                    ListViewItem naam = new ListViewItem(p.GroepNaam);
                    ListViewItem telefoonnummer = new ListViewItem(p.TelefoonNummer.ToString());
                    ListViewItem geldig = new ListViewItem(geldiger.ToString());
                    ListViewItem plaats = new ListViewItem(plaatscheck.ToString());

                    if (tijd.ToString() == geldig.ToString())
                    {
                        if (binnen.ToString() == plaats.ToString())
                        {
                            ListView1.Items.Add(tijd);
                            ListView1.Items.Add("binnen");
                            ListView1.Items.Add(personen);
                            ListView1.Items.Add(naam);
                            ListView1.Items.Add(telefoonnummer);
                        }
                        else
                        {
                            ListView1.Items.Add(tijd);
                            ListView1.Items.Add("buiten");
                            ListView1.Items.Add(personen);
                            ListView1.Items.Add(naam);
                            ListView1.Items.Add(telefoonnummer);
                        }

                        //item.SubItems.Add(p.Binnen.ToString());
                        //item.SubItems.Add(p.AantalPers.ToString());
                        //item.SubItems.Add(p.GroepNaam);
                        //item.SubItems.Add(p.TelefoonNummer.ToString());

                    }
                }

            } else
            {
                int geldiger = 21;
                bool plaatscheck = true;
                List<ReserverenForms> reserveringen = restaurant.reserveringen.ToList();
                foreach (ReserverenForms p in reserveringen)
                {
                    ListViewItem tijd = new ListViewItem(p.Tijd.ToString());
                    ListViewItem binnen = new ListViewItem(p.Binnen.ToString());
                    ListViewItem personen = new ListViewItem(p.AantalPers.ToString());
                    ListViewItem naam = new ListViewItem(p.GroepNaam);
                    ListViewItem telefoonnummer = new ListViewItem(p.TelefoonNummer.ToString());
                    ListViewItem geldig = new ListViewItem(geldiger.ToString());
                    ListViewItem plaats = new ListViewItem(plaatscheck.ToString());

                    if (tijd.ToString() == geldig.ToString())
                    {
                        if (binnen.ToString() == plaats.ToString())
                        {
                            ListView1.Items.Add(tijd);
                            ListView1.Items.Add("binnen");
                            ListView1.Items.Add(personen);
                            ListView1.Items.Add(naam);
                            ListView1.Items.Add(telefoonnummer);
                        }
                        else
                        {
                            ListView1.Items.Add(tijd);
                            ListView1.Items.Add("buiten");
                            ListView1.Items.Add(personen);
                            ListView1.Items.Add(naam);
                            ListView1.Items.Add(telefoonnummer);
                        }

                        //item.SubItems.Add(p.Binnen.ToString());
                        //item.SubItems.Add(p.AantalPers.ToString());
                        //item.SubItems.Add(p.GroepNaam);
                        //item.SubItems.Add(p.TelefoonNummer.ToString());

                    }
                }

            }
            //Box1.DataSource = restaurant.reserveringen;
            //Box1.DataBindings;
            //foreach (var n in restaurant.reserveringen.Skip(restaurant.reserveringen.IndexOf(textBox1))) {
                //Box1.Items.AddRange(restaurant.reserveringen.ToArray());
                //Box1.DataSource = restaurant.reserveringen;
                //Box1.DataSource = n;

            //}




            //foreach(x = 1; x <= 50; x++)
            //{
            //Box1.Items.Add("Item " + x.ToString());
           // }
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void NameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Telefoon_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }
    }
}
