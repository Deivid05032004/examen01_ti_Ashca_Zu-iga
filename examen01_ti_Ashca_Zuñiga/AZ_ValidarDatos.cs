

using System.Security;
using System.Text;

namespace examen01_ti_Ashca_Zuñiga;

public class AZ_ValidarDatos : AZ_IValidarGranDato
{
    public bool verificarDatos(string dato)
    {
        if (string.IsNullOrEmpty(dato) || dato.Length < 1)
        {
            return false;
        }
        return true;
    }
}

