using Timer = System.Windows.Forms.Timer;

namespace London_Baku
{
    public partial class Form1 : Form
    {
        string watch = "baku";
        public Form1()
        {

            InitializeComponent();
            Timer timer = new();
            timer.Interval= 1000;
            timer.Tick +=Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (watch == "baku")
                Text = DateTime.Now.ToLongTimeString();
            else if(watch == "london")
                Text = DateTime.UtcNow.ToLongTimeString();
        }

        private void btn_Baku_MouseClick(object sender, MouseEventArgs e)
        {
            watch = "baku";
            BackgroundImage = Properties.Resources._240_F_231148604_0hQFi09fYKlV0J7jnBVCIFR8sTCOI3J9;
        }

        private void btn_London_MouseClick(object sender, MouseEventArgs e)
        {
            watch = "london";
            BackgroundImage = Properties.Resources.London_city;
        }

        private void btn_Run_MouseHover(object sender, EventArgs e)
        {
            var rnd = new Random(); 
            btn_Run.Location = new Point(rnd.Next(0,Size.Width /2), rnd.Next(Size.Height /2));
        }
    }
}