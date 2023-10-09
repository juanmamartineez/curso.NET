using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Wcf_Service
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class User : IUser
    {
        public List<Users> GetUsers()
        {
            return new List<Users>
            {
                new Users
                {
                    Id = 1,
                    Name = "Juan Manuel",
                    LastName = "Martinez",
                    Dni = 39323840,
                    Age = 27
                },
                new Users
                {
                    Id = 2,
                    Name = "Juan Carlos",
                    LastName = "Paz",
                    Dni = 20333444,
                    Age = 52
                },
                new Users
                {
                    Id = 3,
                    Name = "María",
                    LastName = "Colombo",
                    Dni = 30444555,
                    Age = 42
                }
            };
        }
    }
}
