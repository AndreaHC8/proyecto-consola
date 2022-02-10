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

          public void Incremetar()
        {
            if (NumeroEntrada >= 0)
            {
                NumeroEntrada++;
            }
        }

           public void PintarLetras()
        {
            for(int i = 0; i < Mensaje.Length; i++)
            {
                Console.WriteLine(Mensaje[i]);
            }
        }


          public void IncrementarCinco ()
          {
             for (int x = 1; x < 6 ; x++);
             {
                NumeroEntrada++;
                Console.WriteLine(NumeroEntrada);
             }
               

          }
          
          public void AlejardelCero ()
          {
             if (NumeroEntrada >=0)
             {
                NumeroEntrada++;
             }
             else if (NumeroEntrada < 0)
             {
                NumeroEntrada --;
             }
             else 
            {
                Console.WriteLine("Numero de entrada es cero");
             }

          }

          public void Escribir ()
          {
             Console.WriteLine (Mensaje + NumeroEntrada.ToString());
          }

          
      }
}
