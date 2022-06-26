using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class FileStream
    {
        public static Dictionary<string, User> GetUsers()
        {
            try
            {
                string json = File.ReadAllText(fileName);
                users = JsonSerializer.Deserialize<Dictionary<string, User>>(json);

                return users;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("NO SE HA ENCONTRADO EL ARCHIVO");
                return null;
            }
            catch (IOException)
            {
                Console.WriteLine("ERROR DE EJECUCION");
                return null;
            }
        }

        public static void setNewUser(User user)
        {
            try
            {
                users.Add(user.Carnet, user);
                string json = JsonSerializer.Serialize(users);
                File.WriteAllText(fileName, json);

                Console.WriteLine("SE CREO EL ARCHIVO");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Ha ocurrido un error! \nNo hemos encontrado la ruta del archivo especificado");
            }
            catch (IOException)
            {
                Console.WriteLine("Ha ocurrido un error! \nLa ejecucion del programa ha sido interrumpida\n" + io.toString());
            }
        }


        static string fileName = "users.out";
        static Dictionary<string, User> users = new Dictionary<string, User>();
    }
}
