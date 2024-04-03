namespace pryanyanyin
{
    public partial class Form1 : Form
    {
        private Bitmap imagen;
        public Form1()
        {
            InitializeComponent();

            imagen = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                using (Graphics objetoLoco = Graphics.FromImage(imagen))
                {
                    objetoLoco.FillEllipse(Brushes.Blue, e.X, e.Y, 5, 5);
                }

                pictureBox1.Image = imagen;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Imagen Guardada con éxito");

            {
                imagen.Save("caca.png", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }
    }
}