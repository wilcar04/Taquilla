using System.Collections.Generic;

public class Taquilla{
    Dictionary<string, Persona> personas = new Dictionary<string, Persona>();
    Verificador verificador = new Verificador();

    Persona obtener_persona(string id_ingresado){
        foreach(string id in personas.Keys){
            if(id == id_ingresado){
                return personas[id];
            }
        }
        return null;
    }

    public void crear_lista_personas(string ruta){
        string tipo = ruta.Substring(ruta.Length - 3);
        LectorArchivo lector;
        if(tipo == "txt"){
            lector = new LectorTXT();
        }
        else if(tipo == "csv"){
            lector = new LectorCSV();
        }
        else{
          throw new RutaNoValidaException();
        }
        Dictionary<string, Persona> dict_personas = lector.leer_archivo(ruta);
        this.personas = dict_personas;
    }

    public void verficiar_persona(string id_ingresado){
        Persona persona = obtener_persona(id_ingresado);
        if(persona == null){
            throw new PersonaNoRegistradaException();
        }
        string email = persona.email;
        if(!(Verificador.verficiar_email(email))){
            throw new CorreoInvalidoException();
        }
        int edad = persona.edad;
        if(!(Verificador.verificar_edad(edad))){
            throw new EdadInvalidaException();
        }
    }
}