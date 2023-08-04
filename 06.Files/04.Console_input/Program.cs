var pathFile = Path.Combine(Environment.CurrentDirectory, "06.Files/04.Console_input/inflow.txt");


void UsarStreamDeEntrada()
{
    // Create a stream with Console.OpenStandardInput()
    using (var inflow = Console.OpenStandardInput())

    // Create a file with FileStream
    using (var fileStream = new FileStream(pathFile, FileMode.Create)) // FileMode.Create will create a new file or overwrite an existing one
    {
        Console.WriteLine($"File created! [{pathFile}]"); // Write in console the path of the file

        // Create a buffer with 1024 bytes
        var buffer = new byte[1024];

        while (true)
        {
            var bytesRead = inflow.Read(buffer, 0, 1024); // Read the stream and save in buffer

            fileStream.Write(buffer, 0, bytesRead); // Write the buffer in the file
            fileStream.Flush(); // Clean the buffer
        }
    }
}

UsarStreamDeEntrada();
/*
Output:

File created! [path of the file]

Hello World!
In file: Hello World!

Good Morning!
In file: Good Morning!

*/