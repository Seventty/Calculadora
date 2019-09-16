using System;
using System.Collections.Generic; 
namespace algo{
	class calculadora{
		public static void Main(string[] args){
				string[] historial = new string[100];
				Console.WriteLine("Bienvenido a una calculadora en c#\nPresiona cualquier tecla para continuar...");
				Console.ReadKey();
				Console.Clear();
				Menu(historial);
					}
/*############################### Menu aquí arriba #################################*/
		public static void Menu(string[] historial){
			double operando1 = 0;
			double operando2 = 0;
			double operando3 = 0;
			double operando4 = 0;
			double resultado = 0;
			string resultadofinal = "";
			string confirmacion = "";
			Console.WriteLine("Introduce el operador a usar: Suma, Resta, Multiplicacion, Division.  (Tambien puede usar: Promedio, Historial & Salir.)");
			string lector = Console.ReadLine().ToLower();
			Console.Clear();
			switch(lector){
				case "suma":
					Console.WriteLine("Introduce un operando: ");
					operando1 = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("Introduce el segundo operando: ");
					operando2 = Convert.ToDouble(Console.ReadLine());
					resultado = suma(operando1,operando2);
					resultadofinal = "El resultado de la operación {"+lector+"}: "+operando1.ToString()+" + "+operando2+" = "+resultado+"\n Esta operacion fue realizada: ###################### El ["+DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm:tt] ####################");
					Console.WriteLine(resultadofinal);
					historial[0] = resultadofinal;
					resultadofinal= "\nEsta operacion fue realizada: ###################### El ["+DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm:tt] ####################");
					Console.ReadKey();
					Console.WriteLine("\n¿Quiere realizar otra operacion? Si o No");
					confirmacion = Console.ReadLine().ToLower();
					if(confirmacion == "si"){
						Console.Clear();
						Console.WriteLine("Regresando al menu...");
						Menu(historial);
					}else{
						Console.Clear();
						Console.WriteLine("Vuelva pronto.");
						Console.ReadKey();
					}
				break;

				case "resta":
					Console.Clear();
					Console.WriteLine("Introduce un operando: ");
					operando1 = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("Introduce el segundo operando: ");
					operando2 = Convert.ToDouble(Console.ReadLine());
					resultado = resta(operando1,operando2);
					resultadofinal = "El resultado de la operación {"+lector+"}: "+operando1.ToString()+" - "+operando2+" = "+resultado+"\n Esta operacion fue realizada: ###################### El ["+DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm:tt] ####################");
					Console.WriteLine(resultadofinal);
					resultadofinal = "\nEsta operacion fue realizada: ###################### El ["+DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm:tt] ####################");
					Console.ReadKey();
					Console.WriteLine("\n¿Quiere realizar otra operacion? Si o No");
					confirmacion = Console.ReadLine().ToLower();
					if(confirmacion == "si"){
						Console.Clear();
						Console.WriteLine("Regresando al menu...");
						Menu(historial);
					}else{
						Console.Clear();
						Console.WriteLine("Vuelva pronto.");
						Console.ReadKey();
					}
				break;

				case "multiplicacion":
					Console.Clear();
					Console.WriteLine("Introduce un operando: ");
					operando1 = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("Introduce el segundo operando: ");
					operando2 = Convert.ToDouble(Console.ReadLine());
					resultado = multiplicacion(operando1,operando2);
					resultadofinal = "El resultado de la operación {"+lector+"}: "+operando1.ToString()+" * "+operando2+" = "+resultado+"\n Esta operacion fue realizada: ###################### El ["+DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm:tt] ####################");
					Console.WriteLine(resultadofinal);
					resultadofinal = "\nEsta operacion fue realizada: ###################### El ["+DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm:tt] ####################");
					Console.ReadKey();
					Console.WriteLine("\n¿Quiere realizar otra operacion? Si o No");
					confirmacion = Console.ReadLine().ToLower();
					if(confirmacion == "si"){
						Console.Clear();
						Console.WriteLine("Regresando al menu...");
						Menu(historial);
					}else{
						Console.Clear();
						Console.WriteLine("Vuelva pronto.");
						Console.ReadKey();
					}
				break;

				case "division":
					Console.Clear();
					Console.WriteLine("Introduce un operando: ");
					operando1 = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("Introduce el segundo operando: ");
					operando2 = Convert.ToDouble(Console.ReadLine());
					resultado = division(operando1,operando2);
					resultadofinal = "El resultado de la operación {"+lector+"}: "+operando1.ToString()+" / "+operando2+" = "+resultado;
					Console.WriteLine(resultadofinal);
					resultadofinal = "\nEsta operacion fue realizada: ###################### El ["+DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm:tt] ####################");
					Console.ReadKey();
					Console.WriteLine("\n¿Quiere realizar otra operacion? Si o No");
					confirmacion = Console.ReadLine().ToLower();
					if(confirmacion == "si"){
						Console.Clear();
						Console.WriteLine("Regresando al menu...");
						Menu(historial);
					}else{
						Console.Clear();
						Console.WriteLine("Vuelva pronto.");
						Console.ReadKey();
					}
				break;

					case "promedio":
						Console.Clear();
						Console.WriteLine("Introduce un operando: ");
						operando1 = Convert.ToDouble(Console.ReadLine());
						Console.WriteLine("Introduce un operando: ");
						operando2 = Convert.ToDouble(Console.ReadLine());
						Console.WriteLine("Introduce un operando: ");
						operando3 = Convert.ToDouble(Console.ReadLine());
						Console.WriteLine("Introduce un operando: ");
						operando4 = Convert.ToDouble(Console.ReadLine());
						resultado = promedio(operando1,operando2,operando3,operando4);
						resultadofinal = "El resultado de la operación {"+lector+"}: "+operando1.ToString()+" + "+operando2+" + "+operando3+" + "+operando4+" / 4 = "+resultado+"\n Esta operacion fue realizada: ###################### El ["+DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm:tt] ####################");
						if(resultado <= 70){
					Console.WriteLine("Reprobado: D");
						}
					else if(resultado >= 71 && resultado <= 79){
						Console.WriteLine("Promedio Bajo: C");
					}else if(resultado >= 80 && resultado <= 89){
						Console.WriteLine("Promedio Medio: B");
					}else if(resultado >= 91 && resultado <= 90){
						Console.WriteLine("Promedio Alto: A");
					}else{
						Console.WriteLine("Felicidades, sacaste: A++");
					}
						Console.ReadKey();
						historial[0] = resultadofinal;
					Console.WriteLine("\n¿Quiere realizar otra operacion? Si o No");
					confirmacion = Console.ReadLine().ToLower();
					if(confirmacion == "si"){
						Console.Clear();
						Console.WriteLine("Regresando al menu...");
						Menu(historial);
					}else{
						Console.Clear();
						Console.WriteLine("Vuelva pronto.");
						Console.ReadKey();
					}	
					break;

				case "historial":
					Console.WriteLine(historial[0]);
					Console.ReadKey();
					Console.Clear();
					Menu(historial);
					Console.ReadKey();	
				break;

				case "salir":
					Console.WriteLine("Vuelva pronto...");
					Console.ReadKey();
				break;

				default:
					Console.WriteLine("\nIntroduce una opción valida.");
					Console.ReadKey();
					Console.Clear();
					Menu(historial);
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
		}public static double promedio(double operador1, double operador2, double operador3, double operador4){
			return (operador1+operador2+operador3+operador4)/4;
		}
	}
}
