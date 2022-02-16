using System;

public class MiPrimeraClase
{
   public string MensajedeSalida { get; set;}
   public string MensajedeEntrada { get; set;}
   public void Ejecutar ()
   {
     Console.WriteLine(MensajedeSalida);
     MensajedeEntrada = Console.ReadLine();

     Console.WriteLine(MensajedeSalida + MensajedeEntrada);
     }
   
}


