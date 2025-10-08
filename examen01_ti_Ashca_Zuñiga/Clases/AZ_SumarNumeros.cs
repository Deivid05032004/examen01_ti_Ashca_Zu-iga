

namespace examen01_ti_Ashca_Zuñiga.Clases;
// Aplicacion del principio (SRP) Single Responsibility Principle para que cada calse tenga una unica responsabilidad unica
// Se aplica el principio DIP (Dependency Inversion Principle) ya que la clase depende de abstracciones (interfaces) en lugar de implementaciones concretas.
public class AZ_SumarNumeros : AZ_IGranOperacion
{
    public string AZ_ExjecutarOperacion(string numero1, string numero2)
    {
       string MaxNum = numero1.Length >= numero2.Length ? numero1 : numero2;
       string MinNum = numero1.Length < numero2.Length ? numero1 : numero2;
       int maxLen = MaxNum.Length;

        MinNum = MinNum.PadLeft(maxLen, '0');

        StringBuilder result = new StringBuilder();
        int carry = 0;
        for (int i = maxLen - 1; i >= 0; i--)
        {
            int digitSum = MaxNum[i] - '0' + (MinNum[i] - '0') + carry;
            carry = digitSum / 10;
            result.Insert(0, (digitSum % 10).ToString());
        }
        if (carry > 0)
        {
            result.Insert(0, carry.ToString());
        }
        return result.ToString().TrimStart('0') ?? "0";
    }
}
