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
    public partial class cilindrico : Form
    {
        public cilindrico()
        {
            InitializeComponent();
        }
        //
        // seleccion de COMBOBOX
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                vol.Enabled = false;
                ab.Enabled = false;
                rad.Enabled = true;
                alt.Enabled = true;
            }
            else
            if (comboBox1.SelectedIndex == 2)
            {
                rad.Enabled = false;
                ab.Enabled = false;
                vol.Enabled = true;
                alt.Enabled = true;
            }
            else
            if (comboBox1.SelectedIndex == 3)
            {
                alt.Enabled = false;
                ab.Enabled = false;
                vol.Enabled = true;
                rad.Enabled = true;
            }
            else
            {
                habilitado();
            }
        }
        //
        // boton de   CALCULAR
        private void button1_Click(object sender, EventArgs e)
        {
            // declaramos variables para trabajar 
            double radio, altura, areabase, volumen1;
            // switch para trabajar segun el combobox
            int value = comboBox1.SelectedIndex;
            switch (value)
            {
                case 1:
                    {
                        /// VALIDACIONES
                        //cuidando espacios vacios
                        if ((rad.Text == "") || (alt.Text == ""))
                        {
                            MessageBox.Show("\n Error", "no a ingresado los datos necesarios para el calculo");
                            alt.Focus();
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
                            rad.Text = "";
                            alt.Focus();
                            return;
                        }
                        bool cy = Double.TryParse(rad.Text, out c2);
                        if (cy == false)
                        {
                            MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                            rad.Text = "";
                            alt.Text = "";
                            rad.Focus();
                            return;
                        }
                        // asignamos valor a las variables
                        radio = Convert.ToDouble(rad.Text);
                        altura = Convert.ToDouble(alt.Text);
                        // llamamos a los metodos 
                        areabas(radio);
                        volumenx(radio, altura);
                        break;
                    }
                case 2:
                    {
                        /// VALIDACIONES
                        //cuidando espacios vacios
                        if ((vol.Text == "") || (alt.Text == ""))
                        {
                            MessageBox.Show("\n Error", "no a ingresado los datos necesarios para el calculo");
                            alt.Focus();
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
                        //asignamos variables
                        volumen1 = Convert.ToDouble(vol.Text);
                        altura = Convert.ToDouble(alt.Text);
                        // llamamos metodos
                        radiox(volumen1, altura);
                        areabas(Convert.ToDouble(rad.Text));
                        break;
                    }
                case 3:
                    {
                        /// VALIDACIONES
                        //cuidando espacios vacios
                        if ((vol.Text == "") || (rad.Text == ""))
                        {
                            MessageBox.Show("\n Error", "no a ingresado los datos necesarios para el calculo");
                            rad.Focus();
                            return;
                        }
                        // validacion de datos
                        // confirmacion de que los datos que ingresa el usuario son numericos
                        double c1, c2;
                        bool ry = Double.TryParse(rad.Text, out c1);
                        if (ry == false)
                        {
                            MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                            rad.Text = "";
                            vol.Text = "";
                            rad.Focus();
                            return;
                        }
                        bool cy = Double.TryParse(vol.Text, out c2);
                        if (cy == false)
                        {
                            MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                            vol.Text = "";
                            rad.Text = "";
                            vol.Focus();
                            return;
                        }
                        // asignamos variables
                        volumen1 = Convert.ToDouble(vol.Text);
                        radio = Convert.ToDouble(rad.Text);
                        // llamamos metodos
                        areabas(radio);
                        alturax(volumen1, Convert.ToDouble(ab.Text));

                        break;
                    }
            }

        }
        //
        // boton de salida, sale del proceso del formulario
        private void salida_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        // boton de NUEVO
        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            limpiar();

        }
        /// voids para los calculos correspondientes, segun el checkbox seleccionado
        /// TAB CONTROL VOLUMENES
        /// 

        //
        //
        //void para calculo del volumen
        private void volumenx(double radio, double altura)
        {
            double v;
            v = 3.1416 * Math.Pow(radio, 2) * altura;
            Math.Round(v, 2);
            vol.Text = Convert.ToString(v);
        }
        //
        //
        //void para calculo del area base
        private void areabas(double radio)
        {
            double abase;
            abase = 3.1416 * Math.Pow(radio, 2);
            Math.Round(abase);
            ab.Text = Convert.ToString(abase);
        }
        //
        //void para calculo de la altura
        public void alturax(double volumen, double basearea)
        {
            double alttot = volumen / basearea;
            Math.Round(alttot, 2);
            alt.Text = Convert.ToString(alttot);
        }
        //
        // void para calculo del radio
        public void radiox(double volumen1, double altura)
        {
            double radioxx = Math.Sqrt(volumen1 / (3.1416 * altura));
            Math.Round(radioxx, 2);
            rad.Text = Convert.ToString(radioxx);
        }

        private void cilindrico_Load(object sender, EventArgs e)
        {

        }
        /// void para limpieza 
        /// 

        public void limpiar()
        {

            rad.Text = "";
            alt.Text = "";
            ab.Text = "";
            vol.Text = "";
            Haltura2.Text = "";
            areabase2.Text = "";
            arealateral2.Text = "";
            radio2.Text = "";
        }
        // habilitar todos los espacios disponibles
        private void habilitado()
        {
            alt.Enabled = true;
            rad.Enabled = true;
            vol.Enabled = true;
            ab.Enabled = true;
            Haltura2.Enabled = true;
            areabase2.Enabled = true;
            arealateral2.Enabled = true;
            radio2.Enabled = true;
        }

        //// 
        ////
        ////
        ////
        ////
        ///CILINDRICO TAB CONTROL DE AREA
        ////
        ////
        ////
        ///

        // SELECCION DEL COMBOBOX,  
        // selecciona las opciones con las qu desea trabajar
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 1)
            {
                arealateral2.Enabled = false;
                areabase2.Enabled = false;
                radio2.Enabled = true;
                Haltura2.Enabled = true;
            }
            else
           if (comboBox2.SelectedIndex == 2)
            {
                radio2.Enabled = false;
                areabase2.Enabled = false;
                arealateral2.Enabled = true;
                Haltura2.Enabled = true;
            }
            else
           if (comboBox2.SelectedIndex == 3)
            {
                Haltura2.Enabled = false;
                areabase2.Enabled = false;
                arealateral2.Enabled = true;
                radio2.Enabled = true;
            }
            else
            {
                habilitado();
            }
        }
        // boton de NUEVO //
        ////
        ///
        private void button4_Click(object sender, EventArgs e)
        {
            limpiar();
            comboBox2.SelectedIndex = 0;
        }
        // boton de Salida
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        // boton de calcular, calcula las opciones segun combobbox
        private void button5_Click(object sender, EventArgs e)
        {
            // variables
            double radioc, alturac, alateralc, abasec;
            // switch para trabajar segun el combobox
            int value = comboBox2.SelectedIndex;
            switch (value)
            {
                case 1:
                    {
                        /// VALIDACIONES
                        //cuidando espacios vacios
                        if ((radio2.Text == "") || (Haltura2.Text == ""))
                        {
                            MessageBox.Show("\n Error", "no a ingresado los datos necesarios para el calculo");
                            alt.Focus();
                            return;
                        }
                        // validacion de datos
                        // confirmacion de que los datos que ingresa el usuario son numericos
                        double c1, c2;
                        bool ry = Double.TryParse(Haltura2.Text, out c1);
                        if (ry == false)
                        {
                            MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                            Haltura2.Text = "";
                            radio2.Text = "";
                            alt.Focus();
                            return;
                        }
                        bool cy = Double.TryParse(radio2.Text, out c2);
                        if (cy == false)
                        {
                            MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                            radio2.Text = "";
                            Haltura2.Text = "";
                            rad.Focus();
                            return;
                        }
                        // asignamos valor a las variables
                        radioc = Convert.ToDouble(radio2.Text);
                        alturac = Convert.ToDouble(Haltura2.Text);    
                        alaterald(radioc, alturac);
                        areabasec(radioc);
                    }
                    break;
                case 2:
                    {
                        /// VALIDACIONES
                        //cuidando espacios vacios
                        if ((arealateral2.Text == "") || (Haltura2.Text == ""))
                        {
                            MessageBox.Show("\n Error", "no a ingresado los datos necesarios para el calculo");
                            alt.Focus();
                            return;
                        }
                        // validacion de datos
                        // confirmacion de que los datos que ingresa el usuario son numericos
                        double c1, c2;
                        bool ry = Double.TryParse(Haltura2.Text, out c1);
                        if (ry == false)
                        {
                            MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                            Haltura2.Text = "";
                            arealateral2.Text = "";
                            alt.Focus();
                            return;
                        }
                        bool cy = Double.TryParse(arealateral2.Text, out c2);
                        if (cy == false)
                        {
                            MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                            arealateral2.Text = "";
                            Haltura2.Text = "";
                            vol.Focus();
                            return;
                        }
                        //asignamos variables
                        alateralc = Convert.ToDouble(arealateral2.Text );
                        alturac = Convert.ToDouble(Haltura2.Text);
                        radioab(alateralc, alturac);
                        double brad = Convert.ToDouble(radio2.Text);
                        areabasec(brad);
                        break;
                    }
                case 3:
                    {
                        /// VALIDACIONES
                        //cuidando espacios vacios
                        if ((arealateral2.Text == "") || (radio2.Text == ""))
                        {
                            MessageBox.Show("\n Error", "no a ingresado los datos necesarios para el calculo");
                            radio2.Focus();
                            return;
                        }
                        // validacion de datos
                        // confirmacion de que los datos que ingresa el usuario son numericos
                        double c1, c2;
                        bool ry = Double.TryParse(radio2.Text, out c1);
                        if (ry == false)
                        {
                            MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                            radio2.Text = "";
                            arealateral2.Text = "";
                            radio2.Focus();
                            return;
                        }
                        bool cy = Double.TryParse(arealateral2.Text, out c2);
                        if (cy == false)
                        {
                            MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                            arealateral2.Text = "";
                            radio2.Text = "";
                            vol.Focus();
                            return;
                        }
                        //asignamos variables
                        alateralc = Convert.ToDouble(arealateral2.Text);
                        radioc = Convert.ToDouble(radio2.Text);
                        alturab(alateralc,radioc);
                        areabasec(radioc);
                        break;
                    }
            }

        }
        // voids para los calculos segun combobox
        // TAB CONTROL AREAS
        //arealateral
        private void alaterald(double radioc, double alturac)
        {
            double al1;
            al1 = (2 * 3.1416 * radioc * alturac);
            Math.Round(al1, 2);
            arealateral2.Text = Convert.ToString(al1);
        }
        //areabase
        private void areabasec(double radioc)
        {
            double ab;
            ab = 3.1416 * Math.Pow(radioc, 2);
            Math.Round(ab);
            areabase2.Text = Convert.ToString(ab);
        }
        //radio
        private void radioab(double arealat, double alturac)
        {
            double rd = arealat / (2 * 3.1416 * alturac);
            Math.Round(rd, 2);
            radio2.Text = Convert.ToString(rd);
        }
        //altura
         private void alturab (double arealat, double radc)
         {
               double altc = arealat / (2 * 3.1416 * radc);
               Math.Round(altc, 2);   
               Haltura2.Text = Convert.ToString(altc);
         }
    }
}