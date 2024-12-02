namespace Lines_and_Boxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CircleButton circleButton = new CircleButton();
            this.Controls.Add(circleButton);
        }
    }
}
