using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoMateTest
{
    public partial class frmMate : Form
    {

        Random aleatorio = new Random();

        int sumaUno;
        int sumaDos;
        
        int restaUno;
        int restaDos;

        int multiUno;
        int multiDos;

        int divUno;
        int divDos;

        int reloj = 0;
        public void Empezar()
        {
            sumaUno = aleatorio.Next(100);
            sumaDos = aleatorio.Next(100);

            restaUno = aleatorio.Next(1,101);
            restaDos = aleatorio.Next(1, restaUno);

            multiUno = aleatorio.Next(11); 
            multiDos = aleatorio.Next(11); 

            divUno = aleatorio.Next(10 ,30);
            divDos = aleatorio.Next(2, divUno);

            while (!(divUno%divDos== 0)) {

                divUno = aleatorio.Next(10, 30);
                divDos = aleatorio.Next(2, divUno);
            }


          


            lblIzquierdaSuma.Text = Convert.ToString(sumaUno);
            lblDerechaSuma.Text = Convert.ToString(sumaDos);

            lblIziquierdaResta.Text = Convert.ToString(restaUno);
            lblDerechaResta.Text = Convert.ToString(restaDos);

            lblIzquierdaMulti.Text = Convert.ToString(multiUno);
            lblDerechaMulti.Text = Convert.ToString(multiDos);

            lblIzquierdaDiv.Text = Convert.ToString(divUno);
            lblDerechaDiv.Text = Convert.ToString(divDos);

            nudSuma.Value = 0;
            reloj = 30;
            lblTiempo.ForeColor = Color.Black;
            lblTiempo.Text = "30 Segundos";
            timerTiempo.Start();
        }


        public frmMate()
        {
            InitializeComponent();
        }

   

        private void frmMate_Load(object sender, EventArgs e)
        {

        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            Empezar();
            btnEmpezar.Enabled = false;
        }

        private void timerTiempo_Tick(object sender, EventArgs e)
        {
            if (reloj > 0)
            {
                reloj -= 1;
                
                lblTiempo.Text = reloj + " Segundos";

                if (reloj <= 10)
                {
                    lblTiempo.ForeColor = Color.Orange;
                }

                if (ChequearRespuesta())
                {
                    timerTiempo.Stop();
                    MessageBox.Show("Respuestas correctas!");
                    btnEmpezar.Enabled = true;
                    lblTiempo.ForeColor = Color.Green;
                    nudSuma.ForeColor = Color.Green;
                    nudResta.ForeColor = Color.Green;
                    nudMulti.ForeColor = Color.Green;
                    nudDiv.ForeColor = Color.Green;

                }
            }

            else
            {
                timerTiempo.Stop();
                lblTiempo.Text = "0 Segundos";
                lblTiempo.ForeColor = Color.Red;
                MessageBox.Show("El tiempo se acabó");
                btnEmpezar.Enabled = true;
                
                lblTiempo.ForeColor = Color.Red;
                nudSuma.ForeColor = Color.Red;
                nudResta.ForeColor = Color.Red;
                nudMulti.ForeColor = Color.Red;
                nudDiv.ForeColor = Color.Red;
            }
        }


        private bool ChequearRespuesta()
        {
            if (sumaUno + sumaDos == nudSuma.Value && restaUno - restaDos == nudResta.Value &&
                multiUno * multiDos == nudMulti.Value && divUno / divDos == nudDiv.Value )
            {
                return true;
            }

            else
            {
                return false;
            }
        }

    }
}
