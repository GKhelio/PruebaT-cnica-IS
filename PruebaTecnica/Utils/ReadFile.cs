using Newtonsoft.Json.Linq;
using PruebaTecnica.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;

namespace PruebaTecnica.Utils
{
    public class ReadFile
    {
        private static IList<Person> Persons { get; set; }
        private static string PathFile = $@"{Directory.GetCurrentDirectory()}\Utils\persons.json";

        public ReadFile()
        { }

        /// <summary>
        /// Get the list of Persons
        /// </summary>
        /// <returns></returns>
        public static IList<Person> getPersons()
        {
            return Persons;
        }

        /// <summary>
        /// Load the file to parse Person
        /// </summary>
        public static void loadFile()
        {
            try
            {
                if (!File.Exists(PathFile))
                {
                    Persons = null;
                    return;
                }

                // Read Json file
                var myJsonString = File.ReadAllText(PathFile);

                // File parse to Person model
                Persons = JsonConvert.DeserializeObject<IList<Person>>(myJsonString);
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error --> {e.Message}");
            }
        }
    }
}
