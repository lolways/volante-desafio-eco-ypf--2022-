namespace Dashboard
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            ampers.Increment(1); 
        }

        private void but_Click(object sender, EventArgs e)
        {
            ampers.Value = 0;
                timer1.Start();
           
        }
    }
}