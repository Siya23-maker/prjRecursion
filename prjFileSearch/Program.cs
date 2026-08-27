namespace prjFileSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Start of our folder Syatem 
            Folder documents = new Folder("My Documents");
            Folder school = new Folder("School");
            Folder math = new Folder("Math");
            Folder pictures = new Folder("Picture");

            //Adding files into these Folders
            pictures.AddFile("vacation.jpg");
            school.AddFile("syllabus.pdf");
            math.AddFile("Homework.txt");

            //Add Subfolders into the main folders
            school.AddSubFolder(math);
            documents.AddSubFolder(school);
            documents.AddSubFolder(pictures);

            //Lets say you are searching for a a specific document...
            Console.WriteLine("Starting seacrh: ...\n");

            //Recursion
            SearchForFile(documents, "Homework.txt");
        }

        //Recursion method
        static bool SearchForFile(Folder currentFolder, string targetFileName)
        {
            //This will show the different folders that the program is looking in
            Console.WriteLine($"Looking inside folder: {currentFolder}");

            //Base Case: Stops when the Condition is met or else ecursion gos on forever
            foreach (string file in currentFolder.Files)
            {
                if (file == targetFileName)
                {
                    Console.WriteLine($"Found {targetFileName} inside {currentFolder}");
                    return true;
                }
            }
            //Recursion Case 
            foreach (Folder subFolder in currentFolder.SubFolders)
            {
                //recursion call
                bool wasFound = SearchForFile(subFolder, targetFileName);

                //If the folder is found 
                if (wasFound)
                {
                    return true;
                }
            }
            return false;
        }
    }
}