using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isnp201823_unidad1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string continuar = "y";

            while (continuar.ToLower() == "y")
            {
                Console.WriteLine("EJERCICIOS PROPUESTOS PARA DESARROLLAR:");
                Console.WriteLine();
                Console.WriteLine("1.   Desarrolle un programa que muestre si cada número que se teclea es positivo o negativo, y que se detenga cuando al teclear el número 0.");
                Console.WriteLine();
                Console.WriteLine("2.   Desarrolle un programa que solicite un número entre 1 y 10 y muestre su respectiva tabla de multiplicar, que continúe hasta que el usuario ingrese 0 para salir.");
                Console.WriteLine();
                Console.WriteLine("3.   Desarrolle un programa que pida números positivos al usuario, y vaya calculando la suma de todos ellos (terminará cuando se teclea un número negativo o cero.");
                Console.WriteLine();
                Console.WriteLine("4.   Escriba un programa que solicite un número al usuario y determine si es primo o no (recuerde que los números primos son aquellos números que solo son divisible entre ellos mismos y la unidad).");
                Console.WriteLine();
                Console.WriteLine("5.   Desarrolle un programa que pida una serie de números y al finalizar que calcule el promedio de dichos números (0 para finalizar).");
                Console.WriteLine();
                Console.Write("elige el ejercicio a desarrollar: ");

                if (int.TryParse(Console.ReadLine(), out int opcion))
                {
                    Console.Clear();
                    switch (opcion)
                    {
                        case 1:
                            Ejercicio1();
                            break;
                        case 2:
                            Ejercicio2();
                            break;
                        case 3:
                            Ejercicio3();
                            break;
                        case 4:
                            Ejercicio4();
                            break;
                        case 5:
                            Ejercicio5();
                            break;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida.");
                }

                Console.Write("¿Desea continuar? (y/n): ");
                continuar = Console.ReadLine();
                Console.Clear();
            }

            Console.WriteLine("Programa finalizado.");


            void Ejercicio1()
            {
                Console.WriteLine("Introduce números. El programa se detendrá al teclear 0.");

                while (true)
                {
                    Console.Write("Ingresa un número: ");
                    string input = Console.ReadLine();

                    if (double.TryParse(input, out double numero))
                    {
                        if (numero == 0)
                        {
                            Console.WriteLine("Programa finalizado.");
                            break;
                        }
                        else if (numero > 0)
                        {
                            Console.WriteLine("Es positivo.");
                        }
                        else
                        {
                            Console.WriteLine("Es negativo.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida. Por favor, ingresa un número.");
                    }
                }
            }


            void Ejercicio2()
            {
                int numero;

                do
                {
                    Console.WriteLine("Ingrese un número entre 1 y 10 para mostrar su tabla de multiplicar (0 para salir):");
                    numero = Convert.ToInt32(Console.ReadLine());

                    if (numero >= 1 && numero <= 10)
                    {
                        Console.WriteLine($"Tabla de multiplicar del {numero}:");
                        for (int i = 1; i <= 10; i++)
                        {
                            Console.WriteLine($"{numero} x {i} = {numero * i}");
                        }
                    }
                    else if (numero != 0)
                    {
                        Console.WriteLine("Número inválido. Debe estar entre 1 y 10.");
                    }

                } while (numero != 0);

                Console.WriteLine("¡Programa finalizado!");
            }


            void Ejercicio3()
            {
                int numero;
                int suma = 0;

                Console.WriteLine("Ingrese números positivos. Ingrese un número negativo o cero para ver la suma total y finalizar:");

                while (true)
                {
                    numero = Convert.ToInt32(Console.ReadLine());

                    if (numero > 0)
                    {
                        suma += numero;
                        Console.WriteLine($"La suma es: {suma}");
                    }
                    else
                    {
                        Console.WriteLine($"La suma total de los números positivos ingresados es: {suma}");
                        break;
                    }
                }
            }


            void Ejercicio4()
            {
                while (true)
                {
                    Console.WriteLine("Ingrese un número para determinar si es primo (o ingrese 0 para salir):");
                    int numero = Convert.ToInt32(Console.ReadLine());

                    if (numero == 0)
                    {
                        Console.WriteLine("Programa finalizado.");
                        break;
                    }

                    if (EsPrimo(numero))
                    {
                        Console.WriteLine($"{numero} es un número primo.");
                    }
                    else
                    {
                        Console.WriteLine($"{numero} no es un número primo.");
                    }

                    Console.WriteLine();
                }
            }


            bool EsPrimo(int numero)
            {
                if (numero <= 1)
                    return false;

                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                        return false;
                }

                return true;
            }


            void Ejercicio5()
            {
                int numero;
                int suma = 0;
                int contador = 0;

                Console.WriteLine("Ingrese una serie de números (0 para mostrar el promedio, número negativo para salir):");

                while (true)
                {
                    numero = Convert.ToInt32(Console.ReadLine());

                    if (numero < 0)
                    {
                        break;
                    }

                    if (numero == 0 && contador > 0)
                    {
                        double promedio = (double)suma / contador;
                        Console.WriteLine($"El promedio de los números ingresados hasta ahora es: {promedio}");
                    }
                    else if (numero != 0)
                    {
                        suma += numero;
                        contador++;
                    }
                }

                Console.WriteLine("Gracias por usar el programa. ¡Hasta luego!");
            }
        }
    }
}