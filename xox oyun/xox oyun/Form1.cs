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
            //form ekran�nda t�m butonlar� se�tikten sonra �zelliklerde y�ld�r�m sembol�n�n alt�nda click 
            //��kacak o click t�m butonlar i�in ortak i�lem yap�cag�m�z kod blogunu a��yor xoxtiklama kod blogu o �ekilde a��ld�


        private void xoxtiklama(object sender, EventArgs e)//click tu�undan t�m tu�lar� ayn� i�leme ald�k.
        {
            Button bt = sender as Button;   //***bu kod formda hangi butona basarsak o butona x yazar***
            if (label1.Text == "X")   //eger s�rada bas�lmas� gereken tu� x ise o tu�u bast�r�r
            {
                bt.Text = "X";
                bt.Enabled = false; //bi tu�u iki kez bast�rmamas� i�in yazd�k.
                label1.Text = "O"; //s�ra O ya ge�ti
            }
            else
            {
                bt.Text = "O";
                bt.Enabled = false;
                label1.Text = "X";
            }
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X") //1. sat�r
            {
                MessageBox.Show("kazanan : X");
                oyunbitis();
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X") //2. sat�r
            {
                MessageBox.Show("kazanan : X");
                oyunbitis();
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X") //3. sat�r
            {
                MessageBox.Show("kazanan : X");
                oyunbitis();
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X") //dikey s�tunlar
            {
                MessageBox.Show("kazanan : X");
                oyunbitis();
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")//dikey 2. s�tun
            {
                MessageBox.Show("kazanan : X");
                oyunbitis();
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X") //dikey 3. s�tun
            {
                MessageBox.Show("kazanan : X");
                oyunbitis();
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X") //sol �stten �apraz a�a��
            {
                MessageBox.Show("kazanan : X");
                oyunbitis();
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X") //sa� �stten �apraz a�a��
            {
                MessageBox.Show("kazanan : X");
                oyunbitis();
            }


            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O") //1. sat�r o
            {
                MessageBox.Show("kazanan : O");
                oyunbitis();
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O") //2. sat�r
            {
                MessageBox.Show("kazanan : O");
                oyunbitis();
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O") //3. sat�r
            {
                MessageBox.Show("kazanan : O");
                oyunbitis();
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O") //dikey s�tunlar
            {
                MessageBox.Show("kazanan : O");
                oyunbitis();
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")//dikey 2. s�tun
            {
                MessageBox.Show("kazanan : O");
                oyunbitis();
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O") //dikey 3. s�tun
            {
                MessageBox.Show("kazanan : O");
                oyunbitis();
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O") //sol �stten �apraz a�a��
            {
                MessageBox.Show("kazanan : O");
                oyunbitis();
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O") //sa� �stten �apraz a�a��
            {
                MessageBox.Show("kazanan : O");
                oyunbitis();
            }

            if(button1.Text!=""&& button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                MessageBox.Show("BERABERE");  //beraberlik dueumu i�in yazd�g�m�z kod
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


