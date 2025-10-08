
namespace examen01_ti_Ashca_Zuñiga.Clases;
// Se aplica el principio DIP (Dependency Inversion Principle) ya que la clase depende de abstracciones (interfaces) en lugar de implementaciones concretas.
// Aiendo uso de la inyeccion de dependencias a traves del constructor para recibir las implementaciones de las interfaces.
// Ademas se aplica el principio SRP (Single Responsibility Principle) ya que la clase tiene una unica responsabilidad.
public class AZ_Calculador
{
    public readonly AZ_IGranOperacion _granOperacion;
    public readonly AZ_IValidarGranDato _validarGranDato;
    public AZ_Calculador(AZ_IGranOperacion granOperacion, AZ_IValidarGranDato validarGranDato)
    {
        _granOperacion = granOperacion;
        _validarGranDato = validarGranDato;
    }
    public string AZ_EjecutarOperacion(string numero1, string numero2)
    {
        if (!_validarGranDato.AZ_verificarDatos(numero1) || !_validarGranDato.AZ_verificarDatos(numero2))
        {
            Console.WriteLine("No se puede realizar la operacion");
            return null;
        }
        return _granOperacion.AZ_ExjecutarOperacion(numero1, numero2);
    }


}