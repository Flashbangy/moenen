namespace Cafe_moenen_forms
{
    partial class UserControl1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label1 = new System.Windows.Forms.Label();
            this.Reserveer = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.creator_1 = new System.Windows.Forms.Label();
            this.creator_2 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.TijdKeuze = new System.Windows.Forms.ComboBox();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.AantalMensen = new System.Windows.Forms.NumericUpDown();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.TelefoonNummer = new System.Windows.Forms.TextBox();
            this.Naam = new System.Windows.Forms.Label();
            this.Telefoon = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.ComboBox2 = new System.Windows.Forms.ComboBox();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.Tijd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Binnen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Personen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.persoonNaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Box1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.AantalMensen)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Label1.Location = new System.Drawing.Point(373, 12);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(201, 25);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Restaurant Moenen";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Reserveer
            // 
            this.Reserveer.Location = new System.Drawing.Point(184, 307);
            this.Reserveer.Name = "Reserveer";
            this.Reserveer.Size = new System.Drawing.Size(101, 23);
            this.Reserveer.TabIndex = 6;
            this.Reserveer.Text = "Reserveren";
            this.Reserveer.UseVisualStyleBackColor = true;
            this.Reserveer.Click += new System.EventHandler(this.Reserveer_Click_1);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(27, 171);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(50, 17);
            this.Label3.TabIndex = 8;
            this.Label3.Text = "Zitplek";
            this.Label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(27, 285);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(69, 17);
            this.Label4.TabIndex = 9;
            this.Label4.Text = "Hoe laat?";
            this.Label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(27, 226);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(122, 17);
            this.Label5.TabIndex = 10;
            this.Label5.Text = "Hoeveel mensen?";
            this.Label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // creator_1
            // 
            this.creator_1.AutoSize = true;
            this.creator_1.Location = new System.Drawing.Point(800, 501);
            this.creator_1.Name = "creator_1";
            this.creator_1.Size = new System.Drawing.Size(58, 17);
            this.creator_1.TabIndex = 11;
            this.creator_1.Text = "Yannick";
            // 
            // creator_2
            // 
            this.creator_2.AutoSize = true;
            this.creator_2.Location = new System.Drawing.Point(854, 501);
            this.creator_2.Name = "creator_2";
            this.creator_2.Size = new System.Drawing.Size(49, 17);
            this.creator_2.TabIndex = 12;
            this.creator_2.Text = "Bartek";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(181, 270);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(57, 17);
            this.Label6.TabIndex = 14;
            this.Label6.Text = "melding";
            this.Label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // TijdKeuze
            // 
            this.TijdKeuze.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TijdKeuze.FormattingEnabled = true;
            this.TijdKeuze.Items.AddRange(new object[] {
            "17",
            "18",
            "19",
            "20",
            "21"});
            this.TijdKeuze.Location = new System.Drawing.Point(30, 306);
            this.TijdKeuze.Name = "TijdKeuze";
            this.TijdKeuze.Size = new System.Drawing.Size(121, 24);
            this.TijdKeuze.TabIndex = 15;
            this.TijdKeuze.SelectedIndexChanged += new System.EventHandler(this.TijdKeuze_SelectedIndexChanged);
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Location = new System.Drawing.Point(109, 191);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(69, 21);
            this.RadioButton1.TabIndex = 16;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "Buiten";
            this.RadioButton1.UseVisualStyleBackColor = true;
            this.RadioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Location = new System.Drawing.Point(30, 191);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(73, 21);
            this.RadioButton2.TabIndex = 17;
            this.RadioButton2.TabStop = true;
            this.RadioButton2.Text = "Binnen";
            this.RadioButton2.UseVisualStyleBackColor = true;
            this.RadioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // AantalMensen
            // 
            this.AantalMensen.Location = new System.Drawing.Point(31, 246);
            this.AantalMensen.Name = "AantalMensen";
            this.AantalMensen.Size = new System.Drawing.Size(120, 22);
            this.AantalMensen.TabIndex = 18;
            this.AantalMensen.ValueChanged += new System.EventHandler(this.AantalMensen_ValueChanged);
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(30, 365);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(100, 22);
            this.NameInput.TabIndex = 19;
            this.NameInput.TextChanged += new System.EventHandler(this.NameInput_TextChanged);
            // 
            // TelefoonNummer
            // 
            this.TelefoonNummer.Location = new System.Drawing.Point(34, 423);
            this.TelefoonNummer.Name = "TelefoonNummer";
            this.TelefoonNummer.Size = new System.Drawing.Size(100, 22);
            this.TelefoonNummer.TabIndex = 20;
            this.TelefoonNummer.TextChanged += new System.EventHandler(this.TelefoonNummer_TextChanged);
            // 
            // Naam
            // 
            this.Naam.AutoSize = true;
            this.Naam.Location = new System.Drawing.Point(31, 345);
            this.Naam.Name = "Naam";
            this.Naam.Size = new System.Drawing.Size(45, 17);
            this.Naam.TabIndex = 21;
            this.Naam.Text = "Naam";
            this.Naam.Click += new System.EventHandler(this.Naam_Click);
            // 
            // Telefoon
            // 
            this.Telefoon.AutoSize = true;
            this.Telefoon.Location = new System.Drawing.Point(31, 403);
            this.Telefoon.Name = "Telefoon";
            this.Telefoon.Size = new System.Drawing.Size(119, 17);
            this.Telefoon.TabIndex = 22;
            this.Telefoon.Text = "Telefoon nummer";
            this.Telefoon.Click += new System.EventHandler(this.Telefoon_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(22, 14);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(199, 26);
            this.Button1.TabIndex = 23;
            this.Button1.Text = "Hoeveel tafels beschikbaar";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(149, 59);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(51, 17);
            this.Label2.TabIndex = 24;
            this.Label2.Text = "binnen";
            this.Label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(225, 59);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(47, 17);
            this.Label7.TabIndex = 25;
            this.Label7.Text = "buiten";
            this.Label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // ComboBox1
            // 
            this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "17",
            "18",
            "19",
            "20",
            "21"});
            this.ComboBox1.Location = new System.Drawing.Point(22, 59);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(121, 24);
            this.ComboBox1.TabIndex = 26;
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(378, 285);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(238, 23);
            this.Button2.TabIndex = 27;
            this.Button2.Text = "Toon reserveringen op tijdstip:";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // ComboBox2
            // 
            this.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox2.FormattingEnabled = true;
            this.ComboBox2.Items.AddRange(new object[] {
            "17",
            "18",
            "19",
            "20",
            "21"});
            this.ComboBox2.Location = new System.Drawing.Point(622, 284);
            this.ComboBox2.Name = "ComboBox2";
            this.ComboBox2.Size = new System.Drawing.Size(121, 24);
            this.ComboBox2.TabIndex = 28;
            this.ComboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // ListView1
            // 
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Tijd,
            this.Binnen,
            this.Personen,
            this.persoonNaam,
            this.Nummer});
            this.ListView1.HideSelection = false;
            this.ListView1.Location = new System.Drawing.Point(323, 69);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(565, 199);
            this.ListView1.TabIndex = 29;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // Tijd
            // 
            this.Tijd.Text = "Tijd";
            this.Tijd.Width = 40;
            // 
            // Binnen
            // 
            this.Binnen.Text = "Binnen";
            this.Binnen.Width = 40;
            // 
            // Personen
            // 
            this.Personen.Text = "Personen";
            this.Personen.Width = 40;
            // 
            // persoonNaam
            // 
            this.persoonNaam.Text = "persoonNaam";
            this.persoonNaam.Width = 40;
            // 
            // Nummer
            // 
            this.Nummer.Text = "Nummer";
            this.Nummer.Width = 40;
            // 
            // Box1
            // 
            this.Box1.FormattingEnabled = true;
            this.Box1.ItemHeight = 16;
            this.Box1.Location = new System.Drawing.Point(873, 275);
            this.Box1.Margin = new System.Windows.Forms.Padding(4);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(15, 4);
            this.Box1.TabIndex = 2;
            this.Box1.SelectedIndexChanged += new System.EventHandler(this.Box1_SelectedIndexChanged);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ListView1);
            this.Controls.Add(this.ComboBox2);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Telefoon);
            this.Controls.Add(this.Naam);
            this.Controls.Add(this.TelefoonNummer);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.AantalMensen);
            this.Controls.Add(this.RadioButton2);
            this.Controls.Add(this.RadioButton1);
            this.Controls.Add(this.TijdKeuze);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.creator_2);
            this.Controls.Add(this.creator_1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Reserveer);
            this.Controls.Add(this.Box1);
            this.Controls.Add(this.Label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(903, 518);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AantalMensen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button Reserveer;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label creator_1;
        private System.Windows.Forms.Label creator_2;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.ComboBox TijdKeuze;
        private System.Windows.Forms.RadioButton RadioButton1;
        private System.Windows.Forms.RadioButton RadioButton2;
        private System.Windows.Forms.NumericUpDown AantalMensen;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.TextBox TelefoonNummer;
        private System.Windows.Forms.Label Naam;
        private System.Windows.Forms.Label Telefoon;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.ComboBox ComboBox1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.ComboBox ComboBox2;
        private System.Windows.Forms.ListView ListView1;
        private System.Windows.Forms.ColumnHeader Tijd;
        private System.Windows.Forms.ColumnHeader Binnen;
        private System.Windows.Forms.ColumnHeader Personen;
        private System.Windows.Forms.ColumnHeader persoonNaam;
        private System.Windows.Forms.ColumnHeader Nummer;
        private System.Windows.Forms.ListBox Box1;
    }
}
