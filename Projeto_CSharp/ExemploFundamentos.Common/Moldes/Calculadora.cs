using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Moldes
{
    public class Calculadora //Classe
    {
        public void Somar(int x, int y)//Metodo
        {
                Console.WriteLine($"{x} + {y} = {x + y}");
        }

         public void Subtrair(int x, int y)//Metodo
        {
                Console.WriteLine($"{x} - {y} = {x - y}");
        }

         public void Multiplicar(int x, int y)//Metodo
        {
                Console.WriteLine($"{x} * {y} = {x * y}");
        }
        
         public void Dividir(int x, int y)//Metodo
        {
                Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Potencia(int x, int y)
        {
            double potencia = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {potencia}" );
        }
        
        public void Seno(double angulo)
        {                    //angulo * pi divido por pi 
            double radiano = angulo * Math.PI / 180; //Convertendo em radiano
            double seno = Math.Sin(radiano);    //quantos digitos depois a virgula
            Console.WriteLine($"Seno de {angulo}° = {Math.Round(seno,4)}");
        }
        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo}° = {Math.Round(coseno,4)}");
        }
        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Sin(radiano);
            Console.WriteLine($"Tangente de {angulo}° = {Math.Round(tangente,4)}");
        }

        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz Quadrada de {x} = {raiz}");
        }
    }
}