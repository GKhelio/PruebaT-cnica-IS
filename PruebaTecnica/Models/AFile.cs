using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnica.Models
{
    public abstract class AFile
    {
        /// <summary>
        /// Root path from file
        /// </summary>
        protected string RootPath { get; set; }

        /// <summary>
        /// Name the file
        /// </summary>
        protected string NameFile { get; set; }

        public AFile (string _RootPath, string _NameFile)
        {
            RootPath = _RootPath;
            NameFile = _NameFile;
        }

        /// <summary>
        /// Get text the file
        /// </summary>
        /// <returns></returns>
        public abstract IList<Person> LoadFile();

        /// <summary>
        /// Get path the file
        /// </summary>
        /// <returns></returns>
        public string PathFile()
        {
            return RootPath + NameFile;
        }
    }
}
