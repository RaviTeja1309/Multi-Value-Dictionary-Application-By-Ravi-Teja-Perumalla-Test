using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace Spreetail
{
    class Program
    {
        static void Main(string[] args)
        {
            BeginApplication();
            UserInputs();
        }

        /// <summary>
        /// Welcome Message
        /// </summary>
        public static void BeginApplication()
        {
            string entermessage = "////////////////Multi-Value Dictionary Application By Ravi Teja Perumalla//////////////\n";
            entermessage += "Please find the below available actions to perform on this Dictionary\n";
            entermessage += "KEYS -" + Actions.KEYS + "\n";
            entermessage += "MEMBERS -" + Actions.MEMBERS + "\n";
            entermessage += "ADD -" + Actions.ADD + "\n";
            entermessage += "REMOVE -" + Actions.REMOVE + "\n";
            entermessage += "REMOVEALL -" + Actions.REMOVEALL + "\n";
            entermessage += "CLEAR -" + Actions.CLEAR + "\n";
            entermessage += "KEYEXISTS -" + Actions.KEYEXISTS + "\n";
            entermessage += "MEMBEREXISTS -" + Actions.MEMBEREXISTS + "\n";
            entermessage += "ALLMEMBERS -" + Actions.ALLMEMBERS + "\n";
            entermessage += "ITEMS -" + Actions.ITEMS + "\n";
            entermessage += "EXIT -" + Actions.EXIT + "\n";
            Console.WriteLine(entermessage);
        }

        /// <summary>
        ///  User Input and perform the correction action
        /// </summary>
        private static void UserInputs()
        {
            var response = new SpreetailDictionary<string, string>();
            while(true)
            {
                var userinputs = Console.ReadLine();
                try
                {
                    var listOfuserinput = userinputs.Split(" ");
                    switch (listOfuserinput[0].ToUpper())
                    {
                        case "KEYS":
                            if (listOfuserinput.Length > 0)
                            {
                                response.GetKeys();
                            }
                            else
                            {
                                Console.WriteLine("Please enter atleast one key and value");
                            }
                            break;
                        case "MEMBERS":
                            if (listOfuserinput.Length > 0)
                            {
                                response.GetMemebers(listOfuserinput[1]);
                            }
                            else
                            {
                                Console.WriteLine("Please enter atleast one key and value");
                            }
                            break;
                        case "ADD":
                            if (listOfuserinput.Length == 3)
                            {
                                response.AddKeyValue(listOfuserinput[1], listOfuserinput[2]);
                            }
                            else
                            {
                                Console.WriteLine("Please enter the key and value to be insert");
                            }
                            break;
                        case "REMOVE":
                            if (listOfuserinput.Length == 3)
                            {
                                response.RemoveKeyValue(listOfuserinput[1], listOfuserinput[2]);
                            }
                            else
                            {
                                Console.WriteLine("Please enter the key and value to be insert");
                            }
                            break;
                        case "REMOVEALL":
                            if (listOfuserinput.Length == 2)
                            {
                                response.RemoveAllMemebers(listOfuserinput[1]);
                            }
                            else
                            {
                                Console.WriteLine("Please enter the key and value to be insert");
                            }
                            break;
                        case "CLEAR":
                            if (listOfuserinput.Length == 1)
                            {
                                response.ClearAllItems();
                            }
                            break;
                        case "KEYEXISTS":
                            if (listOfuserinput.Length == 2)
                            {
                                response.KeyExists(listOfuserinput[1]);
                            }
                            else
                            {
                                Console.WriteLine("Please enter atleast one key and one value to check if KeyExists or not");
                            }
                            break;
                        case "MEMBEREXISTS":
                            if (listOfuserinput.Length == 3)
                            {
                                response.MemeberExists(listOfuserinput[1], listOfuserinput[2]);
                            }
                            else
                            {
                                Console.WriteLine("Please enter atleast one key and one value to check if KeyExists or not");
                            }
                            break;
                        case "ALLMEMBERS":
                            if (listOfuserinput.Length == 1)
                            {
                                response.AllMemebers();
                            }
                            else
                            {
                                Console.WriteLine("Please enter atleast one key and one value to check if KeyExists or not");
                            }
                            break;
                        case "ITEMS":
                            if (listOfuserinput.Length == 1)
                            {
                                response.Items();
                            }
                            else
                            {
                                Console.WriteLine("Please enter atleast one key and one value to check if KeyExists or not");
                            }
                            break;
                        case "EXIT":
                            Console.WriteLine("Multi Value Dictionary Console Application exited");
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("No Action Found");
                            break;

                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(
                        "Action not valid. Please type EXIT to close.");
                }
            }
        }
    }
}
