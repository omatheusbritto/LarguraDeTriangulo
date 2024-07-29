using System;
namespace LarguraDe
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;
        public double Area()
        {
            double P = (A + B + C) / 2.0;
            return Math.Sqrt(P * (P - A) * (P - B) * (P - C));
        }
        public double Perimetro()
        {
            double p = (A + B + C);
            return (p);
        }
        public override string ToString()
        {
            return "O valor da area do triangulo é de: "
                + Area
                +"\nO valor do perimetro do triangulo é de"
                + Perimetro;
                
        }
    }
}