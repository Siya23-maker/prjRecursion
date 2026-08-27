using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFileSearch
{
    class Folder
    {
        public string Name { get; set; }

        public List<string> strings { get; set; }

        public List<Folder> SubFolders { get; set; } = new List<Folder>();

        public Folder(string name)
        {
            Name = name;
        }
        public void AddFile(string fileName)
        {

            Files.Add(fileName);
        }
        public void AddSubFolder(Folder folder)
        {
           SubFolders.Add(folder);
        }
    }
}
