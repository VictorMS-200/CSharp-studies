using System.Text;


// Create a file with FileStream and write a string
void CreateFile()
{
    // Create a file with FileStream
    using (var fileStream = new FileStream("ExportedAccounts.csv", FileMode.Create)) // FileMode.Create will create a new file or overwrite an existing one
    {
        var AccountString = "115, 7842, 4725.12, Victor Martins";
        var enconding = Encoding.UTF8;

        // Convert string to bytes
        var bytes = enconding.GetBytes(AccountString);

        // Write bytes in file
        fileStream.Write(bytes, 0, bytes.Length);
    }
}


// Create a file with StreamWriter and write a string
void CreateFileWithWriter()
{
    // Create a file with StreamWriter
    using (FileStream fileStream = new FileStream("ExportedAccounts.csv", FileMode.Create)) // FileMode.Create will create a new file or overwrite an existing one

    // Write in file
    using (StreamWriter writer = new StreamWriter(fileStream))
    {
        writer.Write("154,5438,65.1, Kaul Souza");
    }
}


// Read from console and write in a file
void ConsoleInput()
{
    // Create a file with StreamWriter
    using (FileStream fileStream = new FileStream("test.txt", FileMode.Create)) // FileMode.Create will create a new file or overwrite an existing one

    // Write in file
    using (StreamWriter writer = new StreamWriter(fileStream))
    {
        // Write in file 100 times
        for (int i = 0; i < 100; i++)
        {
            writer.WriteLine($"Line {i}");
            writer.Flush();
            

            Console.WriteLine($"The phase [Line {i}] was written in file. Press enter...");
            Console.ReadLine();
        }
    }
}

CreateFile();
/*
Output (ExportedAccounts.csv):

115, 7842, 4725.12, Victor Martins
*/


CreateFileWithWriter();
/*
Output (ExportedAccounts.csv):

154,5438,65.1,Luiz Souza
*/


ConsoleInput();

/*
Output:

The phase [Line 0] was written in file. Press enter...
The phase [Line 1] was written in file. Press enter...
The phase [Line 2] was written in file. Press enter...
...
The phase [Line 99] was written in file. Press enter...
*/

