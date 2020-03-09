using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FalsaPosicionFORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static double f(double x)
        {
            //return (Math.Pow(x, 2) -2);    //*FUNCION*//
            //return (x - Math.Pow(2, -x));
            //return Math.Exp(x) - Math.Pow(2, -x) + 2 * Math.Cos(x) - 6;
            //return Math.Exp(x) - Math.Pow(x, 2) + 3 * x - 2;
            // return ((9.81) * (x) / (14)) * (1 - Math.Exp((-14 * 7) / (x)));
          return (((9.81 / 14) * x) * (1 - Math.Exp(-(14 * 7) / x))) - 35;
        }
        private void button1_Click(object sender, EventArgs e)
         {
                if (txta.Text == "")   //COMPRIBACIÓN VALOR NUMERICO XL - TXTA
                {
                    MessageBox.Show("Ingrese el valor del limite inferio", "ERROR");
                    txta.Focus();
                    return;
                }
                double xl;
                try
                {
                    xl = Convert.ToDouble(txta.Text);
                }
                catch
                {
                    MessageBox.Show("Ingresa un valor numerico en el limite inferior");
                    txta.Text = " ";
                    txta.Focus();
                    return;
                }
                if (txtb.Text == "")  // COMPROBACION VALOR NUMERICO XU - TXTB
                {
                    MessageBox.Show("Ingrese el valor del limite Superior", "ERROR");
                    txtb.Focus();
                    return;
                }
                double xu;
                try
                {
                    xu = Convert.ToDouble(txtb.Text);
                }
                catch
                {
                    MessageBox.Show("Ingresa un valor numerico en el limite superior");
                    txtb.Text = " ";
                    txtb.Focus();
                    return;
                }
                if (txterror.Text == "")   //COMPROBACIÓN VALOR NUMERICO ERROR TXTERROR
                {
                    MessageBox.Show("Ingrese el valor del criterio de error", "ERROR");
                    txterror.Focus();
                    return;
                }
                double xi;
                try
                {
                    xi = Convert.ToDouble(txterror.Text);
                }
                catch
                {
                    MessageBox.Show("Ingresa un valor numerico del criterio de error", "ERROR");
                    txterror.Text = " ";
                    txterror.Focus();
                    return;
                }
                if (txterror.Text == "")   //COMPROBACIÓN VALOR NUMERICO de iteraciones - txtiter
                {
                    MessageBox.Show("Ingrese el limite de iteraciones", "ERROR");
                    txtiter.Focus();
                    return;
                }
                double iter;
                try
                {
                    iter = Convert.ToDouble(txterror.Text);
                }
                catch
                {
                    MessageBox.Show("Ingresa un valor numerico del criterio de error", "ERROR");
                    txterror.Text = " ";
                    txterror.Focus();
                    return;
                }
                double xr, erra = 1;            //*VARIABLES INTRODUCIDAS*//
                iter = Convert.ToDouble(txtiter.Text);
                Biseccion(xl, xu, xi, erra, out xr, iter);            //*VARIABLES INTERNAS DE LA FUNCIÓN*//
                txtxr.Text = xr.ToString();              //MUESTRA EL RESULTADO EN PROGRAMA
         }
        private void Biseccion(double xl, double xu, double xi, double erra, out double xr, double iter)   //*Funcion de biseccion*//
        {
           while (true)      //INICIA EL CICLO 
           {
                int i;
                double fl, fu;
                fl = f(xl);
                fu=f(xu);
               for (i = 0; i > iter; i++) ;    //INICIA LAS ITERACIONES
               if (f(xl) * f(xu) < 0)          //COMPRUEBA SI EXISTE UNA RAIZ EN EL INTERVALO DADO
               {
                  pasodos:       //PASO NUMERO DOS
                xr = xu-fu*(xl-xu)/(fl-fu);                    //SE CALCULA EL VALOR MEDIO DEL INTERVALO
                    erra = (0-((xr - xu) / (xr)) * 100);   //SE CALCULA EL ERROR
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
                     fl = f(xl);
                        xu = xu+1 / 2;
                    if (xi >= erra || iter == i)
                    {
                       break;   //CRITERIO DE ERROR ES MAYOR O IGUAL A ERROR CALCULADO, TERMINA.
                    }
                  }
                  if (f(xl) * f(xr) < 0)    //si es signo negativo, cambiamos el limite inferior
                  {
                    xu = xr;
                    fu = (f(xu));
                        xl = xl+1 / 2;
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
    }
}