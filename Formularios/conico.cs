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
    public partial class conico : Form
    {
        public conico()
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
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                area.Enabled = false;
                vol.Enabled = false;
            }
            else
            {
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                checkBox5.Enabled = true;
                area.Enabled = true;
                vol.Enabled = true;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2. Checked == true)
            {
                checkBox1.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                diam.Enabled = false;
                vol.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                checkBox5.Enabled = true;
                diam.Enabled = true;
                vol.Enabled = true;
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked== true)
            {
                checkBox2.Enabled = false;
                checkBox1.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                alt.Enabled = false;
                vol.Enabled = false;
            }
            else
            {
                checkBox2.Enabled = true;
                checkBox1.Enabled = true;
                checkBox4.Enabled = true;
                checkBox5.Enabled = true;
                alt.Enabled = true;
                vol.Enabled = true;
            }
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox1.Enabled = false;
                checkBox5.Enabled = false;
                area.Enabled = false;
                diam.Enabled = false;
            }
            else
            {
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox1.Enabled = true;
                checkBox5.Enabled = true;
                area.Enabled = true;
                diam.Enabled = true;
            }
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                area.Enabled = false;
                alt.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox1.Enabled = false;
            }
            else
            {
                area.Enabled = true;
                alt.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                checkBox1.Enabled = true;
            }
        }
        //
        //
        //boton de calcular
        //
        //
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                /// VALIDACIONES
                //cuidando que se ingresen ambos datos necesarios
                if ((alt.Text == "") || (diam.Text == ""))
                {
                    MessageBox.Show("\n Error", "no a ingresado los datos necesarios para el calculo");
                    diam.Focus();
                    return;
                }
                // validacion de datos
                // confirmacion de que los datos que ingresa el usuario son numericos
                double c1, c2;
                bool ry = Double.TryParse(alt.Text, out c1);
                if (ry == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    alt.Text = "";
                    diam.Text = "";
                    alt.Focus();
                    return;
                }
                bool cy = Double.TryParse(diam.Text, out c2);
                if (cy == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    diam.Text = "";
                    alt.Text = "";
                    diam.Focus();
                    return;
                }
            }
            else if (checkBox2.Checked == true)
            {
                /// VALIDACIONES
                //cuidando que se ingresen ambos datos necesarios
                if ((alt.Text == "") || (area.Text == ""))
                {
                    MessageBox.Show("\n Error", "no a ingresado los datos necesarios para el calculo");
                    alt.Focus();
                    return;
                }
                double c1, c2;
                bool ry = Double.TryParse(alt.Text, out c1);
                if (ry == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    alt.Text = "";
                    area.Text = "";
                    alt.Focus();
                    return;
                }
                bool cy = Double.TryParse(area.Text, out c2);
                if (cy == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    area.Text = "";
                    alt.Text = "";
                    area.Focus();
                    return;
                }
            }
            else if (checkBox3.Checked == true)
            {
                /// VALIDACIONES
                //cuidando que se ingresen ambos datos necesarios
                if ((diam.Text == "") || (area.Text == ""))
                {
                    MessageBox.Show("\n Error", "no a ingresado los datos necesarios para el calculo");
                    diam.Focus();
                    return;
                }
                double c1, c2;
                bool ry = Double.TryParse(diam.Text, out c1);
                if (ry == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    diam.Text = "";
                    area.Text = "";
                    diam.Focus();
                    return;
                }
                bool cy = Double.TryParse(area.Text, out c2);
                if (cy == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    diam.Text = "";
                    area.Text = "";
                    diam.Focus();
                    return;
                }
            }
            else if (checkBox4.Checked == true)
            {
                /// VALIDACIONES
                //cuidando que se ingresen ambos datos necesarios
                if ((alt.Text == "") || (vol.Text == ""))
                {
                    MessageBox.Show("\n Error", "no a ingresado los datos necesarios para el calculo");
                    alt.Focus();
                    return;
                }
                double c1, c2;
                bool ry = Double.TryParse(alt.Text, out c1);
                if (ry == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    alt.Text = "";
                    vol.Text = "";
                    alt.Focus();
                    return;
                }
                bool cy = Double.TryParse(vol.Text, out c2);
                if (cy == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    vol.Text = "";
                    alt.Text = "";
                    vol.Focus();
                    return;
                }

            }
            else if (checkBox5.Checked == true)
            {
                /// VALIDACIONES
                //cuidando que se ingresen ambos datos necesarios
                if ((diam.Text == "") || (vol.Text == ""))
                {
                    MessageBox.Show("\n Error", "no a ingresado los datos necesarios para el calculo");
                    diam.Focus();
                    return;
                }
                double c1, c2;
                bool ry = Double.TryParse(diam.Text, out c1);
                if (ry == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    diam.Text = "";
                    vol.Text = "";
                    vol.Focus();
                    return;
                }
                bool cy = Double.TryParse(vol.Text, out c2);
                if (cy == false)
                {
                    MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                    vol.Text = "";
                    diam.Text = "";
                    vol.Focus();
                    return;
                }
            }
        }
        // 
        // boton de limpieza
        //
        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        /// voids para los calculos correspondientes, segun el checkbox seleccionado
        /// voids individuales privados 
        ///  /// 
        /// void para limpieza 
        /// 

        public void limpiar()
        {
            // dejar sin checkear los radiobuttons
            var sentencelist = groupBox1.Controls.OfType<CheckBox>().ToList();
            foreach (var radio in sentencelist)
            {
                radio.Checked = false;
            }
            diam.Text = "";
            alt.Text = "";
            area.Text = "";
            vol.Text = "";
            groupBox1.Focus();
        }
        //
        //
        //void para calculo del volumen
        public void volumenx()
        {

        }
        //
        //
        //void para calculo del area
        public void areax()
        {

        }
        //
        //
        //void para calculo de la altura
        public void alturax()
        {

        }
        //
        // void para calculo de el lado
        public void diametrox()
        {

        }
    }
}
