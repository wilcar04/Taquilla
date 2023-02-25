using System;
using System.IO;
using System.Collections.Generic;


class LectorCSV: LectorArchivo{

    public override Dictionary<string, Persona> leer_archivo(string ruta){
        Dictionary<string, Persona> personas = new Dictionary<string, Persona>();
        using (var sr = new StreamReader(ruta)){
          string info = sr.ReadLine();
          info = sr.ReadLine();
          while(!sr.EndOfStream){
              string[] lista_info = info.Split("**");
              Persona persona = new Persona(lista_info[0], lista_info[1], lista_info[2], Convert.ToInt32(lista_info[3]));
              personas.Add(lista_info[1], persona);
              info = sr.ReadLine();
          }
        }
        return personas;
    }
}
