namespace ExemploEnum
{
    enum EstadosCivis : byte { 
        Casado,
        Solteiro,
        Viuvo,
        Separado,
        enrolado,
        Outro
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            for (byte i = 0; i <= 5; i++){
                Console.WriteLine(Enum.GetName(typeof(EstadosCivis), i));
            }
        }
    }
}