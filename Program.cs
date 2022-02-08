using System;

namespace consola
{
         class Program
      {
                static void Main(string [] args)
        {
                MiSegundaClase miSegundaClase = new MiSegundaClase();
                miSegundaClase.Mensaje = "Este es el numero de entrada";
                miSegundaClase.NumeroEntrada = 1;
                miSegundaClase.IncrementarCinco();
                miSegundaClase.Escribir ();

                Console.ReadKey();
        }  
                

        
        
      }  
}  
