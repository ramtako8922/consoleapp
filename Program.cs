// See https://aka.ms/new-console-template for more information
using Humanizer;

string[] userNames = new string[10] { "", "", "", "", "", "", "", "", "", "" };
            int arrayCurrentIndex=0;
            int edad=35;
            bool userType;
            string userToSearch;
            Console.WriteLine("Bienvenido al mejor restuarrante del mundo");
                while(arrayCurrentIndex<10)
            {

                /*if(arrayCurrentIndex ==10)
                {
                    Console.WriteLine("El restaurante esta lleno por favor intenta el otro año");
                    Environment.Exit(0);
                }*/
                Console.WriteLine("\n\nEstas registrado ?, escribe true o escribe false para registrarte");
                userType=Convert.ToBoolean(Console.ReadLine());
                if (userType == true)
                {
                    Console.WriteLine("Hola eres un usuario registrado ingresa tu nombre de usuario");
                    userToSearch=Console.ReadLine();
                    Console.WriteLine("El usuario registrado es {0} tu edad es {1}",userToSearch,edad.ToWords());
                    int index=Array.IndexOf(userNames,userToSearch);

                    if (index == -1)
                    {
                        Console.WriteLine("El usuario noo existe debes registrarlo");
                    }
                    else
                    {
                        Console.WriteLine("Bienvenido {0}, estamos par servirte",userNames[index]);
                    }
                }else if (userType == false)
                {
                    Console.WriteLine("Ingre un nombre de usuario que siempre recuerde para registrar");
                    userNames[arrayCurrentIndex] =Console.ReadLine();
                    Console.WriteLine("Usuario registrado con exito\n"+"El nombre de usuario es {0}",userNames[arrayCurrentIndex]);
                    arrayCurrentIndex++;


                }
            }
            Console.WriteLine("El restaurante esta lleno por favor intenta el otro año\n" +"La lista de invitados esta compuesta por: ");
            int auxIndex = 0;
            foreach (string auxName in userNames)
            {
                auxIndex++;
                Console.WriteLine("Numero: {0} Nombre:{1}", auxIndex, userNames[auxIndex]);
            }
            Environment.Exit(0);