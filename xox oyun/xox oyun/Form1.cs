namespace xox_oyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
            //form ekranýnda tüm butonlarý seçtikten sonra özelliklerde yýldýrým sembolünün altýnda click 
            //çýkacak o click tüm butonlar için ortak iþlem yapýcagýmýz kod blogunu açýyor xoxtiklama kod blogu o þekilde açýldý


        private void xoxtiklama(object sender, EventArgs e)//click tuþundan tüm tuþlarý ayný iþleme aldýk.
        {
            Button bt = sender as Button;   //***bu kod formda hangi butona basarsak o butona x yazar***
            if (label1.Text == "X")   //eger sýrada basýlmasý gereken tuþ x ise o tuþu bastýrýr
            {
                bt.Text = "X";
                bt.Enabled = false; //bi tuþu iki kez bastýrmamasý için yazdýk.
                label1.Text = "O"; //sýra O ya geçti
            }
            else
            {
                bt.Text = "O";
                bt.Enabled = false;
                label1.Text = "X";
            }
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X") //1. satýr
            {
                MessageBox.Show("kazanan : X");
                oyunbitis();
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X") //2. satýr
            {
                MessageBox.Show("kazanan : X");
                oyunbitis();
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X") //3. satýr
            {
                MessageBox.Show("kazanan : X");
                oyunbitis();
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X") //dikey sütunlar
            {
                MessageBox.Show("kazanan : X");
                oyunbitis();
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")//dikey 2. sütun
            {
                MessageBox.Show("kazanan : X");
                oyunbitis();
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X") //dikey 3. sütun
            {
                MessageBox.Show("kazanan : X");
                oyunbitis();
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X") //sol üstten çapraz aþaðý
            {
                MessageBox.Show("kazanan : X");
                oyunbitis();
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X") //sað üstten çapraz aþaðý
            {
                MessageBox.Show("kazanan : X");
                oyunbitis();
            }


            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O") //1. satýr o
            {
                MessageBox.Show("kazanan : O");
                oyunbitis();
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O") //2. satýr
            {
                MessageBox.Show("kazanan : O");
                oyunbitis();
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O") //3. satýr
            {
                MessageBox.Show("kazanan : O");
                oyunbitis();
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O") //dikey sütunlar
            {
                MessageBox.Show("kazanan : O");
                oyunbitis();
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")//dikey 2. sütun
            {
                MessageBox.Show("kazanan : O");
                oyunbitis();
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O") //dikey 3. sütun
            {
                MessageBox.Show("kazanan : O");
                oyunbitis();
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O") //sol üstten çapraz aþaðý
            {
                MessageBox.Show("kazanan : O");
                oyunbitis();
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O") //sað üstten çapraz aþaðý
            {
                MessageBox.Show("kazanan : O");
                oyunbitis();
            }

            if(button1.Text!=""&& button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                MessageBox.Show("BERABERE");  //beraberlik dueumu için yazdýgýmýz kod
                oyunbitis();
            }


        }
        private void oyunbitis()
        {
            label1.Text = "X";
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;


        }
    }

}


