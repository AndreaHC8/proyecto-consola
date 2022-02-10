using System;

namespace consola
{
         class Program
      {
         //Definir constantes ---> MENSAJE
         const string MENSAJE_INICIAL = "Este es el numero de entrada";
         const int NUMERO_ENTRADA_INICIAL = 1;
         static void Main(string [] args)
             {
                
                MiSegundaClase miSegundaClase = new MiSegundaClase();
                miSegundaClase.Mensaje = MENSAJE_INICIAL; // Sustituyo el texto. 

                miSegundaClase.NumeroEntrada = NUMERO_ENTRADA_INICIAL;
                miSegundaClase.IncrementarCinco();
                miSegundaClase.PintarLetras(); 
                miSegundaClase.Escribir ();

                Console.WriteLine(MENSAJE_INICIAL);

                Console.ReadKey();
              }  
                

        
        
      }  
}  
