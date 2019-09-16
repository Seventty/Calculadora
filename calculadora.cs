using System;
namespace algo{
	class calculadora{
		public static void Main(){
						Console.WriteLine("Bienvenido a una calculadora en c#\nPresiona cualquier tecla para continuar...");
						Console.ReadKey();
						Console.Clear();
						Menu();
					}
/*############################### Menu aquí arriba #################################*/
		public static void Menu(){
			double operando1 = 0;
			double operando2 = 0;
			double resultado = 0;
			string resultadofinal = "";
			Console.WriteLine("Introduce el operador a usar: Suma, Resta, Multiplicacion, Division.   (Tambien puede usar Salir e Historial)");
			string lector = Console.ReadLine().ToLower();
			switch(lector){
				case "suma":
				Console.Clear();
				Console.WriteLine("Introduce un operando: ");
				operando1 = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("Introduce el segundo operando: ");
				operando2 = Convert.ToDouble(Console.ReadLine());
				resultado = suma(operando1,operando2);
				resultadofinal = "El resultado de la operación {"+lector+"}: "+operando1.ToString()+" + "+operando2+" = "+resultado;
				Console.WriteLine(resultadofinal);
				Console.ReadKey();
				Console.WriteLine("\n¿Quiere realizar otra operacion? Si o No");
				string confirmacion = Console.ReadLine().ToLower();
				if(confirmacion == "si"){
					Console.Clear();
					Console.WriteLine("Regresando al menu...");
					Menu();
				}else{
					Console.Clear();
					Console.WriteLine("Vuelva pronto.");
					Console.ReadKey();
				}

					break;

				case "resta":
				//resta();
				Console.WriteLine("En desarrollo");
				Console.ReadKey();
					break;

				case "multiplicacion":
				//multiplicacion();
				Console.WriteLine("En desarrollo");
				Console.ReadKey();
				break;

				case "division":
				//division();
				Console.WriteLine("En desarrollo");
				Console.ReadKey();
					break;

				case "historial":
				Console.WriteLine("En desarrollo...");
				Console.ReadKey();	

				case "salir":
				Console.WriteLine("Vuelva pronto...");
				Console.ReadKey();
					break;

				default:
				Console.WriteLine("\nIntroduce una opción valida.");
				Console.ReadKey();
				Console.Clear();
				Menu();
					break;
			}/*################### Fin del menú ############################*/
/*################################### Operadores matematicos ##############################*/
		}public static double suma(double operador1, double operador2){
			return operador1 + operador2;
		}public static double resta(double operador1, double operador2){
			return operador1 - operador2;
		}public static double multiplicacion(double operador1, double operador2){
			return operador1 * operador2;
		}public static double division(double operador1, double operador2){
			return operador1 / operador2;
		}
	}
}
