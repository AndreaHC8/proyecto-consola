using System;

public class Vehiculo 
{
   public string mensajedeEntrada { get; set;}

   public void Ejecutar ()
   {
     Console.Writeline(mensajedeSalida);

     mensajedeEntrada = Console.ReadLine();

     Console.WriteLine (mensajedeSalida + mensajedeEntrada );
     
   }
}

