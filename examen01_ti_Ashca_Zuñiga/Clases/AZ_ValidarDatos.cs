using examen01_ti_Ashca_Zuñiga.Interfaces;
using System.Security;
using System.Text;

namespace examen01_ti_Ashca_Zuñiga.Clases;

public class AZ_ValidarDatos : AZ_IValidarGranDato
{
    public bool verificarDatos(string dato)
    {
        if (string.IsNullOrEmpty(dato) || dato.Length < 1 )
        {
            return false;
        }
        return true;
    }
    // Validar que el dato no sea nulo, vacio o menor a 1 caracter
    // valirdar que el dato solo contenga numeros del 0 al 9

}

