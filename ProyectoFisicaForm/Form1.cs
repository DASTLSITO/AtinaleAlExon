namespace ProyectoFisicaForm
{
    public partial class Form1 : Form
    {
        float posicionX = 0;
        float posicionY = 0;
        float fuerza = 0;
        float masa = 0;
        float angulo = 0;
        float gravedad = 9.81f;
        float aceleracion = 0;
        float aceleracionX = 0;
        float aceleracionY = 0;
        float tiempo = 0;

        float posiciónXColision = 0;
        float posiciónYColision = 0;

        bool ejecutar = true;

        int puntos = 0;
        Pen pen = new Pen(Color.Black);

        Graphics g;

        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            var scrollBar = sender as ScrollBar;
            pictureBox1.Location = new Point(scrollBar.Value, vsbPosicion.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hScrollBar4_Scroll(object sender, ScrollEventArgs e)
        {
            var tb = sender as HScrollBar;
            label5.Text = $"Ángulo del tiro: {tb.Value}°";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ObtenerParametros();
        }

        public async Task ObtenerParametros()
        {
            button1.Enabled = false;
            ejecutar = true;
            angulo = hsbAngulo.Value;
            fuerza = hsbFuerzaInicial.Value;
            masa = hsbMasa.Value;


            angulo = (float)(angulo * Math.PI / 180);
            aceleracion = fuerza / masa;
            aceleracionX = (float)(aceleracion * Math.Cos(angulo));
            aceleracionY = (float)(aceleracion * Math.Sin(angulo));

            tiempo = 0;

            await LanzarPelota(angulo, fuerza, masa, aceleracion, aceleracionX, aceleracionY);

            button1.Enabled = true;

            if (puntos == 48)
            {
                ejecutar = false;
                MessageBox.Show("Has ganado, eres muy bueno >:)", "Felicidades, ganaste :D", MessageBoxButtons.OK);
                Application.Exit();
            }
        }

        public async Task LanzarPelota
            (float angulo, float fuerza, float masa, float aceleracion, float aceleracionX, float aceleracionY)
        {
            g.Clear(Color.FromArgb(255, 246, 220));


            posicionX = aceleracionX * tiempo;
            posicionY = (float)((aceleracionY * tiempo) - (gravedad * tiempo * tiempo) / 2);
            tiempo += 0.25f;

            g.DrawEllipse(pen, posicionX, 340 - posicionY, 40, 40);

            if (((posicionX >= pictureBox1.Location.X && posicionX <= pictureBox1.Location.X + pictureBox1.Size.Width) &&
                ((340 - posicionY) >= pictureBox1.Location.Y && (340 - posicionY) <= pictureBox1.Location.Y + pictureBox1.Size.Height)) ||
                ((posicionX >= pictureBox1.Location.X && posicionX <= pictureBox1.Location.X + pictureBox1.Size.Width) &&
                ((300 - posicionY) >= pictureBox1.Location.Y && (300 - posicionY) <= pictureBox1.Location.Y + pictureBox1.Size.Height)))
            {
                puntos++;
                label4.Text = $"Puntos: {puntos}";
                ejecutar = false;
                pictureBox1.Size = new Size(pictureBox1.Size.Width, pictureBox1.Size.Height + 5);
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 5);
            }

            await Task.Delay(16);
            if (!(340 - posicionY >= 358 || posicionX >= 901) && ejecutar)
            {
                await LanzarPelota(angulo, fuerza, masa, aceleracion, aceleracionX, aceleracionY);
                vsbPosicion.Maximum = 355 - pictureBox1.Size.Height;
                g.Clear(Color.FromArgb(255, 246, 220));
            }
        }

        private void hsbFuerzaInicial_Scroll(object sender, ScrollEventArgs e)
        {
            var tb = sender as HScrollBar;
            label2.Text = $"Fuerza inicial: {tb.Value}";
        }

        private void hsbMasa_Scroll(object sender, ScrollEventArgs e)
        {
            var tb = sender as HScrollBar;
            label3.Text = $"Peso del objeto: {tb.Value}";
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            var scrollBar = sender as ScrollBar;
            pictureBox1.Location = new Point(hsbPosicion.Value, scrollBar.Value);
        }
    }
}