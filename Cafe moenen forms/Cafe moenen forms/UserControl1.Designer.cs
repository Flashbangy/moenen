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
            this.label1 = new System.Windows.Forms.Label();
            this.Reserveer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.creator_1 = new System.Windows.Forms.Label();
            this.creator_2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tijdKeuze = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.AantalMensen = new System.Windows.Forms.NumericUpDown();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.TelefoonNummer = new System.Windows.Forms.TextBox();
            this.Naam = new System.Windows.Forms.Label();
            this.Telefoon = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Tijd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Binnen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Personen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.persoonNaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Box1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.AantalMensen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(373, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restaurant Moenen";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Reserveer
            // 
            this.Reserveer.Location = new System.Drawing.Point(184, 307);
            this.Reserveer.Name = "Reserveer";
            this.Reserveer.Size = new System.Drawing.Size(90, 23);
            this.Reserveer.TabIndex = 6;
            this.Reserveer.Text = "Reserveren";
            this.Reserveer.UseVisualStyleBackColor = true;
            this.Reserveer.Click += new System.EventHandler(this.Reserveer_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Zitplek";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hoe laat?";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hoeveel mensen?";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "melding";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tijdKeuze
            // 
            this.tijdKeuze.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tijdKeuze.FormattingEnabled = true;
            this.tijdKeuze.Items.AddRange(new object[] {
            "17",
            "18",
            "19",
            "20",
            "21"});
            this.tijdKeuze.Location = new System.Drawing.Point(30, 306);
            this.tijdKeuze.Name = "tijdKeuze";
            this.tijdKeuze.Size = new System.Drawing.Size(121, 24);
            this.tijdKeuze.TabIndex = 15;
            this.tijdKeuze.SelectedIndexChanged += new System.EventHandler(this.tijdKeuze_SelectedIndexChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(109, 191);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(69, 21);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Buiten";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(30, 191);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 21);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Binnen";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
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
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 26);
            this.button1.TabIndex = 23;
            this.button1.Text = "Hoeveel tafels beschikbaar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "binnen";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "buiten";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "17",
            "18",
            "19",
            "20",
            "21"});
            this.comboBox1.Location = new System.Drawing.Point(22, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(537, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Toon";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "17",
            "18",
            "19",
            "20",
            "21"});
            this.comboBox2.Location = new System.Drawing.Point(398, 285);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 28;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Tijd,
            this.Binnen,
            this.Personen,
            this.persoonNaam,
            this.Nummer});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(323, 69);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(565, 199);
            this.listView1.TabIndex = 29;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Telefoon);
            this.Controls.Add(this.Naam);
            this.Controls.Add(this.TelefoonNummer);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.AantalMensen);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.tijdKeuze);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.creator_2);
            this.Controls.Add(this.creator_1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Reserveer);
            this.Controls.Add(this.Box1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(903, 518);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AantalMensen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Reserveer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label creator_1;
        private System.Windows.Forms.Label creator_2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox tijdKeuze;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.NumericUpDown AantalMensen;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.TextBox TelefoonNummer;
        private System.Windows.Forms.Label Naam;
        private System.Windows.Forms.Label Telefoon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Tijd;
        private System.Windows.Forms.ColumnHeader Binnen;
        private System.Windows.Forms.ColumnHeader Personen;
        private System.Windows.Forms.ColumnHeader persoonNaam;
        private System.Windows.Forms.ColumnHeader Nummer;
        private System.Windows.Forms.ListBox Box1;
    }
}
