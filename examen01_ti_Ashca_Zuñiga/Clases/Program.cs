using examen01_ti_Ashca_Zuñiga.Interfaces;
using System.Text;

namespace examen01_ti_Ashca_Zuñiga.Clases
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool respues = true;
            do
            {
                Console.WriteLine("Bienvenido a la calculadora");
                Console.WriteLine();
                Console.WriteLine("Ingrese el primer numero");
                string numero1 = Console.ReadLine();
                Console.WriteLine("Ingrese el segundo numero");
                string numero2 = Console.ReadLine();
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("Respuesta: ");
                Console.WriteLine();
                AZ_IGranOperacion suma = new AZ_SumarNumeros();
                AZ_IValidarGranDato validarDatos = new AZ_ValidarDatos();
                var calculadora = new AZ_Calculador(suma, validarDatos);

                Console.WriteLine(calculadora.AZ_EjecutarOperacion(numero1, numero2));
                Console.WriteLine("Quiere ingresar nnuevos numeros?");
                Console.WriteLine();
                Console.WriteLine("Ingrese: (si/no) ");
               if (Console.ReadLine().ToLower() != "si")
                {
                    respues = false;
                }

            } while (respues);

            Console.ReadKey();


        }
    }
}

