using System;
using System.Windows.Forms;

namespace stoper
{
    public partial class Form1 : Form
    {
        double czasodpoczatku = 0;
        double rekordczas = double.MaxValue;

        private string PokazCzas(double czas)
        {
            int godziny, minuty;
            double pomocnicza = czas;
            godziny = (int) (pomocnicza / 3600);
            pomocnicza -= godziny * 3600;
            minuty = (int) (pomocnicza / 60);
            pomocnicza -= minuty * 60;
            return godziny.ToString("00") + ":" + minuty.ToString("00") + ":" + pomocnicza.ToString("00.00");
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            czasodpoczatku += .01;
            licznik.Text = PokazCzas(czasodpoczatku);
        }

        private void off_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void start_Click(object sender, EventArgs e)
        { 
            if (start.Text == "START")
            {
                start.Text = "STOP";
                timer.Start();
            }
            else
            {
                start.Text = "START";
                timer.Stop();
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            timer.Stop();
            start.Text = "START";
            if (rekordczas > czasodpoczatku)
            {
                rekord.Text = PokazCzas(czasodpoczatku);
                rekordczas = czasodpoczatku;
            }
            czasodpoczatku = 0;
            licznik.Text = PokazCzas(czasodpoczatku);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //background photo = https://www.pexels.com/pl-pl/zdjecie/blac-blue-and-green-digital-wallpaepr-3374210/
    }
}
