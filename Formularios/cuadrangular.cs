using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Geometria_por_KAML.Formularios
{
    public partial class cuadrangular : Form
    {
        public cuadrangular()
        {
            InitializeComponent();
        }
        //boton de salida, sale del proceso del formulario

        private void salida_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// determinando las actividades de los checkbuttons 
        /// para declarar las acciones que lleva seleccionar un boton
        // general
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                a.Enabled = false;
                v.Enabled = false;
            }
            else
            {
                habilitado();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                l.Enabled = false;
                v.Enabled = false;
            }
            else
            {
                habilitado();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                h.Enabled = false;
                v.Enabled = false;
            }
            else
            {
                habilitado();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox5.Enabled = false;
                l.Enabled = false;
                a.Enabled = false;
            }
            else
            {
                habilitado();
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox4.Enabled = false;
                checkBox3.Enabled = false;
                h.Enabled = false;
                a.Enabled = false;
            }
            else
            {
                habilitado();
            }
        }
        //
        //
        // boton de calcular
        //
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                /// VALIDACIONES
                //cuidando espacios vacios
                if ((h.Text == "") || (l.Text == ""))
                {
                    MessageBox.Show("\n Error", "no a ingresado los datos necesarios para el calculo");
                    l.Focus();
                    return;
                }
                // validacion de datos
                // confirmacion de que los datos que ingresa el usuario son numericos
                double c1, c2;
                bool ry = Double.TryParse(l.Text, out c1);
                if (ry == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    l.Text = "";
                    h.Text = "";
                    l.Focus();
                    return;
                }
                bool cy = Double.TryParse(h.Text, out c2);
                if (cy == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    h.Text = "";
                    l.Text = "";
                    h.Focus();
                    return;
                }

                // procedimientos
                volumenx();
                areax();
            }
            else if (checkBox2.Checked == true)
            {
                /// VALIDACIONES
                //cuidando que se ingresen ambos datos necesarios
                if ((h.Text == "") || (a.Text == ""))
                {
                    MessageBox.Show("\n Error", "no a ingresado los datos necesarios para el calculo");
                    h.Focus();
                    return;
                }
                // evitando items que no son numericos
                double c1, c2;
                bool ry = Double.TryParse(h.Text, out c1);
                if (ry == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    h.Text = "";
                    a.Text = "";
                    h.Focus();
                    return;
                }
                bool cy = Double.TryParse(a.Text, out c2);
                if (cy == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    a.Text = "";
                    h.Text = "";
                    a.Focus();
                    return;
                }
                //procedimientos
                ladoa();
                volumenx();

           
            }
            else if (checkBox3.Checked == true)
            {
                /// VALIDACIONES
                //cuidando que se ingresen ambos datos necesarios
                if ((a.Text == "") || (l.Text == ""))
                {
                    MessageBox.Show("\n Error", "no a ingresado los datos necesarios para el calculo");
                    l.Focus();
                    return;
                }
                // verificando que no ingresen datos de texto
                double c1, c2;
                bool ry = Double.TryParse(l.Text, out c1);
                if (ry == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    l.Text = "";
                    a.Text = "";
                    l.Focus();
                    return;
                }
                bool cy = Double.TryParse(a.Text, out c2);
                if (cy == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    l.Text = "";
                    a.Text = "";
                    l.Focus();
                    return;
                }
                // procedimientos 
                altura_a();
                volumenx();
            }
            else if (checkBox4.Checked == true)
            {
                /// VALIDACIONES
                //cuidando que se ingresen ambos datos necesarios
                if ((h.Text == "") || (v.Text == ""))
                {
                    MessageBox.Show("\n Error", "no a ingresado los datos necesarios para el calculo");
                    h.Focus();
                    return;
                }
                // verificando que no se ingresen datos de texto
                double c1, c2;
                bool ry = Double.TryParse(h.Text, out c1);
                if (ry == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    h.Text = "";
                    v.Text = "";
                    h.Focus();
                    return;
                }
                bool cy = Double.TryParse(v.Text, out c2);
                if (cy == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    v.Text = "";
                    l.Text = "";
                    v.Focus();
                    return;
                }
                //procedimientos
                ladov();
                areax();

            }
            else if (checkBox5.Checked == true)
            {
                /// VALIDACIONES
                //cuidando que se ingresen ambos datos necesarios
                if ((l.Text == "") || (v.Text == ""))
                {
                    MessageBox.Show("\n Error", "no a ingresado los datos necesarios para el calculo");
                    l.Focus();
                    return;
                }
                // evintando el ingreso de datos no numericos
                double c1, c2;
                bool ry = Double.TryParse(l.Text, out c1);
                if (ry == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    l.Text = "";
                    v.Text = "";
                    v.Focus();
                    return;
                }
                bool cy = Double.TryParse(v.Text, out c2);
                if (cy == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    v.Text = "";
                    l.Text = "";
                    v.Focus();
                    return;
                }
                // procedimietos 
                alturax();
                areax();
            }
        }
        //
        //
        //boton de NUEVO
        //
        //
        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        /// voids para los calculos correspondientes, segun el checkbox seleccionado
        /// voids publicos y privados privados 
        /// //
    

        // metodo para checkbox
        private void habilitado()
        {
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
            checkBox5.Enabled = true;
            l.Enabled = true;
            h.Enabled = true;
            a.Enabled = true;
            v.Enabled = true;
        }


        /// 
        /// void para limpieza 
        public void limpiar()
        {
            // dejar sin checkear los radiobuttons
            var sentencelist = groupBox1.Controls.OfType<CheckBox>().ToList();
            foreach (var radio in sentencelist)
            {
                radio.Checked = false;
            }
            l.Text = "";
            h.Text = "";
            a.Text = "";
            v.Text = "";
            groupBox1.Focus();
        }

        //variables para los calculos 
        double lado, altura, volumen, area;
        //
        //
        //void para calculo del volumen
        public void volumenx()
        {
            double vtot;
            lado = Convert.ToDouble(l.Text);
            altura = Convert.ToDouble(h.Text);
            //procedimiento
            vtot = Math.Pow(lado, 2) * altura;
           double volument = Math.Round(vtot, 2);    
            v.Text = volument.ToString();
        }
        //
        //
        //void para calculo del area
        public void areax()
        {
            double atot;
            lado = Convert.ToDouble(l.Text);
            altura = Convert.ToDouble(h.Text);
            //procedimiento
            atot = (2*lado)*(lado+(2*altura));
            double areat = Math.Round(atot, 2);
            a.Text = areat.ToString();
        }
        //
        // void para calculo de el lado en base del volumen
        public void ladov()
        {
            double ladtot;
            volumen = Convert.ToDouble(v.Text);
            altura = Convert.ToDouble(h.Text);
            //procedimiento 
            ladtot = Math.Sqrt(volumen / altura);
            double ladot = Math.Round(ladtot,2); 
            //mostrar en pantalla
            l.Text = ladot.ToString();
        }
        // 
        // void para el calculo de el lado en base del area 
        public void ladoa()
        {
            double ladotota;
            area = Convert.ToDouble(a.Text);
            altura = Convert.ToDouble(h.Text);
            //procedimiento 
            ladotota = Math.Sqrt(area / altura);
            double ladtotal= Math.Round(ladotota);
            //mostrar en pantalla 
            l.Text = ladtotal.ToString();
        }
        //
        //
        //void para calculo de la altura en base del volumen 
        public void alturax()
        {
            double alttot;
            lado = Convert.ToDouble(l.Text);
            volumen = Convert.ToDouble(v.Text);
            // procedimiento
            alttot = volumen / Math.Pow(lado, 2);
            double alturat = Math.Round(alttot, 2);
            // mostrar en pantalla
            h.Text = alturat.ToString();
        }
        // 
        //
        // void para el calculo de la altura en base del area
        public void altura_a()
        {
            double alturatot;
            lado = Convert.ToDouble(l.Text);
            area = Convert.ToDouble(a.Text);
            //procedimiento
            alturatot = (area - (Math.Pow(lado, 2) * 2)) / 4;
            double totalt = alturatot / lado;
            double altotal =Math.Round(totalt, 2);
            //mostrar en pantalla
            h.Text = altotal.ToString();
        }
    }
}