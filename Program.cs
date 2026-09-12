namespace CONVERSOR_DE_UNIDADES
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                int opcion = 0;

                do
                {
                    MostrarMenu();

                    Console.Write("Selecciona una opción: ");
                    int.TryParse(Console.ReadLine(), out opcion);

                    switch (opcion)
                    {
                        case 1:
                            CelsiusFahrenheit();
                            break;

                        case 2:
                            FahrenheitCelsius();
                            break;

                        case 3:
                            KilometrosMillas();
                            break;

                        case 4:
                            MillasKilometros();
                            break;

                        case 5:
                            Console.WriteLine("\nGracias por utilizar el conversor.");
                            break;

                        default:
                            Console.WriteLine("\nOpción incorrecta.");
                            break;
                    }

                } while (opcion != 5);
            }

            static void MostrarMenu()
            {
                Console.WriteLine();
                Console.WriteLine("******************************");
                Console.WriteLine("       CONVERSOR DE UNIDADES");
                Console.WriteLine("******************************");
                Console.WriteLine("1. Celsius a Fahrenheit");
                Console.WriteLine("2. Fahrenheit a Celsius");
                Console.WriteLine("3. Kilómetros a Millas");
                Console.WriteLine("4. Millas a Kilómetros");
                Console.WriteLine("5. Salir");
                Console.WriteLine();
            }

            static void CelsiusFahrenheit()
            {
                Console.Write("\nIngresa los grados Celsius: ");

                if (double.TryParse(Console.ReadLine(), out double celsius))
                {
                    double resultado = (celsius * 9 / 5) + 32;

                    Console.WriteLine(
                        $"{celsius:N2} °C equivalen a {resultado:N2} °F"
                    );
                }
                else
                {
                    Console.WriteLine("El valor ingresado no es válido.");
                }
            }

            static void FahrenheitCelsius()
            {
                Console.Write("\nIngresa los grados Fahrenheit: ");

                if (double.TryParse(Console.ReadLine(), out double fahrenheit))
                {
                    double resultado = (fahrenheit - 32) * 5 / 9;

                    Console.WriteLine(
                        $"{fahrenheit:N2} °F equivalen a {resultado:N2} °C"
                    );
                }
                else
                {
                    Console.WriteLine("El valor ingresado no es válido.");
                }
            }

            static void KilometrosMillas()
            {
                Console.Write("\nIngresa los kilómetros: ");

                if (double.TryParse(Console.ReadLine(), out double kilometros))
                {
                    double resultado = kilometros * 0.621371;

                    Console.WriteLine(
                        $"{kilometros:N2} km equivalen a {resultado:N2} millas"
                    );
                }
                else
                {
                    Console.WriteLine("El valor ingresado no es válido.");
                }
            }

            static void MillasKilometros()
            {
                Console.Write("\nIngresa las millas: ");

                if (double.TryParse(Console.ReadLine(), out double millas))
                {
                    double resultado = millas * 1.60934;

                    Console.WriteLine(
                        $"{millas:N2} millas equivalen a {resultado:N2} km"
                    );
                }
                else
                {
                    Console.WriteLine("El valor ingresado no es válido.");
                }
            }
        }
    }
