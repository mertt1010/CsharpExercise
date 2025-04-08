namespace hastakayıt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kaydetbutton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fotobutton = new System.Windows.Forms.Button();
            this.fotolabel = new System.Windows.Forms.Label();
            this.adrestextbox = new System.Windows.Forms.TextBox();
            this.adreslabel = new System.Windows.Forms.Label();
            this.cinsiyetlabel = new System.Windows.Forms.Label();
            this.erkekradiobutton = new System.Windows.Forms.RadioButton();
            this.kadınradiobutton = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dogumlabel = new System.Windows.Forms.Label();
            this.sehircombobox = new System.Windows.Forms.ComboBox();
            this.sehirlabel = new System.Windows.Forms.Label();
            this.tctextbox = new System.Windows.Forms.TextBox();
            this.tclabel = new System.Windows.Forms.Label();
            this.soyadtextbox = new System.Windows.Forms.TextBox();
            this.soyadlabel = new System.Windows.Forms.Label();
            this.adtextbox = new System.Windows.Forms.TextBox();
            this.adlabel = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.namelabel = new System.Windows.Forms.Label();
            this.surnamelabel = new System.Windows.Forms.Label();
            this.citylabel = new System.Windows.Forms.Label();
            this.birthdaylabel = new System.Windows.Forms.Label();
            this.cinslabel = new System.Windows.Forms.Label();
            this.konumlabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.hastalistbox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kaydetbutton);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.fotobutton);
            this.groupBox1.Controls.Add(this.fotolabel);
            this.groupBox1.Controls.Add(this.adrestextbox);
            this.groupBox1.Controls.Add(this.adreslabel);
            this.groupBox1.Controls.Add(this.cinsiyetlabel);
            this.groupBox1.Controls.Add(this.erkekradiobutton);
            this.groupBox1.Controls.Add(this.kadınradiobutton);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.dogumlabel);
            this.groupBox1.Controls.Add(this.sehircombobox);
            this.groupBox1.Controls.Add(this.sehirlabel);
            this.groupBox1.Controls.Add(this.tctextbox);
            this.groupBox1.Controls.Add(this.tclabel);
            this.groupBox1.Controls.Add(this.soyadtextbox);
            this.groupBox1.Controls.Add(this.soyadlabel);
            this.groupBox1.Controls.Add(this.adtextbox);
            this.groupBox1.Controls.Add(this.adlabel);
            this.groupBox1.Location = new System.Drawing.Point(42, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 618);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formu Doldurun";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // kaydetbutton
            // 
            this.kaydetbutton.Location = new System.Drawing.Point(129, 584);
            this.kaydetbutton.Name = "kaydetbutton";
            this.kaydetbutton.Size = new System.Drawing.Size(94, 29);
            this.kaydetbutton.TabIndex = 19;
            this.kaydetbutton.Text = "KAYDET";
            this.kaydetbutton.UseVisualStyleBackColor = true;
            this.kaydetbutton.Click += new System.EventHandler(this.kaydetbutton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Silver;
            this.checkBox1.Location = new System.Drawing.Point(22, 538);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(270, 24);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Kullanım koşullarını kabul ediyorum.";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(118, 440);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 92);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // fotobutton
            // 
            this.fotobutton.Location = new System.Drawing.Point(118, 394);
            this.fotobutton.Name = "fotobutton";
            this.fotobutton.Size = new System.Drawing.Size(125, 29);
            this.fotobutton.TabIndex = 16;
            this.fotobutton.Text = "FOTO SEÇ";
            this.fotobutton.UseVisualStyleBackColor = true;
            this.fotobutton.Click += new System.EventHandler(this.fotobutton_Click);
            // 
            // fotolabel
            // 
            this.fotolabel.AutoSize = true;
            this.fotolabel.Location = new System.Drawing.Point(21, 398);
            this.fotolabel.Name = "fotolabel";
            this.fotolabel.Size = new System.Drawing.Size(47, 20);
            this.fotolabel.TabIndex = 15;
            this.fotolabel.Text = "FOTO:";
            // 
            // adrestextbox
            // 
            this.adrestextbox.Location = new System.Drawing.Point(118, 318);
            this.adrestextbox.Multiline = true;
            this.adrestextbox.Name = "adrestextbox";
            this.adrestextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.adrestextbox.Size = new System.Drawing.Size(196, 70);
            this.adrestextbox.TabIndex = 14;
            this.adrestextbox.TextChanged += new System.EventHandler(this.adrestextbox_TextChanged);
            // 
            // adreslabel
            // 
            this.adreslabel.AutoSize = true;
            this.adreslabel.Location = new System.Drawing.Point(21, 318);
            this.adreslabel.Name = "adreslabel";
            this.adreslabel.Size = new System.Drawing.Size(55, 20);
            this.adreslabel.TabIndex = 13;
            this.adreslabel.Text = "ADRES";
            // 
            // cinsiyetlabel
            // 
            this.cinsiyetlabel.AutoSize = true;
            this.cinsiyetlabel.Location = new System.Drawing.Point(21, 276);
            this.cinsiyetlabel.Name = "cinsiyetlabel";
            this.cinsiyetlabel.Size = new System.Drawing.Size(69, 20);
            this.cinsiyetlabel.TabIndex = 12;
            this.cinsiyetlabel.Text = "CİNSİYET";
            // 
            // erkekradiobutton
            // 
            this.erkekradiobutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.erkekradiobutton.Location = new System.Drawing.Point(209, 274);
            this.erkekradiobutton.Name = "erkekradiobutton";
            this.erkekradiobutton.Size = new System.Drawing.Size(75, 22);
            this.erkekradiobutton.TabIndex = 11;
            this.erkekradiobutton.TabStop = true;
            this.erkekradiobutton.Text = "ERKEK";
            this.erkekradiobutton.UseVisualStyleBackColor = false;
            this.erkekradiobutton.CheckedChanged += new System.EventHandler(this.erkekradiobutton_CheckedChanged);
            // 
            // kadınradiobutton
            // 
            this.kadınradiobutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kadınradiobutton.Location = new System.Drawing.Point(105, 274);
            this.kadınradiobutton.Name = "kadınradiobutton";
            this.kadınradiobutton.Size = new System.Drawing.Size(75, 22);
            this.kadınradiobutton.TabIndex = 10;
            this.kadınradiobutton.TabStop = true;
            this.kadınradiobutton.Text = "KADIN";
            this.kadınradiobutton.UseVisualStyleBackColor = false;
            this.kadınradiobutton.CheckedChanged += new System.EventHandler(this.kadınradiobutton_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(87, 217);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 27);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dogumlabel
            // 
            this.dogumlabel.AutoSize = true;
            this.dogumlabel.Location = new System.Drawing.Point(22, 222);
            this.dogumlabel.Name = "dogumlabel";
            this.dogumlabel.Size = new System.Drawing.Size(67, 20);
            this.dogumlabel.TabIndex = 8;
            this.dogumlabel.Text = "DOĞUM:";
            // 
            // sehircombobox
            // 
            this.sehircombobox.FormattingEnabled = true;
            this.sehircombobox.Location = new System.Drawing.Point(87, 171);
            this.sehircombobox.Name = "sehircombobox";
            this.sehircombobox.Size = new System.Drawing.Size(227, 28);
            this.sehircombobox.TabIndex = 7;
            this.sehircombobox.SelectedIndexChanged += new System.EventHandler(this.sehircombobox_SelectedIndexChanged);
            // 
            // sehirlabel
            // 
            this.sehirlabel.AutoSize = true;
            this.sehirlabel.Location = new System.Drawing.Point(21, 174);
            this.sehirlabel.Name = "sehirlabel";
            this.sehirlabel.Size = new System.Drawing.Size(52, 20);
            this.sehirlabel.TabIndex = 6;
            this.sehirlabel.Text = "ŞEHİR:";
            // 
            // tctextbox
            // 
            this.tctextbox.Location = new System.Drawing.Point(87, 122);
            this.tctextbox.Name = "tctextbox";
            this.tctextbox.Size = new System.Drawing.Size(227, 27);
            this.tctextbox.TabIndex = 5;
            this.tctextbox.TextChanged += new System.EventHandler(this.tctextbox_TextChanged);
            // 
            // tclabel
            // 
            this.tclabel.AutoSize = true;
            this.tclabel.Location = new System.Drawing.Point(21, 125);
            this.tclabel.Name = "tclabel";
            this.tclabel.Size = new System.Drawing.Size(28, 20);
            this.tclabel.TabIndex = 4;
            this.tclabel.Text = "TC:";
            // 
            // soyadtextbox
            // 
            this.soyadtextbox.Location = new System.Drawing.Point(87, 75);
            this.soyadtextbox.Name = "soyadtextbox";
            this.soyadtextbox.Size = new System.Drawing.Size(227, 27);
            this.soyadtextbox.TabIndex = 3;
            this.soyadtextbox.TextChanged += new System.EventHandler(this.soyadtextbox_TextChanged);
            // 
            // soyadlabel
            // 
            this.soyadlabel.AutoSize = true;
            this.soyadlabel.Location = new System.Drawing.Point(22, 78);
            this.soyadlabel.Name = "soyadlabel";
            this.soyadlabel.Size = new System.Drawing.Size(59, 20);
            this.soyadlabel.TabIndex = 2;
            this.soyadlabel.Text = "SOYAD:";
            // 
            // adtextbox
            // 
            this.adtextbox.Location = new System.Drawing.Point(87, 26);
            this.adtextbox.Name = "adtextbox";
            this.adtextbox.Size = new System.Drawing.Size(227, 27);
            this.adtextbox.TabIndex = 1;
            this.adtextbox.TextChanged += new System.EventHandler(this.adtextbox_TextChanged);
            // 
            // adlabel
            // 
            this.adlabel.AutoSize = true;
            this.adlabel.Location = new System.Drawing.Point(21, 29);
            this.adlabel.Name = "adlabel";
            this.adlabel.Size = new System.Drawing.Size(33, 20);
            this.adlabel.TabIndex = 0;
            this.adlabel.Text = "AD:";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hastalistbox);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.konumlabel);
            this.groupBox2.Controls.Add(this.cinslabel);
            this.groupBox2.Controls.Add(this.birthdaylabel);
            this.groupBox2.Controls.Add(this.citylabel);
            this.groupBox2.Controls.Add(this.surnamelabel);
            this.groupBox2.Controls.Add(this.namelabel);
            this.groupBox2.Location = new System.Drawing.Point(430, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(801, 552);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "KAYDEDİLEN BİLGİLER";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(28, 52);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(33, 20);
            this.namelabel.TabIndex = 0;
            this.namelabel.Text = "AD:";
            // 
            // surnamelabel
            // 
            this.surnamelabel.AutoSize = true;
            this.surnamelabel.Location = new System.Drawing.Point(28, 88);
            this.surnamelabel.Name = "surnamelabel";
            this.surnamelabel.Size = new System.Drawing.Size(59, 20);
            this.surnamelabel.TabIndex = 1;
            this.surnamelabel.Text = "SOYAD:";
            // 
            // citylabel
            // 
            this.citylabel.AutoSize = true;
            this.citylabel.Location = new System.Drawing.Point(28, 127);
            this.citylabel.Name = "citylabel";
            this.citylabel.Size = new System.Drawing.Size(52, 20);
            this.citylabel.TabIndex = 2;
            this.citylabel.Text = "ŞEHİR:";
            // 
            // birthdaylabel
            // 
            this.birthdaylabel.AutoSize = true;
            this.birthdaylabel.Location = new System.Drawing.Point(28, 168);
            this.birthdaylabel.Name = "birthdaylabel";
            this.birthdaylabel.Size = new System.Drawing.Size(67, 20);
            this.birthdaylabel.TabIndex = 3;
            this.birthdaylabel.Text = "DOĞUM:";
            // 
            // cinslabel
            // 
            this.cinslabel.AutoSize = true;
            this.cinslabel.Location = new System.Drawing.Point(28, 211);
            this.cinslabel.Name = "cinslabel";
            this.cinslabel.Size = new System.Drawing.Size(72, 20);
            this.cinslabel.TabIndex = 4;
            this.cinslabel.Text = "CİNSİYET:";
            // 
            // konumlabel
            // 
            this.konumlabel.AutoSize = true;
            this.konumlabel.Location = new System.Drawing.Point(28, 265);
            this.konumlabel.Name = "konumlabel";
            this.konumlabel.Size = new System.Drawing.Size(58, 20);
            this.konumlabel.TabIndex = 5;
            this.konumlabel.Text = "ADRES:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(235, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 150);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // hastalistbox
            // 
            this.hastalistbox.FormattingEnabled = true;
            this.hastalistbox.ItemHeight = 20;
            this.hastalistbox.Location = new System.Drawing.Point(500, 30);
            this.hastalistbox.Name = "hastalistbox";
            this.hastalistbox.Size = new System.Drawing.Size(283, 464);
            this.hastalistbox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 723);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button kaydetbutton;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
        private Button fotobutton;
        private Label fotolabel;
        private TextBox adrestextbox;
        private Label adreslabel;
        private Label cinsiyetlabel;
        private RadioButton erkekradiobutton;
        private RadioButton kadınradiobutton;
        private DateTimePicker dateTimePicker1;
        private Label dogumlabel;
        private ComboBox sehircombobox;
        private Label sehirlabel;
        private TextBox tctextbox;
        private Label tclabel;
        private TextBox soyadtextbox;
        private Label soyadlabel;
        private TextBox adtextbox;
        private Label adlabel;
        private FileSystemWatcher fileSystemWatcher1;
        private OpenFileDialog openFileDialog1;
        private GroupBox groupBox2;
        private ListBox hastalistbox;
        private PictureBox pictureBox2;
        private Label konumlabel;
        private Label cinslabel;
        private Label birthdaylabel;
        private Label citylabel;
        private Label surnamelabel;
        private Label namelabel;
    }
}