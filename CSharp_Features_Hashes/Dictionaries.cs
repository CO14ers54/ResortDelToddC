using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Features_Hashes
{
    class Dictionaries
    {
        public static void Dictionary_VerySimpleExample()
        {
            Dictionary<string, string> cities = new Dictionary<string, string>(){
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
                };

            foreach(KeyValuePair<string, string> kvp in cities)
            {
                Console.WriteLine("Key: {0} Value: {1}", kvp.Key, kvp.Value);
            }
        }

        public static void Dictionary_FindDuplicateFileInSystem()
        {
            string[] paths = { "root/a 1.txt(abcd) 2.txt(efgh)", "root/c 3.txt(abcd)", "root/c/d 4.txt(efgh)", "root 4.txt(efgh)" };

            IList<IList<string>> results = FindDuplicateFiles(paths);

            int i = 0;
            foreach (var result in results)
            {
                Console.WriteLine("Content {0}", i);
                foreach(string str in result)
                {
                    Console.WriteLine(str);
                }
                i++;
            }
        }

        /*
            Given a list of directory info including directory path, and all the files with contents in this directory, you need to find out all the groups of duplicate files in the 
            file system in terms of their paths.

            A group of duplicate files consists of at least two files that have exactly the same content.

            A single directory info string in the input list has the following format:

            "root/d1/d2/.../dm f1.txt(f1_content) f2.txt(f2_content) ... fn.txt(fn_content)"

            It means there are n files (f1.txt, f2.txt ... fn.txt with content f1_content, f2_content ... fn_content, respectively) in directory root/d1/d2/.../dm. 
            Note that n >= 1 and m >= 0. If m = 0, it means the directory is just the root directory.

            The output is a list of group of duplicate file paths. For each group, it contains all the file paths of the files that have the same content. A file path is a string that 
            has the following format:

            "directory_path/file_name.txt"

            Example 1:

            Input:
            ["root/a 1.txt(abcd) 2.txt(efgh)", "root/c 3.txt(abcd)", "root/c/d 4.txt(efgh)", "root 4.txt(efgh)"]
            Output:  
            [["root/a/2.txt","root/c/d/4.txt","root/4.txt"],["root/a/1.txt","root/c/3.txt"]]         
        */

        public static IList<IList<string>> FindDuplicateFiles(string[] paths)
        {
            List<IList<string>> output = new List<IList<string>>();
            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

            foreach(string path in paths)
            {
                string[] splitStrings = path.Split(' ');

                for (int i = 1; i < splitStrings.Length; i++)
                {
                    string[] nameContent = splitStrings[i].Split('(');
                    string fileContent = nameContent[1].Replace(")", "");

                    if (!map.ContainsKey(fileContent))
                    {
                        map.Add(fileContent, new List<string>());
                    }
                    map[fileContent].Add(splitStrings[0] + "/" + nameContent[0]);
                }
            }

            foreach(var key in map.Keys)
            {
                if(map[key].Count > 1)
                {
                    output.Add(new List<string>(map[key]));
                }
            }

            return output;
        }
    }
}
