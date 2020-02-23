using PruebaTecnica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace PruebaTecnica.Models
{
    public class TextFile : AFile, IDisposable
    {
        /// <summary>
        /// Is this instance disposed?
        /// </summary>
        protected bool Disposed { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_NameFile"></param>
        public TextFile(string _NameFile) : base(@"/Utils/", _NameFile) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_RootPath"></param>
        /// <param name="_NameFile"></param>
        public TextFile(string _RootPath, string _NameFile) : base(_RootPath, _NameFile) { }

        /// <summary>
        /// Load the file
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

                IList<Person> people = new List<Person>();

                // The text file is read line by line
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    int Count = 0;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Check that we don't read the header line
                        if (Count > 0)
                        {
                            // Divide the string by the separator
                            string[] strSplit = line.Split("|");

                            people.Add(new Person
                            {
                                Name = strSplit[0],
                                City = strSplit[1],
                                PhoneNumber = strSplit[2]
                            });
                        }
                        else
                        {
                            Count++;
                        }

                    }

                    reader.Close();
                }

                return people;
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error --> {e.Message}");
                return new List<Person>();
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
