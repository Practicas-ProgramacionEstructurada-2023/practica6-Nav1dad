using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // VARIABLE BULEANA PARA PODER HACER EL CICLO CON LAS OPCIONES

            bool salir = false;

            do
            {

                Console.WriteLine("\n--------------------------------------------------------");
                Console.WriteLine("MENU DE OPCIONES");
                Console.WriteLine("1. Opcion 1: Suma de numeros Pares e Impares en un rango");
                Console.WriteLine("2. Opcion 2: Adivina el numero secreto (entre 1 y 10)");
                Console.WriteLine("3. Opcion 3: Tablas de multiplicar");
                Console.WriteLine("4. Salir");
                Console.WriteLine("-----------------------------------------------------------");


                Console.WriteLine("Seleccione una opcion: ");
                string? opcion = Convert.ToString(Console.ReadLine());

                switch (opcion)
                {
                    case "1":

                        Console.WriteLine("\n<<<<<<<<<< Suma de numeros pares e impares en un rango >>>>>>>>>>");
                        Console.Write("Ingrese un numero entero positivo: ");

                        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                        {
                            int sumaPares = 0;
                            int sumaImpares = 0;

                            for (int i = 1; i <= n; i++)
                            {
                                if (i % 2 == 0)
                                {
                                    sumaPares += i; // SI ES PAR, SUMA AL ACUMULADOR DE PARES
                                }
                                else
                                {
                                    sumaImpares += i; // SI ES IMPAR, SUMA ACUMULADA DE IMPARES
                                }
                            }

                            Console.WriteLine("\nLa suma de los numeros pares en  el rango es: " + sumaPares);
                            Console.WriteLine("La suma de los numero impares en el rango es: " + sumaImpares);
                        }
                        else
                        {
                            Console.WriteLine("Debe ingresar un numero entero positivo valido.");
                        }

                        break;

                    case "2":

                        // SE LLAMA LA FUNCION RANDOM PARA QUE SE PUEDA USAR NUMEROS SECRETOS ALEATORIAMENTE.

                        Random random = new();

                        // LA VARIABLE (NUMEROSECRETO) ES IGUAL A UN RANGO DEL 1 AL 11 PORQUR C# CUENTA TAMBIEN EL 0

                        int numeroSecreto = random.Next(1, 11);
                        int intentos = 0;
                        int intentoUsuario;

                        Console.WriteLine("\n<<<<<<<<<< Adivina el numero secretp entre (1 y 10) >>>>>>>>>>");

                        while (true)
                        {
                            intentos++;

                            Console.WriteLine("\nIngresa tu intento: ");
                            if (int.TryParse(Console.ReadLine(), out intentoUsuario))
                            {

                                if (intentoUsuario == numeroSecreto)
                                {
                                    Console.WriteLine("Felicidades adivinaste el numero secreto el cual es " + numeroSecreto + " y fue adivinado en " + intentos + " intentos.");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Intentalo de nuevo");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ingresa un numero valido");
                            }
                        }
                        break;

                    case "3":
                        Console.WriteLine("\n<<<<<<<<<< Tablas de multiplicar >>>>>>>>>>");
                        Console.WriteLine("\nIngresa un numero para ver su tabla de multiplicar");
                        int numero = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nTabla de multiplicar del " + numero + ":");

                        // UTILIZAMOS UN BUVLE FOR PARA IMPRIMIR LA TABLA DE MULTIPLICAR DEL NUMERO INGRESADO

                        for (int i = 1; i <= 10; i++)
                        {
                            int resultado = numero * i;
                            Console.WriteLine(numero + " x " + i + " = " + resultado);
                        }
                        break;

                    case "4":
                        Console.WriteLine("Saliendo del programa......");
                        salir = true;
                        break;

                    default:
                    Console.WriteLine("Opcion no valida. Intente de nuevo.");
                        break;
                }

            } while (!salir);

            Console.ReadKey();

        }
    }
}
// NOMBRE: PEDRO ANTONIO ALVAREZ HERNANDEZ
// CODIGO: U20230697