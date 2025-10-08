
namespace examen01_ti_Ashca_Zuñiga.Clases;
// Aplicacion del principio (SRP) Single Responsibility Principle para que cada calse tenga una unica responsabilidad unica
public class AZ_ValidarDatos : AZ_IValidarGranDato
{
    public bool AZ_verificarDatos(string dato)
    {
        if (string.IsNullOrEmpty(dato) || dato.Length < 1 ||AZ_verificarSoloNumeros(dato))
        {
            return false;
        }
        return true;
    }
    // Validar que el dato no sea nulo, vacio o menor a 1 caracter
    // valirdar que el dato solo contenga numeros del 0 al 9

    // Metodo para verificar que el dato no contenga solo numeros
    private bool AZ_verificarSoloNumeros(string dato)
    {
        foreach (char c in dato)
        {
            if ( char.IsDigit(c))
            {
                return false;
            }
        }
        return true;
    }
}

