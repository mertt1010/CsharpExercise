namespace hastakayıt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked== true)
            {
                kaydet();
            }
        }

        private void adtextbox_TextChanged(object sender, EventArgs e)
        {
            adtextbox.Text = Convert.ToString(adtextbox.Text);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void kaydetbutton_Click(object sender, EventArgs e)
        {
           kaydet();
        }

        private void fotobutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectpicture = new OpenFileDialog(); //dosya seçme komutu
            if(selectpicture.ShowDialog()== System.Windows.Forms.DialogResult.OK) //dosya seçme ekranı açıldı
            {
                Image image = Image.FromFile(selectpicture.FileName); //
                pictureBox1.Image = image; // fotografı picture boxın içine koyduk
            }
        }

        private void soyadtextbox_TextChanged(object sender, EventArgs e)
        {
            soyadtextbox.Text = Convert.ToString(soyadtextbox.Text);
        }

        private void tctextbox_TextChanged(object sender, EventArgs e)
        {
            tctextbox.Text = Convert.ToString(tctextbox.Text);
        }

        private void sehircombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sehircombobox.Text = Convert.ToString(sehircombobox.Text);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Text = Convert.ToString(dateTimePicker1.Text);
        }

        private void kadınradiobutton_CheckedChanged(object sender, EventArgs e)
        {
            if (kadınradiobutton.Checked)
            {
                cinsiyetlabel.Text = Convert.ToString("kadın");
            }
        }

        private void erkekradiobutton_CheckedChanged(object sender, EventArgs e)
        {
            if (erkekradiobutton.Checked)
            {
                cinsiyetlabel.Text = Convert.ToString("ERKEK");
            }
        }

        private void adrestextbox_TextChanged(object sender, EventArgs e)
        {
            adrestextbox.Text=Convert.ToString(adrestextbox.Text);
        }
        public void kaydet()
        {
            namelabel.Text = "ad: " + adtextbox;
            surnamelabel.Text = "soyad: " + soyadtextbox;
            citylabel.Text = "sehir: " + sehircombobox;
            birthdaylabel.Text = "dogum: " + dateTimePicker1;
            cinslabel.Text = "cinsiyet: " + cinsiyetlabel;
            konumlabel.Text = "adres: " + adrestextbox;


            hastalistbox.Items.Add("ad: " + adtextbox);
            hastalistbox.Items.Add("soyad: " + soyadtextbox);
            hastalistbox.Items.Add("sehir: " + sehircombobox);
            hastalistbox.Items.Add("cinisyet: " + cinsiyetlabel);
            hastalistbox.Items.Add("adres: " + adrestextbox);
        }
    }
}