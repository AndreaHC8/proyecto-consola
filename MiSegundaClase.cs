using System;

namespace consola
{

     public class MiSegundaClase
     {
         public MiSegundaClase()
         {
         }
         public MiSegundaClase(int numeroEntrada, string mensaje)
         {
            this.NumeroEntrada = numeroEntrada;
            this.Mensaje = mensaje;
         }
          public string Mensaje { get; set; }
          public int NumeroEntrada { get; set; }


          public void IncrementarCinco ()
          {
             int incremento = 1;

             while (incremento < 5)
             {
                NumeroEntrada++;
                Console.WriteLine(NumeroEntrada);
                incremento++;
             }
               

          }
          
          public void Escribir ()
          {
             Console.WriteLine (Mensaje + NumeroEntrada.ToString());
          }
          public void AlejardelCero ()
          {
             if (NumeroEntrada >=0)
             {
                NumeroEntrada++;
             }
             else 
             {
                NumeroEntrada --;
             }
          }
     
}
}