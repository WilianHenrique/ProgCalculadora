using System;
using System.Collections.Generic;
using System.Text;

namespace calc.pro
{
    class Calculadora
        {
            private List<double> listNumero = new List<double>();
            public void addNumero(double num)
            {
                this.listNumero.Add(num);
            }
            public double somar()
            {
                double resultado = 0;
                foreach (double numero in this.listNumero)
                {
                    resultado += numero;
                }
                this.listNumero.Clear();
                return resultado;
            }
            public double subtrair()
            {
                double resultado = this.listNumero[0];
                this.listNumero.RemoveAt(0);
                foreach (double numero in this.listNumero)
                {
                    resultado -= numero;
                }
                this.listNumero.Clear();
                return resultado;
            }
            public double multiplicar()
              {
            double resultado = this.listNumero[0];
            this.listNumero.RemoveAt(0);
            foreach (double numero in this.listNumero)
            {
                resultado *= numero;
            }
            this.listNumero.Clear();
            return resultado;
        }
            public double dividir()
            {
               double resultado = this.listNumero[0];
              this.listNumero.RemoveAt(0);
               foreach (double numero in this.listNumero)
               {
                resultado /= numero;
               }
              this.listNumero.Clear();
              return resultado;
        }
        public double porcentagem()
        {
            double resultado = this.listNumero[0];
            this.listNumero.RemoveAt(0);
            foreach (double numero in this.listNumero)
            {
                resultado = (numero * numero) / 100;
            }
            this.listNumero.Clear();
            return resultado;
        }
    }
}
