using System;  //Biblioteca que permite a utilização do fucoes matematicas entre outras;
using System.Globalization;  //Biblioteca que permite a convercao de um tipo de dado em outro, por exemplo de double para string;

namespace Course  //Local do programa;
{
    public class Triangulo  //Classe que possibilita a fabricacao dos objetos triangulos


    {
        public double A { get; set; } //Variavel que disponivel
        public double B { get; set; }
        public double C { get; set; }

        public double CalcularArea()
        {
            double p = (A + B + C) / 2.0; //Calculo do p que é a metade do perimetro do triangulo e necessario para calcular a area;
            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C)); // Calculo da area;

            return area; //A funcao retornara o valor da area;
        }
    }




    public class program
    {
        public static void Main(string[] args)
        {
            Triangulo x = LerTriangulo("X");
            Triangulo y = LerTriangulo("Y");

            double areaX = x.CalcularArea();
            double areaY = y.CalcularArea();

            Console.WriteLine("Area de X =" + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y =" + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior area: X");
            }
            else if (areaX < areaY)
            {
                Console.WriteLine("Maior area: Y");
            }
            else
            {
                Console.WriteLine("Areas iguais.");
            }
        }

        public static Triangulo LerTriangulo(string nomeTriangulo)
        {
            Triangulo triangulo = new Triangulo();

            Console.WriteLine("Entre as medidas do triangulo" + nomeTriangulo + ":");
            triangulo.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            triangulo.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            triangulo.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            return triangulo;
        }

    }
}