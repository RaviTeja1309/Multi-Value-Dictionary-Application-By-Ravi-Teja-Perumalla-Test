using System;
using System.Collections.Generic;
using System.Linq;

namespace SpreetailConsole
{
    public class SpreetailDictionary<TKey, TValue> : Dictionary<TKey, List<TValue>>
    {
        /// <summary>
        /// Get All Keys
        /// </summary>
        public void GetKeys()
        {
            if (this.Any())
            {
                for (var i = 0; i < this.ToList().Count; i++)
                {
                    Console.WriteLine((i + 1) + ")" + this.ToArray()[i].Key);
                }
            }
            else
            {
                Console.WriteLine("(empty set)");
            }

        }

        /// <summary>
        ///  Get AllMemeber per key
        /// </summary>
        public void GetMemebers(TKey key)
        {
            if (TryGetValue(key, out List<TValue> valueList))
            {
                for (var i = 0; i < valueList.Count; i++)
                {
                    Console.WriteLine((i + 1) + ")" + valueList[i]);
                }
            }
            else
            {
                Console.WriteLine("ERROR, key does not exist.");
            }

        }

        /// <summary>
        /// Add a key and Value
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void AddKeyValue(TKey key, TValue value)
        {
            if (TryGetValue(key, out List<TValue> valueList))
            {
                if (valueList.Any(x => x.Equals(value)))
                {
                    Console.WriteLine("ERROR, member already exists for key");
                    return;
                }
                valueList.Add(value);
            }
            else
            {
                Add(key, new List<TValue> { value });
            }
            Console.WriteLine("Added");
        }

        /// <summary>
        /// Removes all members for a key and removes the key from the dictionary. Returns an error if the key does not exist.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void RemoveKeyValue(TKey key, TValue value)
        {
            if (TryGetValue(key, out List<TValue> valueList))
            {
                if (valueList.Count > 1 && valueList.Any(x => x.Equals(value)))
                {
                    valueList.Remove(value);
                }
                else if (valueList.Count == 1 && valueList.Any(x => x.Equals(value)))
                {
                    valueList.Remove(value);
                    Remove(key);
                }
                else if (!valueList.Any(x => x.Equals(value)))
                {
                    Console.WriteLine("ERROR, member does not exist");
                    return;
                }
            }
            else if (!this.Any(x => x.Equals(key)))
            {
                Console.WriteLine("ERROR, key does not exist");
                return;
            }
            Console.WriteLine("Removed");
        }

        /// <summary>
        /// Removes all members for a key and removes the key from the dictionary. Returns an error if the key does not exist.
        /// </summary>
        /// <param name="key"></param>
        public void RemoveAllMemebers(TKey key)
        {
            if (this.Any(x => x.Key.Equals(key)))
            {
                Remove(key);
                Console.WriteLine("Removed");

            }
            else
            {
                Console.WriteLine("ERROR, key does not exist");
            }
        }

        /// <summary>
        ///Removes all keys and all members from the dictionary.
        /// </summary>
        public void ClearAllItems()
        {
            Clear();
            Console.WriteLine(") Cleared");
        }

        /// <summary>
        /// Returns whether a key exists or not.
        /// </summary>
        /// <param name="key"></param>
        public void KeyExists(TKey key)
        {
            Console.WriteLine(this.Any(x => x.Key.Equals(key)));
        }

        /// <summary>
        /// Returns whether a member exists within a key. Returns false if the key does not exist.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void MemeberExists(TKey key, TValue value)
        {
            TryGetValue(key, out List<TValue> valueList);
            if (valueList != null && valueList.Any())
            {
                Console.WriteLine(valueList.Any(x => x.Equals(value)));
            }
            else
            {
                Console.WriteLine(false);
            }
        }

        /// <summary>
        /// Returns all the members in the dictionary. Returns nothing if there are none. Order is not guaranteed.
        /// </summary>
        public void AllMemebers()
        {
            if (this.Any())
            {
                var displaypurpose = new List<TValue>();
                foreach (var value in this.Select(x => x.Value))
                {
                    displaypurpose.AddRange(value);
                }
                for (var i = 0; i < displaypurpose.Count; i++)
                {
                    Console.WriteLine((i + 1) + ")" + displaypurpose[i]);
                }
            }
            else
            {
                Console.WriteLine("(empty set)");
            }
        }

        /// <summary>
        /// Returns all keys in the dictionary and all of their members. Returns nothing if there are none. Order is not guaranteed.
        /// </summary>
        public void Items()
        {
            if (this.Any())
            {
                var j = 1;
                foreach (var key in this.Keys)
                {
                    TryGetValue(key, out List<TValue> valueList);
                    foreach (var value in valueList)
                    {
                        Console.WriteLine(j++ + ")" + key + ":" + value);
                    }
                }
            }
            else
            {
                Console.WriteLine("(empty set)");
            }

        }
    }
}
