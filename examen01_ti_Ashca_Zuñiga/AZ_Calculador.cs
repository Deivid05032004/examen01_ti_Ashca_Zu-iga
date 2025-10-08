

namespace examen01_ti_Ashca_Zuñiga;
// Se aplica el principio DIP (Dependency Inversion Principle) ya que la clase depende de abstracciones (interfaces) en lugar de implementaciones concretas.
public class AZ_Calculador
{
    public readonly AZ_IGranOperacion _granOperacion;
    public readonly AZ_IValidarGranDato _validarGranDato;
    public AZ_Calculador(AZ_IGranOperacion granOperacion, AZ_IValidarGranDato validarGranDato)
    {
        _granOperacion = granOperacion;
        _validarGranDato = validarGranDato;
    }
    public string EjecutarOperacion(string numero1, string numero2)
    {
        if (!_validarGranDato.verificarDatos(numero1) || !_validarGranDato.verificarDatos(numero2))
        {
            Console.WriteLine("No se puede realizar la operacion");
            return null;
        }
        return _granOperacion.ExjecutarOperacion(numero1, numero2);
    }


}