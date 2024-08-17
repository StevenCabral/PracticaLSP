using PracticaLSP;

public class Program
{
	public static void Main(string[] args)
	{
		Rectangulo rectangulo = new Rectangulo { Base = 5, Altura = 10 };
		Cuadrado cuadrado = new Cuadrado { Lado = 5 };

		Console.WriteLine($"Area del rectángulo: {rectangulo.CalcularArea()}"); 
		Console.WriteLine($"Area del cuadrado: {cuadrado.CalcularArea()}");
		Console.ReadKey();
	}
}
