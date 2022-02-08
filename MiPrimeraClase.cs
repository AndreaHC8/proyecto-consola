using System;

public class MiPrimeraClase
{
   public string mensajedeSalida { get; set;}
   public string MensajedeEntrada { get; set;}
   public void Ejecutar ()
   {
     Console.WriteLine(mensajedeSalida);
     MensajedeEntrada = Console.ReadLine();

     Console.WriteLine(mensajedeSalida + MensajedeEntrada);
     }
   
}


