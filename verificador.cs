using System;


class Verificador{

    public static bool verficiar_email(string email){
        if (!(email.Contains("@"))){
            return false;
        }
        string[] email_dividido = email.Split("@");
        string correo = email_dividido[0];
        if (!(Char.IsLetter(correo[0]))){
            return false;
        }
        if (!(email_dividido[1].Contains("."))){
            return false;
        }

        email_dividido = email_dividido[1].Split(".");
        string dominio = email_dividido[0];
        string terminacion = email_dividido[1];
        string[] dominios_validos = {"gmail", "hotmail", "live"};
        string[] terminaciones_validas = {"com", "co", "edu", "org"};
        if (!(Array.Exists( dominios_validos, element => element == dominio))){
            return false;
        }
        if (!(Array.Exists( terminaciones_validas, element => element == terminacion))){
            return false;
        }
        if(terminacion == "edu"){
            if(!(email_dividido.Length == 3)){
                return false;
            }
            else{
                if(!(email_dividido[2] == "co")){
                    return false;
                }
            }
        }
        return true;
    }

    public static bool verificar_edad(int edad){
        if(edad>=18){
            return true;
        }
        return false;
    }
}
