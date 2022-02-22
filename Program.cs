using System;

namespace consola
{
    class Program
    {
        static void Main(string[] args)
        {
             
            
            MiSegundaClase miSegundaClase = new MiSegundaClase();
            miSegundaClase.Mensaje = "Este es el número de entrada: ";
            miSegundaClase.NumeroEntrada = 1;
            miSegundaClase.Incremetar();
            miSegundaClase.Escribir();

            Console.ReadKey();
        }
    }
    
}
