using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biseccion
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        public static double f(double x)
        {
            // return Math.Pow(x, 3) + 4 * Math.Pow(x, 2) - 10;    //*FUNCION*//
            // return Math.Pow(x, 3) + 4 * Math.Pow(x, 2) - 10; 
            //return  Math.Pow(x, 2) - 10; 
            //  return Math.Sin(10 * x) + Math.Cos(3 * x);
            // return x - Math.Pow(2, -x);
            //  return Math.Exp(x) - Math.Pow(2, -x) + 2 * Math.Cos(x) - 6;
            return ((9.81) * (x) / (14)) * (1 - Math.Exp((-14 * 7) / (x)));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double xl, xu, xi, xr,erra=1;            //*VARIABLES INTRODUCIDAS*//
            int iter;
            xl = Convert.ToDouble(txta.Text);
            xu = Convert.ToDouble(txtb.Text);
            xi = Convert.ToDouble(txterror.Text);
            iter = Convert.ToInt32(txtiter.Text); 
            Biseccion(xl, xu, xi, erra, out xr, iter);            //*VARIABLES INTERNAS DE LA FUNCIÓN*//
            txtxr.Text = xr.ToString();              //MUESTRA EL RESULTADO EN PROGRAMA
        }
        private void Biseccion(double xl, double xu, double xi, double erra, out double xr, int iter)   //*Funcion de biseccion*//
        {
            while (true)      //INICIA EL CICLO 
            {
                int i;
                for (i = 0; i > iter; i++) ;    //INICIA LAS ITERACIONES
                if (f(xl) * f(xu) < 0)          //COMPRUEBA SI EXISTE UNA RAIZ EN EL INTERVALO DADO
                {
                pasodos:       //PASO NUMERO DOS
                    xr = (xu + xl) / (2);                    //SE CALCULA EL VALOR MEDIO DEL INTERVALO
                    erra = (0 - ((xr - xu) / (xr)) * 100);   //SE CALCULA EL ERROR
                    int n = TABLADATOS.Rows.Add();      //Agrega una fila más
                    TABLADATOS.Rows[n].Cells[1].Value = xl;    //
                    TABLADATOS.Rows[n].Cells[2].Value = xu;     //
                    TABLADATOS.Rows[n].Cells[3].Value = f(xl);   // SE AGREGAN LOS RESULTADOS A LA TABLA
                    TABLADATOS.Rows[n].Cells[4].Value = f(xu);  //
                    TABLADATOS.Rows[n].Cells[6].Value = erra;    //
                    TABLADATOS.Rows[n].Cells[5].Value = f(xr);   //
                    TABLADATOS.Rows[n].Cells[0].Value = i;       //
                    if (f(xl) * f(xr) > 0)    // Si es signo positivo, cambiamos el limite superior
                    {
                        xl = xr;                 //EL VALOR INTERMEDIO SUSTITUYE AL LIMITE SUPERIOR
                        if (xi >= erra || iter == i)      
                        {
                            break;   //CRITERIO DE ERROR ES MAYOR O IGUAL A ERROR CALCULADO, TERMINA.
                        }

                    }
                    if (f(xl) * f(xr) < 0)    //si es signo negativo, cambiamos el limite inferior
                    {
                        xu = xr;
                        if (xi >= erra || iter == i)    //  Si el error es meyor o igual al calculado , se cierra el ciclo
                        {
                            break;
                        }
                    }
                    i++;
                    goto pasodos;     //REINICIA EL CICLO , DESDE EL PASO DOS
                }
                else 
                {
                    MessageBox.Show("Introduce otro intervalo");
                    txta.Text = "";
                    txtb.Text = "";
                    txterror.Text = "";
                    txtxr.Text = "";
                    txtiter.Text = "";
                    txta.Focus();
                    xr = 0;
                    break;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            TABLADATOS.Rows.Clear();
            txta.Text = "";
            txtb.Text = "";
            txterror.Text = "";
            txtxr.Text = "";
            txtiter.Text = "";
            txta.Focus();
        }
        #region MISS CLICK
        private void TABLADATOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        #endregion
    }
}
