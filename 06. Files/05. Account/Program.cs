using System.Text;


var pathFile = "Accounts.txt"; // Accounts.txt is in the root folder of the project (06. Files\05. Account\Contas.txt)


// Write a buffer in console
void WriteBuffer(byte[] buffer, int BytesRead)
{
    var utf8 = new UTF8Encoding(); // Create a UTF8 object

    var text = utf8.GetString(buffer, 0, BytesRead); // Convert the buffer in text
    Console.Write(text);
}


void FileClass()
{
    // Write the amount of lines in the console
    var lines = File.ReadAllLines(pathFile);
    Console.WriteLine($"The file has {lines.Length} lines"); 

    // Write all the lines in the console
    foreach (var line in lines)
    {
        Console.WriteLine(line);
    }

    // Write the amount of bytes in the console
    var bytesRead = File.ReadAllBytes(pathFile);
    Console.WriteLine($"The file has {bytesRead.Length} bytes.");

    // Write the name in the file
    File.WriteAllText("Name.txt", "Victor Martins");
}


void LidandoComFileStream()
{   
    // Open file with FileStream
    using (var fileStream = new FileStream(pathFile, FileMode.Open)) // FileMode.Open will open an existing file
    {
        var NumbersOfBytsRead = -1;

        var buffer = new byte[1024]; // Create a buffer with 1024 bytes

        // While the file has bytes to read 
        while(NumbersOfBytsRead != 0)
        {
            NumbersOfBytsRead = fileStream.Read(buffer, 0, 1024); // Read the file and save in buffer
            WriteBuffer(buffer, NumbersOfBytsRead);
        }

        // Close the file
        fileStream.Close();
    }
}


FileClass();

/*
Output:

The file has 1000 lines
375,4644,2483.13,Jonatan Silva
234,4020,2822.52,Debora
316,3254,3350.37,Leonardo
...
...
The file has 25166 bytes.
*/


LidandoComFileStream();

/*
Output (Nome.txt):

Victor Martins
*/

