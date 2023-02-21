namespace u2_1_formas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (rbtn1.Checked)
            {
                String nombre = txtNombre.Text;
                lblNombre.Text = nombre;
            }

            chBox1.Checked = !chBox1.Checked;

            Graphics papel = pictureBox1.CreateGraphics();
            Pen lapiz = new Pen(Color.Black);
            papel.DrawRectangle(lapiz, 10, 10, 100, 50);
            papel.
            /*
             * Line
             * Ellipse
             * FillEllipse
             */
        }

        
    }
}