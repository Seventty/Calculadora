using System; 
namespace algo{
   class calculadora{
        public static void Main(){
 			Console.WriteLine("Introduce el operador: Suma, Resta, Division, Multiplicacion.");
 				string lector = Console.ReadLine().ToLower();
 				switch(lector){
 					case "suma":
 					Console.Clear();
 					suma();
 					break;	

 					default:
 						Console.WriteLine("Introduce una opcion valida.");
 						Console.ReadKey();
 						Console.Clear();
 						Main();
 					break;
 			}


        }public static void suma(){
        	Console.WriteLine("¿Cuantos digitos vas a sumar?");
 					int respuesta = Convert.ToInt32(Console.ReadLine());
 					if(respuesta == 1){
 						Console.WriteLine("No puede hacer ninguna operacion solo con un operando.");
 						Console.ReadKey();
 						Console.Clear();
 						suma();
 			}int[] operandos = new int[respuesta];
 				for()

        }
    }
}