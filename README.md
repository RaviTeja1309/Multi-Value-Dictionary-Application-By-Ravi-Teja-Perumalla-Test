                            ////////////////Multi-Value Dictionary Application By Ravi Teja Perumalla//////////////
                            
The Multi-Value Dictionary app is a command line application that stores a multivalue dictionary in memory. All keys and members are strings.
It should support the following commands.

Documentation - 
List of available operations that can be performed in the console

KEYS, MEMBERS, ADD, REMOVE, REMOVEALL, CLEAR, KEYEXISTS, MEMBEREXISTS, ALLMEMBERS, ITEMS


KEYS - 
Returns all the keys in the dictionary. Order is not guaranteed.

Example
![image](https://user-images.githubusercontent.com/9721887/138008653-e8d62d53-b90e-4ceb-8db4-2cded94269b2.png)

MEMBERS - 
Returns the collection of strings for the given key. Return order is not guaranteed. Returns an error if the key does not exists.
Example:
![image](https://user-images.githubusercontent.com/9721887/138008691-f9494814-786e-450d-b98e-3d9cfcd53433.png)


ADD - 
Adds a member to a collection for a given key. Displays an error if the member already exists for the key.
![image](https://user-images.githubusercontent.com/9721887/138008712-d58ed628-3442-434e-9baa-faee2c0e7859.png)


REMOVE - 
Removes a member from a key. If the last member is removed from the key, the key is removed from the dictionary. If the key or member does not exist, displays an
error.
Example:
![image](https://user-images.githubusercontent.com/9721887/138008734-43cf02af-ea47-4b18-a2f7-da06434c4e57.png)


REMOVEALL - 
Removes all members for a key and removes the key from the dictionary. Returns an error if the key does not exist.
Example:
![image](https://user-images.githubusercontent.com/9721887/138008747-e1896fbf-6d89-44ac-9f8a-80a68ebcaf9e.png)


CLEAR - 
Removes all keys and all members from the dictionary.
Example:
![image](https://user-images.githubusercontent.com/9721887/138008756-1b2ed250-1d22-48c2-a20f-5bdb9a7b8864.png)


KEYEXISTS - 
Returns whether a key exists or not.
Example:
![image](https://user-images.githubusercontent.com/9721887/138008778-fe32416b-e8ec-47df-9606-980d0464cc4d.png)


MEMBEREXISTS - 
Returns whether a member exists within a key. Returns false if the key does not exist.
Example:
![image](https://user-images.githubusercontent.com/9721887/138008794-eb2a922a-6300-4c99-9ef2-902421c2625c.png)

ALLMEMBERS - 
Returns all the members in the dictionary. Returns nothing if there are none. Order is not guaranteed.
Example:
![image](https://user-images.githubusercontent.com/9721887/138008809-978c6134-2ba0-4132-84a1-f515c6a00d7c.png)



ITEMS - 
Returns all keys in the dictionary and all of their members. Returns nothing if there are none. Order is not guaranteed.
Example:
![image](https://user-images.githubusercontent.com/9721887/138008840-cc78ad9a-54c8-46ee-a330-03f773ab0d33.png)

Application Requirements

Visual Studio 2019 and .NET 5 or Any .Net framework 

Step 1: Download the code in the zip

Step 2: Extract the zip 

Step 3: If VisualStudio 2019 and .NET 5 is already installed please click on the Spreetail.csproj if not please install using helpful link

Step 4: Bulid the project. 

Step 5: Press F5 or right click on the project and select Debug and start a new instance.


Helpful link
1. Download VS 2019 - https://visualstudio.microsoft.com/downloads/
2. Install .NET 5 - https://dotnet.microsoft.com/download/dotnet/5.0
