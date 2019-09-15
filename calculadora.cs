using System;
namespace algo{
	class calculadora{
		public static void Main(){
						Console.WriteLine("Bienvenido a una calculadora en c#\nPresiona cualquier tecla para continuar...");
						Console.ReadKey();
						Console.Clear();
						Menu();
					}
		public static void Menu(){
			Console.WriteLine("Introduce el operador a usar: Suma, Resta, Multiplicacion, Division.");
			string lector = Console.ReadLine().ToLower();
			switch(lector){
				case "suma":
				suma();
				break;

				case "resta":
				resta();
				break;

				case "multiplicacion":
				multiplicacion();
				break;

				case "division":
				division();
				break;

				default:
				Console.WriteLine("\nIntroduce una opción valida.");
				Console.ReadKey();
				Console.Clear();
				Menu();
				break;
			}
		}public static void suma(){
			Console.Clear();
			Console.WriteLine("Introduce los operandos a sumar: ");
			int respuesta = Convert.ToInt32(Console.ReadLine());
				if(respuesta <= 1){
					Console.WriteLine("Introduce mas de un operando para realizar la operacion.");
					Console.ReadKey();
					Console.Clear();
					suma();
				}
			}public static void resta(){
				Console.Clear();
			Console.WriteLine("Introduce los operandos a restar: ");
			int respuesta = Convert.ToInt32(Console.ReadLine());
				if(respuesta <= 1){
					Console.WriteLine("Introduce mas de un operando para realizar la operacion.");
					Console.ReadKey();
					Console.Clear();
					resta();
				}
				}public static void multiplicacion(){
					Console.Clear();
			Console.WriteLine("Introduce los operandos a multiplicar: ");
			int respuesta = Convert.ToInt32(Console.ReadLine());
				if(respuesta <= 1){
					Console.WriteLine("Introduce mas de un operando para realizar la operacion.");
					Console.ReadKey();
					Console.Clear();
					multiplicacion();
				}
					}public static void division(){
						Console.Clear();
			Console.WriteLine("Introduce los operandos a dividir: ");
			int respuesta = Convert.ToInt32(Console.ReadLine());
				if(respuesta <= 1){
					Console.WriteLine("Introduce mas de un operando para realizar la operacion.");
					Console.ReadKey();
					Console.Clear();
					division();
				}
		}
	}
}
