using System;  //Biblioteca que permite a utilização do fucoes matematicas entre outras;
using System.Globalization;  //Biblioteca que permite a convercao de um tipo de dado em outro, por exemplo de double para string;

namespace Course  //Local do programa;
{
    public class Triangulo  //Classe triangulo que contera os atributos e metodos para seus objetos;


    {
        public double A { get; set; } //Variavel do triangulo que ira conter o valor deste lado;
        public double B { get; set; } //Variavel do triangulo que ira conter o valor deste lado;
        public double C { get; set; } //Variavel do triangulo que ira conter o valor deste lado;

        public double CalcularArea()//Metodo que ira calcular a area;
        {
            double p = (A + B + C) / 2.0; //Calculo do p que é a metade do perimetro do triangulo e necessario para calcular a area;
            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C)); // Calculo da area;

            return area; //A funcao retornara o valor da area;
        }
    }




    public class program //Classe que contem o codigo principal
    {
        public static void Main(string[] args)//Funcao principal
        {
            Triangulo x = LerTriangulo("x"); // cria x que é objeto da classe triangulo e recebera o valor de seus atributos A, B e C por meio da funcao LerTriangulo;
            Triangulo y = LerTriangulo("y"); // cria y que é objeto da classe triangulo e recebera o valor de seus atributos A, B e C por meio da funcao LerTriangulo;

            double areaX = x.CalcularArea(); //a variavel areaX recebera o valor retornado do metodo CalcularArea() do objeto x;
            double areaY = y.CalcularArea(); //a variavel areaY recebera o valor retornado do metodo CalcularArea() do objeto y;

            Console.WriteLine("Area de x =" + areaX.ToString("F4", CultureInfo.InvariantCulture)); // mostra a area de X para o usuario converntendo seu valor para uma string e arrendondando seu valor para ate quatro numeros apos a virgula;
            Console.WriteLine("Area de y =" + areaY.ToString("F4", CultureInfo.InvariantCulture)); // mostra a area de Y para o usuario converntendo seu valor para uma string e arrendondando seu valor para ate quatro numeros apos a virgula;

            if (areaX > areaY) //Caso a area de X seja maior que a de Y;
            {
                Console.WriteLine("Maior area: x"); //Relatar a area maior para o usuario;
            }
            else if (areaX < areaY)/ /Caso a area de X seja menor que a de Y;
            {
                Console.WriteLine("Maior area: y"); //Relatar a area maior para o usuario;
            }
            else //caso contrario;
            {
                Console.WriteLine("Areas iguais."); //Relatar  que as areas sao iguais para o usuario;
            }
        }

        public static Triangulo LerTriangulo(string nomeTriangulo)//Funcao que ira fazer o calculo e retonar a area. Recebe como atributos uma array composta por doubles. Pertence a classe triangulo;
        {
            Triangulo triangulo = new Triangulo(); //cria um objeto da classe triangulo;

            Console.WriteLine("Entre as medidas do triangulo" + nomeTriangulo + ":"); //Interacao com o usuario pedindo a medida do triangulo;
            triangulo.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //O valor informado pelo usuario e convertido para double e amazenado pelo objeto em seu atributo A;
            triangulo.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //O valor informado pelo usuario e convertido para double e amazenado pelo objeto em seu atributo B;
            triangulo.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //O valor informado pelo usuario e convertido para double e amazenado pelo objeto em seu atributo C;

            return triangulo; //Retona as informacoes atribuidas no objeto triangulo;
        }

    }
}
