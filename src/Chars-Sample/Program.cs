using System;
using System.IO;
using System.Text;

Console.Write("[ Enter the path to the file] ");
string? path = Console.ReadLine();
CountChars(path);

static void CountChars(string? args) {
    if(args != null) 
    {
        StringBuilder buf = new StringBuilder();
        char[] alphabet = "ABCDEFGHIJKMNOPQRSTUVWXYZ".ToCharArray();
        if(File.Exists(args)) 
        {
            string? s = string.Empty;
            //read the file
            StreamReader reader = new StreamReader(args);
            while((s = reader.ReadLine()) != null) {
                buf.Append(s.ToUpper());
            }
            char[] charArray = buf.ToString().ToCharArray();
            for(var j = 0; j < alphabet.Length;j++) {
                int counter = 0;
                for(var i = 0; i < charArray.Length;i++) 
                {
                    if(alphabet[j] == charArray[i])
                    counter++;
                }
                if(counter > 0)
        Console.WriteLine(" Character {0} : Found {1} coincidence(s)",alphabet[j],counter);                            
            }
        }
        else
    Console.WriteLine("File not found {0} \nUse: CharFrequency [input text] ",args);
    }
    else
        Console.WriteLine("Missing input text \nUse: CharFrequency [input text] ");
}

