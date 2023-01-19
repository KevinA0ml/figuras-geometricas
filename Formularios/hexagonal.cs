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
    public partial class hexagonal : Form
    {
        public hexagonal()
        {
            InitializeComponent();
        }
        // boton de salida, sale del proceso del formulario
        private void salida_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// determinando las actividades de los checkbuttons 
        /// para validar las acciones que lleva seleccionar un boton
        //
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (general.Checked == true)
            {
                ladovolumen.Enabled = false;
                alturavolumen.Enabled = false;
                apotemavolumen.Enabled=false;
                ladoarea.Enabled = false;
                alturaarea.Enabled = false;
                apotemaarea.Enabled = false;
                a.Enabled = false;
                v.Enabled = false;
            }
            else
            {
                habilitado();
            }
        }
        private void apotemavolumen_CheckedChanged(object sender, EventArgs e)
        {
            if (apotemavolumen.Checked == true)
            {
                ladovolumen.Enabled = false;
                alturavolumen.Enabled = false;
                apotemaarea.Enabled = false;
                ladoarea.Enabled = false;
                alturaarea.Enabled = false;
                general.Enabled = false;
                ap.Enabled = false;
                v.Enabled = false;
            }
            else
            {
                habilitado();
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (ladovolumen.Checked == true)
            {
                general.Enabled = false;
                alturavolumen.Enabled = false;
                ladoarea.Enabled = false;
                alturaarea.Enabled = false;
                apotemavolumen.Enabled = false;
                apotemaarea.Enabled = false;
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
            if (alturavolumen.Checked == true)
            {
                general.Enabled = false;
                ladovolumen.Enabled = false;
                ladoarea.Enabled = false;
                alturaarea.Enabled = false;
                apotemavolumen.Enabled = false;
                apotemaarea.Enabled = false;
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
            if (ladoarea.Checked == true)
            {
                general.Enabled = false;
                ladovolumen.Enabled = false;
                alturavolumen.Enabled = false;
                alturaarea.Enabled = false;
                apotemaarea.Enabled = false;
                apotemavolumen.Enabled = false;
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
            if (alturaarea.Checked == true)
            {
                general.Enabled = false;
                ladovolumen.Enabled = false;
                ladoarea.Enabled = false;
                alturavolumen.Enabled = false;
                apotemavolumen.Enabled = false;
                apotemaarea.Enabled = false;
                h.Enabled = false;
                a.Enabled = false;
            }
            else
            {
                habilitado();
            }
        }
        private void apotemaarea_CheckedChanged(object sender, EventArgs e)
        {
            if (apotemaarea.Checked == true)
            {
                general.Enabled = false;
                ladovolumen.Enabled = false;
                ladoarea.Enabled = false;
                alturavolumen.Enabled = false;
                apotemavolumen.Enabled = false;
                alturaarea.Enabled = false;
                ap.Enabled = false;
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
        //
        private void button1_Click(object sender, EventArgs e)
        {
            // variables para la validacion de datos numericos
            double c1, c2 , c3, c4, c5;
            // nombrar variables
            double lado1, altura1, volumen1, apotema1, area1;
            // condicion if para ejecutar el proceso seleccionado segun los checkbox
            //
            if (general.Checked == true)
            {
                // validar que no se ingrese ningun texto a los textbox
                bool ry = Double.TryParse(l.Text, out c1);
                if (ry == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    l.Text = "";
                    l.Focus();
                    return;
                }
                bool cy = Double.TryParse(h.Text, out c2);
                if (cy == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    h.Text = "";
                    h.Focus();
                    return;
                }

                bool gy = Double.TryParse(ap.Text, out c3);
                if (gy == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    ap.Text = "";
                    ap.Focus();
                    return;
                }
                /// VALIDACIONES
                //cuidando que se ingresen ambos datos necesarios
                if ((h.Text == "") || (l.Text == "")||(ap.Text ==""))
                {
                    MessageBox.Show("\n Error", "no a ingresado los datos necesarios para el calculo");
                    l.Focus();
                    return;
                }
                //procedimiento
                lado1 = Convert.ToDouble(l.Text);
                altura1 = Convert.ToDouble(h.Text);
                apotema1 = Convert.ToDouble(ap.Text);
                // llamamos a los voids para el procedimiento
                volumenx(lado1, altura1, apotema1);
                areax(lado1, altura1, apotema1);
            }
            else if (ladovolumen.Checked == true)
            {
                //validaciones numericas
                bool cy = Double.TryParse(h.Text, out c2);
                if (cy == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    h.Text = "";
                    h.Focus();
                    return;
                }

                bool gy = Double.TryParse(ap.Text, out c3);
                if (gy == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    ap.Text = "";
                    ap.Focus();
                    return;
                }
                bool fy = Double.TryParse(a.Text, out c5);
                if (fy == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    a.Text = "";
                    a.Focus();
                    return;
                }
                /// VALIDACIONES
                //cuidando que se ingresen ambos datos necesarios
                if ((h.Text == "") || (a.Text == "")||(ap.Text == ""))
                {
                    MessageBox.Show("\n Error", "no a ingresado los datos necesarios para el calculo");
                    h.Focus();
                    return;
                }
                //procedimiento
                area1 = Convert.ToDouble(a.Text);
                altura1 = Convert.ToDouble(h.Text);
                apotema1 = Convert.ToDouble(ap.Text);
                // se llaman a llos voids para procedimiento
                lapov(area1, apotema1, altura1,1);
                volumenx(Convert.ToDouble(l.Text) , altura1, apotema1);    
                

            }
            else if (alturavolumen.Checked == true)
            {
                //validaciones numericas
                bool ry = Double.TryParse(l.Text, out c1);
                if (ry == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    l.Text = "";
                    l.Focus();
                    return;
                }
                bool gy = Double.TryParse(ap.Text, out c3);
                if (gy == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    ap.Text = "";
                    ap.Focus();
                    return;
                }
                bool fy = Double.TryParse(a.Text, out c5);
                if (fy == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    a.Text = "";
                    a.Focus();
                    return;
                }
                /// VALIDACIONES
                //cuidando que se ingresen ambos datos necesarios
                if ((a.Text == "") || (l.Text == "")||(ap.Text == ""))
                {
                    MessageBox.Show("\n Error", "no a ingresado los datos necesarios para el calculo");
                    l.Focus();
                    return;
                }
                //procedimiento
                area1 = Convert.ToDouble(a.Text);
                lado1 = Convert.ToDouble(l.Text);
                apotema1 = Convert.ToDouble(ap.Text);
                // llamado de metodos
                lapov(area1,lado1,apotema1, 2);
                volumenx(lado1, Convert.ToDouble(h.Text), apotema1);

            }
            else if (apotemavolumen.Checked == true)
            {
                //validaciones numericas
                bool ry = Double.TryParse(l.Text, out c1);
                if (ry == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    l.Text = "";
                    l.Focus();
                    return;
                }
                bool cy = Double.TryParse(h.Text, out c2);
                if (cy == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    h.Text = "";
                    h.Focus();
                    return;
                }
                bool fy = Double.TryParse(a.Text, out c5);
                if (fy == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    a.Text = "";
                    a.Focus();
                    return;
                }
                // validamos 
                if ((a.Text == "") || (l.Text == "")||(h.Text == ""))
                {
                    MessageBox.Show("\n Error", "no a ingresado los datos necesarios para el calculo");
                    l.Focus();
                    return;
                }
                //procedimiento
                area1 = Convert.ToDouble(a.Text);
                altura1 = Convert.ToDouble(h.Text);
                lado1 = Convert.ToDouble(l.Text);
                // llamado de metodos 
                lapov(area1, lado1, altura1, 3);
                volumenx(lado1, altura1 , Convert.ToDouble(ap.Text));
            }
            else if (ladoarea.Checked == true)
            {
                //validaciones numericas
                bool cy = Double.TryParse(h.Text, out c2);
                if (cy == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    h.Text = "";
                    h.Focus();
                    return;
                }

                bool gy = Double.TryParse(ap.Text, out c3);
                if (gy == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    ap.Text = "";
                    ap.Focus();
                    return;
                }
                bool dy = Double.TryParse(v.Text, out c4);
                if (dy == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    v.Text = "";
                    v.Focus();
                    return;
                }
                /// VALIDACIONES
                //cuidando que se ingresen ambos datos necesarios
                if ((h.Text == "") || (v.Text == "")||(ap.Text == ""))
                {
                    MessageBox.Show("\n Error", "no a ingresado los datos necesarios para el calculo");
                    h.Focus();
                    return;
                }
                //procedimiento
                volumen1 = Convert.ToDouble(v.Text);
                altura1 = Convert.ToDouble(h.Text);
                apotema1 = Convert.ToDouble(ap.Text);
                // llamado de metodos para procedimiento
                lapoa(volumen1, altura1, apotema1, 1);
                areax(Convert.ToDouble(l.Text), altura1, apotema1);
            }
            else if (alturaarea.Checked == true)
            {
                //validaciones numericas
                bool ry = Double.TryParse(l.Text, out c1);
                if (ry == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    l.Text = "";
                    l.Focus();
                    return;
                }

                bool gy = Double.TryParse(ap.Text, out c3);
                if (gy == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    ap.Text = "";
                    ap.Focus();
                    return;
                }
                bool dy = Double.TryParse(v.Text, out c4);
                if (dy == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    v.Text = "";
                    v.Focus();
                    return;
                }
                /// VALIDACIONES
                //cuidando que se ingresen ambos datos necesarios
                if ((l.Text == "") || (v.Text == "")||(ap.Text == ""))
                {
                    MessageBox.Show("\n Error", "no a ingresado los datos necesarios para el calculo");
                    l.Focus();
                    return;
                }
                //procedimiento
                volumen1 = Convert.ToDouble(v.Text);
                lado1 = Convert.ToDouble(l.Text);
                apotema1 = Convert.ToDouble(ap.Text);
                lapoa(volumen1, lado1, apotema1, 2);
                areax(lado1, Convert.ToDouble(h.Text), apotema1);
            }
            else if (apotemaarea.Checked == true)
            {
                //validaciones numericas
                bool ry = Double.TryParse(l.Text, out c1);
                if (ry == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    l.Text = "";
                    l.Focus();
                    return;
                }
                bool cy = Double.TryParse(h.Text, out c2);
                if (cy == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    h.Text = "";
                    h.Focus();
                    return;
                }
                bool dy = Double.TryParse(v.Text, out c4);
                if (dy == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    v.Text = "";
                    v.Focus();
                    return;
                }
                //VALIDAMOS 
                if ((l.Text == "") || (v.Text == "") || (h.Text == ""))
                {
                    MessageBox.Show("\n Error", "no a ingresado los datos necesarios para el calculo");
                    l.Focus();
                    return;
                }
                //procedimiento
                volumen1 = Convert.ToDouble(v.Text);
                lado1 = Convert.ToDouble(l.Text);
                altura1 = Convert.ToDouble(h.Text);
                lapoa(volumen1, lado1, altura1, 3);
                areax(lado1, altura1, Convert.ToDouble(ap.Text));
            }
        }
        //boton de NUEVO
        //
        //
        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        /// voids para los calculos correspondientes, segun el checkbox seleccionado
        /// voids individuales privados 
        /// 
        ///void para habilitar todas las opciones
        private void habilitado()
        {
            general.Enabled = true;
            ladovolumen.Enabled = true;
            alturavolumen.Enabled = true;
            apotemavolumen.Enabled = true;
            ladoarea.Enabled = true;
            alturaarea.Enabled = true;
            apotemaarea.Enabled = true;
            l.Enabled = true;
            h.Enabled = true;
            a.Enabled = true;
            v.Enabled = true;
            ap.Enabled = true;
        }

        /// void de limpieza
        /// 
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
            ap.Text = "";
            groupBox1.Focus();
        }
  
        //
        //
        //void para calculo del volumen
        private void volumenx(double lado1, double altura1, double apotema1)
        {
            //procedimiento
            double volt;
            volt = 3 * lado1 * apotema1 * altura1;
            Math.Round(volt, 2);
            v.Text = Convert.ToString(volt);
        }
        //
        //
        //void para calculo del area
        private void areax(double lado1, double altura1, double apotema1)
        {
            // procedimiento
            double art;
            art = 6 * lado1 * (apotema1 + altura1);
            Math.Round(art, 2);
            a.Text = Convert.ToString(art);
        }
        // 
        //metodo para el calculo del lado apotema o altura en valor del volumen
        private void lapoa (double volumen, double valor1, double valor2, int op)
        {
            switch (op)
            {
                case 1:
                    {
                        // procedimiento lado en base al volumen
                        double ladt;
                        ladt = volumen / (3 * valor1 * valor2);
                        Math.Round(ladt, 2);
                        l.Text = Convert.ToString(ladt);
                        break;
                    }
                case 2:
                    {
                        // procedimiento altura en base al volumen
                        double altt;
                        altt = volumen / (3 * valor1 * valor2);
                        Math.Round(altt, 2);
                        h.Text = Convert.ToString(altt);
                        break;
                    }
                case 3:
                    {
                        // procedimiento de apotema en base al volumen
                        double apot ;
                        apot = volumen / (3 * valor1 * valor2);
                        Math.Round(apot, 2);
                        ap.Text = Convert.ToString(apot);
                        break;
                    }
            }
      
        }
        //
        //void para calculo del lado, apotema o altura en valor del area
        private void lapov(double area, double valor1, double valor2, int op)
        {
            switch (op)
                {
                case 1:
                    {
                        // procedimiento lado en base al area
                        double ladt;
                        ladt = area / (6 * ( valor1 + valor2));
                        Math.Round(ladt, 2);
                        l.Text = Convert.ToString(ladt);
                        break;
                    }
                case 2:
                    {
                        // procedimiento altura en base al area
                        double altt;
                        altt = ((area / (6* valor1))-valor2);
                        Math.Round(altt, 2);
                        h.Text = Convert.ToString(altt);
                        break;
                    }
                case 3:
                    {
                        // procedimiento de apotema en base al area
                        double apot;
                        apot =((area / (6 * valor1))-valor2);
                        Math.Round(apot, 2);
                        ap.Text = Convert.ToString(apot);
                        break;
                    }
                }
        }
    }
}
