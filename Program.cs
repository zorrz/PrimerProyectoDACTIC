using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  un estudiante realiza 4 examenes durante el semestre, los cuales tienen la misma ponderacion , 
             *  realice un programa en c# que agarre las notas del estudiante , capturAR EL NOMBRE DEL ESTUDIANTE e imprimir 
             *  si aprobo o reprobo considerando que la nota minima para aprobar es de 70
              Programa en consola validando que las notas esten entre 0 y 100 */

            int NotaExamen1=0, NotaExamen2=0, NotaExamen3=0, NotaExamen4=0, SumaNota, Promedio;
            string Nombre;

            Console.WriteLine("Ingrese el nombre del estudiante");
            Nombre = Console.ReadLine();

            try
            {
                NotaExamen1 = ObtenerNota("Ingrese la nota del examen 1:");
                
                NotaExamen2 = ObtenerNota("Ingrese la nota del examen 2:");

                NotaExamen3 = ObtenerNota("Ingrese la nota del examen 3:");

                NotaExamen4 = ObtenerNota("Ingrese la nota del examen 4:");

                if (NotaValida(NotaExamen1) && NotaValida(NotaExamen2) && NotaValida(NotaExamen3) && NotaValida(NotaExamen4))
                {
                    
                    SumaNota = NotaExamen1 + NotaExamen2 + NotaExamen3 + NotaExamen4;

                    Promedio = SumaNota / 4;

                    if (Promedio >= 70)
                    {
                        Console.WriteLine($"{Nombre} 'Aprobo' su promedio es de: " + Promedio);
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine($"{Nombre} 'Reprobo' su promedio es de: " + Promedio);
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error, No se pueden ingresar letras");
                
            }
        }

        static int ObtenerNota(string mensaje)
        {
            int nota;
            bool ValidarNumero;

            do
            {
                Console.WriteLine(mensaje);
                ValidarNumero = int.TryParse(Console.ReadLine(), out nota);

                if (!ValidarNumero || !NotaValida(nota))
                {
                    Console.WriteLine("Error, Ingrese un numero valido entre 0 y 100.");
                }

            } while (!ValidarNumero || !NotaValida(nota));

            return nota;
        }

        static bool NotaValida(int nota)
        {
            return nota >= 0 && nota <= 100;
        }

    }
}

