using System.Text;

namespace examen01_ti_Ashca_Zuñiga
{
    public class Program
    {
        static void Main(string[] args)
        {
            AZ_IGranOperacion suma = new AZ_SumarNumeros();
            AZ_IValidarGranDato validarDatos = new AZ_ValidarDatos();
            var calculadora = new AZ_Calculador(suma,validarDatos);
        }
    }
}

