using PruebaTecnica.Models;
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace PruebaTecnica.Models
{
    public class JsonFile : AFile, IDisposable
    {
        /// <summary>
        /// Is this instance disposed?
        /// </summary>
        protected bool Disposed { get; private set; }

        /// <summary>
        /// Constuctor
        /// </summary>
        /// <param name="_NameFile"></param>
        public JsonFile(string _NameFile) : base(@"/Utils/", _NameFile) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_RootPath"></param>
        /// <param name="_NameFile"></param>
        public JsonFile(string _RootPath, string _NameFile) : base(_RootPath, _NameFile) { }

        /// <summary>
        /// Load the file to parse Person
        /// </summary>
        /// <returns></returns>
        public override IList<Person> LoadFile()
        {
            try
            {
                string path = base.PathFile();

                if (!File.Exists(path))
                {
                    throw new IOException("Path the file not exists.");
                }

                // Read Json file
                var myJsonString = File.ReadAllText(path);

                // File parse
                return JsonConvert.DeserializeObject<IList<Person>>(myJsonString);
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error --> {e.Message}");
                return new List<Person>();
            }
        }

        /// <summary>
        /// Write the file
        /// </summary>
        /// <param name="people"></param>
        /// <param name="path"></param>
        /// <returns>
        ///     1 = Ok,
        ///     2 = The File already exists,
        ///     3 = Error
        /// </returns>
        public int WriteFile(IList<Person> people, string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    return 2;
                }

                // Parse the people to string
                string JsonToText = JsonConvert.SerializeObject(people);

                // Write File
                File.WriteAllText(path, JsonToText);

                // ok
                return 1;
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error --> {e.Message}");
                return 3;
            }
        }

        public void Dispose()
        {
            Dispose(true); 
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Dispose
        /// </summary>
        /// <param name="disposing">Are we disposing? 
        /// Otherwise we're finalizing.</param>
        protected virtual void Dispose(bool disposing)
        {
            Disposed = true;
        }
    }
}
