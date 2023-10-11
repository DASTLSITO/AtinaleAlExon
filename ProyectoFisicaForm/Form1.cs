namespace ProyectoFisicaForm
{
    public partial class Form1 : Form
    {
        float posicionX = 0;
        float posicionY = 0;
        float fuerza = 0;
        float masa = 0;
        float angulo = 0;
        float aceleracionInicial = 0;
        float aceleracionX = 0;
        float aceleracionY = 9.81f;
        float velocidadInicial = 0;
        float velocidadX = 0;
        float velocidadY = 0;
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

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tiempo = 0;
            ObtenerParametros();
            button1.Enabled = true;
        }

        public async Task ObtenerParametros()
        {
            ejecutar = true;
            angulo = Convert.ToInt32(nudAngulo.Value);
            fuerza = Convert.ToInt32(nudFuerza.Value);
            masa = Convert.ToInt32(nudPeso.Value);


            angulo = (float)(angulo * Math.PI / 180);
            aceleracionInicial = fuerza / masa;
            aceleracionX = (float)(aceleracionInicial * Math.Cos(angulo));
            velocidadX = aceleracionX;
            velocidadX = (float)(velocidadX * Math.Cos(angulo));
            velocidadY = (float)((aceleracionInicial * Math.Sin(angulo)) - aceleracionY*tiempo);

            await LanzarPelota();

            ComprobarPuntos();
        }

        public async Task LanzarPelota()
        {
            g.Clear(Color.FromArgb(255, 246, 220));

            ObtenerPosicionDeLaPelota();

            g.DrawEllipse(pen, posicionX, 340 - posicionY, 40, 40);
            
            ComprobarPosicionEnElObjetivo();

            await Task.Delay(8);
            if (!(340 - posicionY >= 362 || posicionX >= 901) && ejecutar)
            {
                await ObtenerParametros();
                vsbPosicion.Maximum = 355 - pictureBox1.Size.Height;
                g.Clear(Color.FromArgb(255, 246, 220));
            }
        }

        public void ComprobarPuntos()
        {
            if (puntos == 48)
            {
                ejecutar = false;
                MessageBox.Show("Has ganado, eres muy bueno >:)", "Felicidades, ganaste :D", MessageBoxButtons.OK);
                Application.Exit();
            }
        }

        public void ObtenerPosicionDeLaPelota()
        {
            posicionX = velocidadX * tiempo;
            posicionY = (float)((velocidadY * tiempo) - (aceleracionY * tiempo * tiempo) / 2);
            tiempo += 0.125f;
        }

        public void ComprobarPosicionEnElObjetivo()
        {
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
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            var scrollBar = sender as ScrollBar;
            pictureBox1.Location = new Point(scrollBar.Value, vsbPosicion.Value);
        }

        private void vsbPosicion_Scroll(object sender, ScrollEventArgs e)
        {
            var scrollBar = sender as ScrollBar;
            pictureBox1.Location = new Point(hsbPosicion.Value, scrollBar.Value);
        }
    }
}