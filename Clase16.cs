using System;

namespace Clase16// Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void numerosDecendentes()
        {
            Console.WriteLine("\nIngrese un numero decendente(n): ");
            int n = int.Parse(Console.ReadLine());

            if ( n >= 1 )
            {
                for (int i = n; i >= 1; i--)
                {
                    Console.WriteLine($"Numero > {i}");
                }
            }
            else
            {
                Console.WriteLine("Ingresar numero mayor a 1");
            }
        }

        static void numeroWhile()
        {   
            Console.WriteLine("Ingrese el numero hasta el que desee contar"); // Cambie el metodo para que se pueda ingresar un valor desde consola y se cuente desde contador = 1 hasta n
            int contador = 1; 
            int n =int.Parse(Console.ReadLine());
            while (contador <= n)
            {
                Console.WriteLine($"Numero >>{contador}");
                contador++;
            }
        }
       
        static void minimoLista()
        {
            List<int> numeros = new List<int> {1,2,3,4,5,6};

            int minimo = numeros[0];

            foreach (int numero1 in numeros)
            {
                if (numero1 < minimo)
                {
                    minimo = numero1;
                }
            }
            Console.WriteLine("El numero menor de la lista es: " + minimo);
        }

        static void Main()
        {   Console.WriteLine("Guia Clase 20");
            int opcion;
            do
            {   
                Console.WriteLine("\n");
                Console.WriteLine("Menú:");
                Console.WriteLine("1. Numeros decendentes");
                Console.WriteLine("2. Contador de numeros");
                Console.WriteLine("3. Menor Numero de");
                Console.WriteLine("4. Salir");
                Console.Write("Selecciona una opción (1-4): ");
                

                if (int.TryParse(Console.ReadLine(), out opcion))
                {   
                    Console.WriteLine("\n");
                    switch (opcion)
                    {   
                        case 1:

                        numerosDecendentes();

                        break;

                        case 2:
                        numeroWhile();
                        
                        break;
                    
                        case 3:
                        minimoLista();
                       
                        break;

                        case 4:
                        Console.WriteLine("\n"); 
                        Console.WriteLine("Saliendo del programa.");
                        break;
                        
                        default:
                        Console.WriteLine("\n"); 
                        Console.WriteLine("Opción no válida. Por favor, selecciona una opción válida (1-4).");
                        break;
                    }
                }
                else
                {   Console.WriteLine("\n");
                    Console.WriteLine("Entrada inválida. Por favor, introduce un número válido (1-4).");
                }
            } while (opcion != 4); 
            
        }
    
    
    }
}