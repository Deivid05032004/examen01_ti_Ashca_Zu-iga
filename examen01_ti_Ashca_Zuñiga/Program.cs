using System.Text;

namespace examen01_ti_Ashca_Zuñiga
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la calculadora");
            Console.WriteLine();
            Console.WriteLine("Ingrese el primer numero");
            string  numero1 = Console.ReadLine();
            Console.WriteLine("Ingrese el segundo numero");
            string numero2 = Console.ReadLine();

            AZ_IGranOperacion suma = new AZ_SumarNumeros();
            AZ_IValidarGranDato validarDatos = new AZ_ValidarDatos();
            var calculadora = new AZ_Calculador(suma,validarDatos);

            Console.WriteLine(calculadora.EjecutarOperacion(numero1,numero2));
            Console.WriteLine("Precione cualquier tecla para continuar");
            Console.Read();

        }
    }
}

