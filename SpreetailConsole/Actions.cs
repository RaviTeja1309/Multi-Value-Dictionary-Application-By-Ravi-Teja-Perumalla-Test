using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpreetailConsole
{
    public class Actions
    {
        public static string KEYS = "Returns all the keys in the dictionary. Usage KEYS";
        public static string MEMBERS = "Returns the collection of strings for the given key. Return order is not guaranteed. Returns an error if the key does not exists. USeage MEMBERS <key>";
        public static string ADD = "Adds a member to a collection for a given key. Displays an error if the member already exists for the key. Usage ADD <key> <value>";
        public static string REMOVE = "Removes a member from a key. If the last member is removed from the key, the key is removed from the dictionary. If the key or member does not exist, displays an error. Usage REMOVE <key> <value>";
        public static string REMOVEALL = "Removes all members for a key and removes the key from the dictionary. Returns an error if the key does not exist.. Usage REMOVEALL <key>";
        public static string CLEAR = "Removes all keys and all members from the dictionary. Usage CLEAR";
        public static string KEYEXISTS = "Returns whether a key exists or not. Usage KEYEXISTS <key>";
        public static string MEMBEREXISTS = "Returns whether a member exists within a key. Returns false if the key does not exist. Usage MEMBEREXISTS <key> <value>";
        public static string ALLMEMBERS = "Returns all the members in the dictionary. Returns nothing if there are none. Order is not guaranteed. Usage ALLMEMBERS";
        public static string ITEMS = "Returns all keys in the dictionary and all of their members. Returns nothing if there are none. Order is not guaranteed. Usage ITEMS";
        public static string EXIT = "Exit from console app. Usage EXIT";
    }
}
