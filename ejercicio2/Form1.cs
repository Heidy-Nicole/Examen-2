using MySqlConnector;
using System.Data;
using System.Drawing;

namespace _6demayo
{
    public partial class Form1 : Form
    {
        int cR, cG, cB;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "archivos.jpg | *.jpg";
            openFileDialog1.ShowDialog();
            Bitmap bmp = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = bmp;
            Console.WriteLine(bmp.Width + " " + bmp.Height);

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Color c = new Color();
            /*   
          c = bmp.GetPixel(e.X, e.Y);
          textBox1.Text = c.R.ToString();
          textBox2.Text = c.G.ToString();
          textBox3.Text = c.B.ToString();
           // ESTE CODIGO DETECTA EL COLOR POR PIXEL
            */
            
            //ESTE CODIGO DETECTA EL CODIGO INCREMENTANDO 10 PIXELES
            int sR = 0; int sG = 0; int sB = 0;


            for (int i = e.X; i < e.X + 10; i++)
            {
                for (int j = e.Y; j < e.Y + 10; j++)
                {
                    c = bmp.GetPixel(i, j);
                    sR += c.R;
                    sG += c.G;
                    sB += c.B;
                }
            }

            sR /= 100; sG /= 100; sB /= 100;
            cR = sR;
            cG = sG;
            cB = sB;


            //textBox1.Text = c.R.ToString();
            //textBox2.Text = c.G.ToString();
            //textBox3.Text = c.B.ToString();
            textBox1.Text = sR.ToString();
            textBox2.Text = sG.ToString();
            textBox3.Text = sB.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
              
            Color c = new Color();
            Color c2 = new Color();

            for(int i = 0; i < bmp.Width; i++)
            {
                for(int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    bmp2.SetPixel(i, j, Color.FromArgb(c.R, c.G, c.B));
                }
            }

            //MessageBox.Show(dataGridView1.Rows.Count.ToString());

            for (int fila = 0; fila < dataGridView1.Rows.Count-1; fila++)
            {
                //MessageBox.Show(dataGridView1[0, i].Value.ToString());
                int pR = Convert.ToInt32(dataGridView1[1, fila].Value.ToString());
                int pG = Convert.ToInt32(dataGridView1[2, fila].Value.ToString());
                int pB = Convert.ToInt32(dataGridView1[3, fila].Value.ToString());

                int sR = Convert.ToInt32(dataGridView1[5, fila].Value.ToString());
                int sG = Convert.ToInt32(dataGridView1[6, fila].Value.ToString());
                int sB = Convert.ToInt32(dataGridView1[7, fila].Value.ToString());

                
                for(int i = 0; i < bmp.Width; i++)
                {
                    for(int j = 0; j < bmp.Height; j++)
                    {
                        c = bmp.GetPixel(i, j);
                        if(
                            (pR - 50 <= c.R && c.R <= pR + 50) && 
                            (pG - 50 <= c.G && c.G <= pG + 50) && 
                            (pB - 50 <= c.B && c.B <= pB + 50)) 
                        {

                            

                            bmp2.SetPixel(i, j, Color.FromArgb(sR, sG, sB));
                        }
                        else
                        {
                            c2 = bmp2.GetPixel(i, j);
                            bmp2.SetPixel(i, j, Color.FromArgb(c2.R, c2.G, c2.B));
                        }
                    }
                }

            }

            pictureBox1.Image = bmp2;
            MessageBox.Show("Imagen modificada correctamente.");

            /*
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    if (((134 <= c.R) && (c.R <= 180)) &&
                        ((200 <= c.G) && (c.G <= 230)) &&
                        ((200 <= c.B) && (c.B <= 250)))
                    {
                        bmp2.SetPixel(i, j, Color.Black);
                    }
                    else
                    {
                        bmp2.SetPixel(i, j, Color.FromArgb(c.R, c.G, c.B));
                    }
                }
            }
            pictureBox1.Image = bmp2;
            */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);

            Color c = new Color();
            Color c2 = new Color();

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    bmp2.SetPixel(i, j, Color.FromArgb(c.R, c.G, c.B));
                }
            }



            string res = "CAMBIOS REALIZADOS\n";
            for (int fila = 0; fila < dataGridView1.Rows.Count - 1; fila++)
            {
                //MessageBox.Show(dataGridView1[0, i].Value.ToString());
                cR = Convert.ToInt32(dataGridView1[1, fila].Value.ToString());
                cG = Convert.ToInt32(dataGridView1[2, fila].Value.ToString());
                cB = Convert.ToInt32(dataGridView1[3, fila].Value.ToString());

                int tR = Convert.ToInt32(dataGridView1[5, fila].Value.ToString());
                int tG = Convert.ToInt32(dataGridView1[6, fila].Value.ToString());
                int tB = Convert.ToInt32(dataGridView1[7, fila].Value.ToString());

                
                //MessageBox.Show(dataGridView1[0, fila].Value.ToString() + " " + dataGridView1[4, fila].Value.ToString());

                bool sw = false;

                for (int i = 0; i < bmp.Width - 10; i = i + 10)
                {
                    for (int j = 0; j < bmp.Height - 10; j = j + 10)
                    {
                        int sR = 0; int sG = 0; int sB = 0;

                        for (int ip = i; ip < i + 10; ip++)
                        {
                            for (int jp = j; jp < j + 10; jp++)
                            {
                                c = bmp.GetPixel(ip, jp);
                                sR += c.R;
                                sG += c.G;
                                sB += c.B;
                            }
                        }

                        sR /= 100; sG /= 100; sB /= 100;
                        //MessageBox.Show(sR.ToString() + " " + sG.ToString() + " " + sB.ToString() + "-----" + cR.ToString() + " " + cB.ToString() + " " + cG.ToString());
                        if (((cR - 50 <= sR) && (sR <= cR + 50)) &&
                            ((cG - 50 <= sG) && (sG <= cG + 50)) &&
                            ((cB - 50 <= sB) && (sB <= cB + 50)))
                        {
                            //MessageBox.Show(sR.ToString() + " " + sG.ToString() + " " + sB.ToString() + " " + dataGridView1[4, fila].Value.ToString());
                            for (int ip = i; ip < i + 10; ip++)
                            {

                                for (int jp = j; jp < j + 10; jp++)
                                {

                                    bmp2.SetPixel(ip, jp, Color.FromArgb(tR, tG, tB));
                                    pictureBox1.Image = bmp2;

                                    

                                }
                            }
                            sw = true;
                            
                        }
                        else
                        {
                            for (int ip = i; ip < i + 10; ip++)
                            {
                                for (int jp = j; jp < j + 10; jp++)
                                {
                                    c2 = bmp2.GetPixel(ip, jp);
                                    bmp2.SetPixel(ip, jp, Color.FromArgb(c2.R, c2.G, c2.B));
                                }
                            }

                        }
                    }
                }
                
                if(sw)
                    res += "Se cambio " + dataGridView1[0, fila].Value.ToString() + " por " + dataGridView1[4, fila].Value.ToString() + "\n";

            }
            pictureBox1.Image = bmp2;
            label6.Text = res;
            MessageBox.Show("Imagen modificada correctamente.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Recolectar los valores de los TextBox para la inserción
                string descripcion = textBox4.Text;
                int cR = int.Parse(textBox1.Text);
                int cG = int.Parse(textBox2.Text);
                int cB = int.Parse(textBox3.Text);
                string hex = textBox5.Text;

                // Cadena de conexión a la base de datos
                string connectionString = "server=localhost;user=root;password=;database=academico";

                // Crear una nueva conexión
                MySqlConnection conexionBD = new MySqlConnection(connectionString);

                // Abrir la conexión
                conexionBD.Open();

                // Consulta SQL para la inserción
                string query = @"INSERT INTO texturas (descripcion, cR, cG, cB, colorpintar) 
                     VALUES (@descripcion, @cR, @cG, @cB, @colorpintar)";

                // Crear un comando para ejecutar la consulta
                MySqlCommand comando = new MySqlCommand(query, conexionBD);

                // Asignar parámetros a la consulta
                comando.Parameters.AddWithValue("@descripcion", descripcion);
                comando.Parameters.AddWithValue("@cR", cR);
                comando.Parameters.AddWithValue("@cG", cG);
                comando.Parameters.AddWithValue("@cB", cB);
                comando.Parameters.AddWithValue("@colorpintar", hex);

                // Ejecutar la consulta
                comando.ExecuteNonQuery();

                MessageBox.Show("Datos insertados correctamente.");

                // Cerrar la conexión
                conexionBD.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Los valores de R, G y B deben ser números enteros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cadena de conexión a la base de datos
            string connectionString = "server=localhost;user=root;password=;database=texturas";

            // Crear una nueva conexión
            MySqlConnection conexionBD = new MySqlConnection(connectionString);

            try
            {
                // Abrir la conexión
                conexionBD.Open();

                MessageBox.Show("Conexión establecida con éxito.");


                string query = @"select * from texturas";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexionBD);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Asignar la tabla al control DataGridView (tablaTexturas)
                dataGridView1.DataSource = dataTable;


                // Cerrar la conexión
                conexionBD.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
