namespace cafesiparisuygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cayartıbutton_Click(object sender, EventArgs e)
        {
           int caysayisi = Convert.ToInt32(caysayisilabel.Text);
           caysayisi++;
           caysayisilabel.Text = Convert.ToString(caysayisi);
         }
 

        private void cayeksibutton_Click(object sender, EventArgs e)
        {
            int caysayisi = Convert.ToInt32(caysayisilabel.Text);
            if(caysayisi > 0)
            {
            caysayisi--;
            caysayisilabel.Text = Convert.ToString(caysayisi);
            }
            
        }

        private void kahveartıbutton_Click(object sender, EventArgs e)
        {
            int kahvesayisi = Convert.ToInt32(kahvesayisilabel.Text);
            kahvesayisi++;
            kahvesayisilabel.Text = Convert.ToString(kahvesayisi);
        }

        private void kahveeksibutton_Click(object sender, EventArgs e)
        {
            int kahvesayisi = Convert.ToInt32(kahvesayisilabel.Text);
            if (kahvesayisi > 0)
            {
            kahvesayisi--;
            kahvesayisilabel.Text = Convert.ToString(kahvesayisi);
            }
        }

        private void kolartıbutton_Click(object sender, EventArgs e)
        {
            int kolasayisi = Convert.ToInt32(kolasayisilabel.Text);
            kolasayisi++;
            kolasayisilabel.Text = Convert.ToString(kolasayisi);
        }

        private void kolaeksibutton_Click(object sender, EventArgs e)
        {
            int kolasayisi = Convert.ToInt32(kolasayisilabel.Text);
            if (kolasayisi > 0)
            {
            kolasayisi--;
            kolasayisilabel.Text = Convert.ToString(kolasayisi);
            }
        }

        private void button5_Click(object sender, EventArgs e)//SIFIRLAMA BUTONU*********
        {
            caysayisilabel.Text="0";
            kahvesayisilabel.Text="0";
            kolasayisilabel.Text="0";
            siparislistbox.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)//SİPARİŞİ TAMAMLA BUTONU
        {
            MessageBox.Show("SİPARİŞİ TAMAMLADINIZ:" + caysayisilabel.Text +"ÇAY -" + kahvesayisilabel.Text + "KAHVE -" + kolasayisilabel.Text +"KOLA" );
            siparislistbox.Items.Add("ÇAY " + caysayisilabel.Text +" ADET");
            siparislistbox.Items.Add("KAHVE "+ kahvesayisilabel.Text + " ADET");
            siparislistbox.Items.Add("KOLA " + kolasayisilabel.Text + " ADET");        
        }

        private void siparislistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}