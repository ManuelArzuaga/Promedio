namespace Promedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Notas = new List<double>(); //definicion de Lista
            var entrada = "";
            
            Console.WriteLine("Ïngrese una nota. Cuando queire finalizar ingrese fin");
            
            while ((entrada = Console.ReadLine()) != "fin")
            {
                try
                {
                    Notas.Add(Convert.ToDouble(entrada));
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            if (Notas.Count > 0)
            {
                Console.WriteLine("El promedio es: " + CalcularPromedio(Notas));
            }
            else
            {
                Console.WriteLine("No se ingresaron notas");
            }
        }

        static double CalcularPromedio(List<double> Notas)
        {
            var suma = 0.0;
            foreach(var numero in Notas)
            {
                suma = suma + numero;
            }

           return suma / Notas.Count;
        }
    }
}
