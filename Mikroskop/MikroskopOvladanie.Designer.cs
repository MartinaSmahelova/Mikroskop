namespace Mikroskop
{
    partial class MikroskopOvladanie
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTlakVKomore = new System.Windows.Forms.Label();
            this.btnKomoruVycerpat = new System.Windows.Forms.Button();
            this.timerKomoruVycerpat = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTlakVTubuse = new System.Windows.Forms.Label();
            this.btnKomoruZavzdusnit = new System.Windows.Forms.Button();
            this.btnKomoruZavrit = new System.Windows.Forms.Button();
            this.btnKomoruOtevrit = new System.Windows.Forms.Button();
            this.picBoxVizualizace = new System.Windows.Forms.PictureBox();
            this.picBoxObraz = new System.Windows.Forms.PictureBox();
            this.timerKomoruZavzdusnit = new System.Windows.Forms.Timer(this.components);
            this.trackBarUrychlovavNapeti = new System.Windows.Forms.TrackBar();
            this.trackBarPracovniVzdalenst = new System.Windows.Forms.TrackBar();
            this.checkBoxNapajeni = new System.Windows.Forms.CheckBox();
            this.btnSED = new System.Windows.Forms.Button();
            this.btnBSED = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUrychlovacNapeti = new System.Windows.Forms.Label();
            this.lblPracovniVzdálenost = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxVizualizace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxObraz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarUrychlovavNapeti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPracovniVzdalenst)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTlakVKomore
            // 
            this.lblTlakVKomore.AutoSize = true;
            this.lblTlakVKomore.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTlakVKomore.ForeColor = System.Drawing.Color.White;
            this.lblTlakVKomore.Location = new System.Drawing.Point(254, 205);
            this.lblTlakVKomore.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTlakVKomore.Name = "lblTlakVKomore";
            this.lblTlakVKomore.Size = new System.Drawing.Size(78, 25);
            this.lblTlakVKomore.TabIndex = 0;
            this.lblTlakVKomore.Text = "101325";
            // 
            // btnKomoruVycerpat
            // 
            this.btnKomoruVycerpat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnKomoruVycerpat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.btnKomoruVycerpat.FlatAppearance.BorderSize = 0;
            this.btnKomoruVycerpat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(77)))), ((int)(((byte)(102)))));
            this.btnKomoruVycerpat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(77)))), ((int)(((byte)(102)))));
            this.btnKomoruVycerpat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKomoruVycerpat.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKomoruVycerpat.ForeColor = System.Drawing.Color.White;
            this.btnKomoruVycerpat.Location = new System.Drawing.Point(36, 293);
            this.btnKomoruVycerpat.Margin = new System.Windows.Forms.Padding(5);
            this.btnKomoruVycerpat.Name = "btnKomoruVycerpat";
            this.btnKomoruVycerpat.Size = new System.Drawing.Size(150, 45);
            this.btnKomoruVycerpat.TabIndex = 1;
            this.btnKomoruVycerpat.Text = "Vyčerpať";
            this.btnKomoruVycerpat.UseVisualStyleBackColor = false;
            this.btnKomoruVycerpat.Click += new System.EventHandler(this.btnKomoruVycerpat_Click);
            // 
            // timerKomoruVycerpat
            // 
            this.timerKomoruVycerpat.Interval = 500;
            this.timerKomoruVycerpat.Tick += new System.EventHandler(this.TimerKomoruVycerpat_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tlak v komore";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(338, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tlak v tubuse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(338, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pa";
            // 
            // lblTlakVTubuse
            // 
            this.lblTlakVTubuse.AutoSize = true;
            this.lblTlakVTubuse.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTlakVTubuse.ForeColor = System.Drawing.Color.White;
            this.lblTlakVTubuse.Location = new System.Drawing.Point(254, 246);
            this.lblTlakVTubuse.Name = "lblTlakVTubuse";
            this.lblTlakVTubuse.Size = new System.Drawing.Size(78, 25);
            this.lblTlakVTubuse.TabIndex = 6;
            this.lblTlakVTubuse.Text = "101325";
            // 
            // btnKomoruZavzdusnit
            // 
            this.btnKomoruZavzdusnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnKomoruZavzdusnit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.btnKomoruZavzdusnit.FlatAppearance.BorderSize = 0;
            this.btnKomoruZavzdusnit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.btnKomoruZavzdusnit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(77)))), ((int)(((byte)(102)))));
            this.btnKomoruZavzdusnit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(77)))), ((int)(((byte)(102)))));
            this.btnKomoruZavzdusnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKomoruZavzdusnit.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKomoruZavzdusnit.ForeColor = System.Drawing.Color.White;
            this.btnKomoruZavzdusnit.Location = new System.Drawing.Point(231, 293);
            this.btnKomoruZavzdusnit.Margin = new System.Windows.Forms.Padding(5);
            this.btnKomoruZavzdusnit.Name = "btnKomoruZavzdusnit";
            this.btnKomoruZavzdusnit.Size = new System.Drawing.Size(150, 45);
            this.btnKomoruZavzdusnit.TabIndex = 7;
            this.btnKomoruZavzdusnit.Text = "Zavzdušniť";
            this.btnKomoruZavzdusnit.UseVisualStyleBackColor = false;
            this.btnKomoruZavzdusnit.Click += new System.EventHandler(this.btnKomoruZavzdusnit_Click);
            // 
            // btnKomoruZavrit
            // 
            this.btnKomoruZavrit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnKomoruZavrit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.btnKomoruZavrit.FlatAppearance.BorderSize = 0;
            this.btnKomoruZavrit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.btnKomoruZavrit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(77)))), ((int)(((byte)(102)))));
            this.btnKomoruZavrit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(77)))), ((int)(((byte)(102)))));
            this.btnKomoruZavrit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKomoruZavrit.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKomoruZavrit.ForeColor = System.Drawing.Color.White;
            this.btnKomoruZavrit.Location = new System.Drawing.Point(36, 79);
            this.btnKomoruZavrit.Name = "btnKomoruZavrit";
            this.btnKomoruZavrit.Size = new System.Drawing.Size(150, 45);
            this.btnKomoruZavrit.TabIndex = 8;
            this.btnKomoruZavrit.Text = "Zavřít ";
            this.btnKomoruZavrit.UseVisualStyleBackColor = false;
            this.btnKomoruZavrit.Click += new System.EventHandler(this.btnKomoruZavrit_Click);
            // 
            // btnKomoruOtevrit
            // 
            this.btnKomoruOtevrit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnKomoruOtevrit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.btnKomoruOtevrit.FlatAppearance.BorderSize = 0;
            this.btnKomoruOtevrit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.btnKomoruOtevrit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(77)))), ((int)(((byte)(102)))));
            this.btnKomoruOtevrit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(77)))), ((int)(((byte)(102)))));
            this.btnKomoruOtevrit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKomoruOtevrit.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKomoruOtevrit.ForeColor = System.Drawing.Color.White;
            this.btnKomoruOtevrit.Location = new System.Drawing.Point(230, 79);
            this.btnKomoruOtevrit.Name = "btnKomoruOtevrit";
            this.btnKomoruOtevrit.Size = new System.Drawing.Size(150, 45);
            this.btnKomoruOtevrit.TabIndex = 9;
            this.btnKomoruOtevrit.Text = "Otevřít ";
            this.btnKomoruOtevrit.UseVisualStyleBackColor = false;
            this.btnKomoruOtevrit.Click += new System.EventHandler(this.btnKomoruOtevrit_Click);
            // 
            // picBoxVizualizace
            // 
            this.picBoxVizualizace.Image = global::Mikroskop.Properties.Resources.mikroskop_se_vzduchem;
            this.picBoxVizualizace.Location = new System.Drawing.Point(23, 109);
            this.picBoxVizualizace.Name = "picBoxVizualizace";
            this.picBoxVizualizace.Size = new System.Drawing.Size(244, 434);
            this.picBoxVizualizace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxVizualizace.TabIndex = 10;
            this.picBoxVizualizace.TabStop = false;
            // 
            // picBoxObraz
            // 
            this.picBoxObraz.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picBoxObraz.Location = new System.Drawing.Point(40, 75);
            this.picBoxObraz.Name = "picBoxObraz";
            this.picBoxObraz.Size = new System.Drawing.Size(435, 434);
            this.picBoxObraz.TabIndex = 11;
            this.picBoxObraz.TabStop = false;
            // 
            // timerKomoruZavzdusnit
            // 
            this.timerKomoruZavzdusnit.Interval = 500;
            this.timerKomoruZavzdusnit.Tick += new System.EventHandler(this.timerKomoruZavzdusnit_Tick);
            // 
            // trackBarUrychlovavNapeti
            // 
            this.trackBarUrychlovavNapeti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.trackBarUrychlovavNapeti.Location = new System.Drawing.Point(36, 507);
            this.trackBarUrychlovavNapeti.Maximum = 25;
            this.trackBarUrychlovavNapeti.Name = "trackBarUrychlovavNapeti";
            this.trackBarUrychlovavNapeti.Size = new System.Drawing.Size(359, 56);
            this.trackBarUrychlovavNapeti.SmallChange = 5;
            this.trackBarUrychlovavNapeti.TabIndex = 12;
            this.trackBarUrychlovavNapeti.TickFrequency = 5;
            this.trackBarUrychlovavNapeti.Scroll += new System.EventHandler(this.trackBary_Scroll);
            // 
            // trackBarPracovniVzdalenst
            // 
            this.trackBarPracovniVzdalenst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.trackBarPracovniVzdalenst.LargeChange = 2;
            this.trackBarPracovniVzdalenst.Location = new System.Drawing.Point(35, 603);
            this.trackBarPracovniVzdalenst.Name = "trackBarPracovniVzdalenst";
            this.trackBarPracovniVzdalenst.Size = new System.Drawing.Size(359, 56);
            this.trackBarPracovniVzdalenst.TabIndex = 13;
            this.trackBarPracovniVzdalenst.Scroll += new System.EventHandler(this.trackBary_Scroll);
            // 
            // checkBoxNapajeni
            // 
            this.checkBoxNapajeni.AutoSize = true;
            this.checkBoxNapajeni.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxNapajeni.ForeColor = System.Drawing.Color.White;
            this.checkBoxNapajeni.Location = new System.Drawing.Point(43, 426);
            this.checkBoxNapajeni.Name = "checkBoxNapajeni";
            this.checkBoxNapajeni.Size = new System.Drawing.Size(116, 29);
            this.checkBoxNapajeni.TabIndex = 14;
            this.checkBoxNapajeni.Text = "Napájení";
            this.checkBoxNapajeni.UseVisualStyleBackColor = true;
            this.checkBoxNapajeni.Click += new System.EventHandler(this.checkBoxNapajeni_Click);
            // 
            // btnSED
            // 
            this.btnSED.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnSED.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.btnSED.FlatAppearance.BorderSize = 0;
            this.btnSED.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.btnSED.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(77)))), ((int)(((byte)(102)))));
            this.btnSED.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(77)))), ((int)(((byte)(102)))));
            this.btnSED.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSED.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSED.ForeColor = System.Drawing.Color.White;
            this.btnSED.Location = new System.Drawing.Point(186, 34);
            this.btnSED.Name = "btnSED";
            this.btnSED.Size = new System.Drawing.Size(132, 45);
            this.btnSED.TabIndex = 15;
            this.btnSED.Text = "SED";
            this.btnSED.UseVisualStyleBackColor = false;
            this.btnSED.Click += new System.EventHandler(this.btnDetektory_Click);
            // 
            // btnBSED
            // 
            this.btnBSED.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnBSED.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.btnBSED.FlatAppearance.BorderSize = 0;
            this.btnBSED.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.btnBSED.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(77)))), ((int)(((byte)(102)))));
            this.btnBSED.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(77)))), ((int)(((byte)(102)))));
            this.btnBSED.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBSED.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBSED.ForeColor = System.Drawing.Color.White;
            this.btnBSED.Location = new System.Drawing.Point(343, 34);
            this.btnBSED.Name = "btnBSED";
            this.btnBSED.Size = new System.Drawing.Size(132, 45);
            this.btnBSED.TabIndex = 16;
            this.btnBSED.Text = "BSED";
            this.btnBSED.UseVisualStyleBackColor = false;
            this.btnBSED.Click += new System.EventHandler(this.btnDetektory_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(47, 479);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Urychlovac Napětí ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(47, 576);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Pracovní vzdálenost";
            // 
            // lblUrychlovacNapeti
            // 
            this.lblUrychlovacNapeti.AutoSize = true;
            this.lblUrychlovacNapeti.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUrychlovacNapeti.ForeColor = System.Drawing.Color.White;
            this.lblUrychlovacNapeti.Location = new System.Drawing.Point(309, 479);
            this.lblUrychlovacNapeti.Name = "lblUrychlovacNapeti";
            this.lblUrychlovacNapeti.Size = new System.Drawing.Size(23, 25);
            this.lblUrychlovacNapeti.TabIndex = 19;
            this.lblUrychlovacNapeti.Text = "0";
            // 
            // lblPracovniVzdálenost
            // 
            this.lblPracovniVzdálenost.AutoSize = true;
            this.lblPracovniVzdálenost.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPracovniVzdálenost.ForeColor = System.Drawing.Color.White;
            this.lblPracovniVzdálenost.Location = new System.Drawing.Point(309, 574);
            this.lblPracovniVzdálenost.Name = "lblPracovniVzdálenost";
            this.lblPracovniVzdálenost.Size = new System.Drawing.Size(23, 25);
            this.lblPracovniVzdálenost.TabIndex = 20;
            this.lblPracovniVzdálenost.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(345, 479);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "kV";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(338, 574);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "mm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.label7.Location = new System.Drawing.Point(84, 577);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 27);
            this.label7.TabIndex = 23;
            this.label7.Text = "Vizualizace";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.label8.Location = new System.Drawing.Point(221, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 27);
            this.label8.TabIndex = 24;
            this.label8.Text = "Obraz";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(50, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 27);
            this.label11.TabIndex = 25;
            this.label11.Text = "Detektory";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(36, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(187, 27);
            this.label12.TabIndex = 26;
            this.label12.Text = "Ovládání Komory";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(38, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(171, 27);
            this.label13.TabIndex = 27;
            this.label13.Text = "Ovládání Vákua";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(38, 381);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(281, 27);
            this.label14.TabIndex = 28;
            this.label14.Text = "Ovládání Svazku Elektronů";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.picBoxVizualizace);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(1, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 694);
            this.panel1.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.btnKomoruOtevrit);
            this.panel2.Controls.Add(this.trackBarPracovniVzdalenst);
            this.panel2.Controls.Add(this.btnKomoruZavrit);
            this.panel2.Controls.Add(this.lblTlakVKomore);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.trackBarUrychlovavNapeti);
            this.panel2.Controls.Add(this.btnKomoruVycerpat);
            this.panel2.Controls.Add(this.checkBoxNapajeni);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnKomoruZavzdusnit);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lblUrychlovacNapeti);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblTlakVTubuse);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lblPracovniVzdálenost);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(296, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 691);
            this.panel2.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.picBoxObraz);
            this.panel3.Location = new System.Drawing.Point(710, -5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(519, 566);
            this.panel3.TabIndex = 34;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.btnSED);
            this.panel4.Controls.Add(this.btnBSED);
            this.panel4.Location = new System.Drawing.Point(710, 558);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(519, 131);
            this.panel4.TabIndex = 35;
            // 
            // MikroskopOvladanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 688);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MikroskopOvladanie";
            this.Text = "Ovládání Mikroskopu ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxVizualizace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxObraz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarUrychlovavNapeti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPracovniVzdalenst)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTlakVKomore;
        private System.Windows.Forms.Button btnKomoruVycerpat;
        private System.Windows.Forms.Timer timerKomoruVycerpat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTlakVTubuse;
        private System.Windows.Forms.Button btnKomoruZavzdusnit;
        private System.Windows.Forms.Button btnKomoruZavrit;
        private System.Windows.Forms.Button btnKomoruOtevrit;
        private System.Windows.Forms.PictureBox picBoxVizualizace;
        private System.Windows.Forms.PictureBox picBoxObraz;
        private System.Windows.Forms.Timer timerKomoruZavzdusnit;
        private System.Windows.Forms.TrackBar trackBarUrychlovavNapeti;
        private System.Windows.Forms.TrackBar trackBarPracovniVzdalenst;
        private System.Windows.Forms.CheckBox checkBoxNapajeni;
        private System.Windows.Forms.Button btnSED;
        private System.Windows.Forms.Button btnBSED;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUrychlovacNapeti;
        private System.Windows.Forms.Label lblPracovniVzdálenost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

