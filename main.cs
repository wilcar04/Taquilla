using System;


class Consola{
  Taquilla taquilla = new Taquilla();

  public static void Main(){
      Consola consola = new Consola();
      consola.initial_run();
  }

  void initial_run(){
      Console.WriteLine("Bievenido. Por favor, ingresa la ruta del archivo con los registros de taquilla.");
      obtener_ruta();
      verificar_persona();
  }

  void obtener_ruta(){
    while(true){
      string ruta = Console.ReadLine();
      try{
        taquilla.crear_lista_personas(ruta);
        Console.WriteLine("La lista de registro se ha cargado exitosamente");
        break;
      }
      catch(RutaNoValidaException){
        Console.WriteLine("La ruta ingresada no es válida, por favor, intenta de nuevo");
      }
    }
  }

  void verificar_persona(){
    while(true){
          Console.WriteLine("Ingresa el Id de la persona que deseas verificar");
          string id_ingresado = Console.ReadLine();

          try{
              taquilla.verficiar_persona(id_ingresado);
              Console.WriteLine("La persona con el id: ", id_ingresado, "está registrada y sus datos son válidos");
          }
          catch(CorreoInvalidoException){
              Console.WriteLine("El correo registado de la persona no es válido");
          }
          catch(PersonaNoRegistradaException){
              Console.WriteLine("El id ingresado no está registado");
          }
          catch(EdadInvalidaException){
              Console.WriteLine("La persona no es mayor de edad");
          }

      }
  }
}
