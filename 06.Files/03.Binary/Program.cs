var pathFile = Path.Combine(Environment.CurrentDirectory, "06.Files/03.Binary/WriteBinary.csv");


void WriteBinary()
{
    // Create a file with FileStream
    using (var fileStream = new FileStream(pathFile, FileMode.Create)) // FileMode.Create will create a new file or overwrite an existing one

    // Create a binary writer
    using (var writer = new BinaryWriter(fileStream))
    {
        Console.WriteLine($"File created! [{pathFile}]"); // Write in console the path of the file

        // Write in file in binary
        writer.Write("Victor Martins");
        writer.Write(515);
        writer.Write(21543.21);
    }
}

void ReadBinary()
{
    // Open file with FileStream
    using (var fileStream = new FileStream(pathFile, FileMode.Open)) // FileMode.Open will open an existing file

    // Create a binary reader
    using (var reader = new BinaryReader(fileStream))
    {
        // Read file in binary
        var holder = reader.ReadString(); 
        var number = reader.ReadInt32(); 
        var balance = reader.ReadDouble();

        Console.WriteLine($"Holder: {holder}\nNumber: {number}\nBalance: {balance}");
    }
}

WriteBinary();

ReadBinary();

/*
Output:

File created! [path of the file]

Holder: Victor Martins
Number: 515
Balance: 21543.21
*/