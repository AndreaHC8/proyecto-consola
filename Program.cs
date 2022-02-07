using System;

namespace Console ;

class Program ;
 {
 static void Main (string [] args);
        string mensajedeSalida;

        mensajedeSalida = "HC4L";
        Console.WriteLine (mensajedeSalida) ;

        mensajedeSalida = "Intentando programar";
        Console.Write(mensajedeSalida);
        mensajedeSalida = Console.Readline ();
       Console.WriteLine("Tu mensaje es:" + mensajedeSalida);
       Console.Readline() ;
    }  
 }