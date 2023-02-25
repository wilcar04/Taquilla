using System.Collections.Generic;


abstract class LectorArchivo{

    public abstract Dictionary<string, Persona> leer_archivo(string ruta);
}
