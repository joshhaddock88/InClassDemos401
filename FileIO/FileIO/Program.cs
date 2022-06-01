
string filePath = "../../../data.txt"; // You have to reference relative to where the code is.
string newFilePath = "../../../new-data.txt";

/*FileReadAllText(filePath);
FileReadAllTextAsArray(filePath);
FileAddSomeLines(filePath);
FileReadAllText(filePath);*/

FileCreateNewFile(newFilePath);
FileReadAllText(newFilePath);

FileReadAllTextAsBytes(filePath);

static void FileReadAllText(string file)
{
    Console.WriteLine("-----READ AS STRING-----");
    string myContents = File.ReadAllText(file);
    Console.WriteLine(myContents);
}

static void FileReadAllTextAsArray(string file)
{
    Console.WriteLine("------READ AS ARRAY-----");
    string[] myContents = File.ReadAllLines(file);
    foreach(string line in myContents)
    {
        Console.WriteLine(line);
    }
}

static void FileAddSomeLines(string file)
{
    string phrase = "\nJohn likes his dog";
    File.AppendAllText(file, phrase);

    string[] words =
    {
        "\nsunny",
        "hot",
        "loud"
    };

    File.AppendAllLines(file, words);
}

static void FileCreateNewFile(string file)
{
    string[] words = { "I", "love", "my", "family" };
    try
    {
        using (StreamWriter sw = new StreamWriter(file))
        {
            try
            {
                foreach(string word in words)
                {
                    sw.Write($"{word}\n");
                }
            }
            catch(Exception e)
            {
                throw;
            }
            finally
            {
                sw.Close();
            }
        }
    }
    catch(Exception e)
    {
        throw;
    }
}

static void FileReadAllTextAsBytes(string file)
{
    byte[] bytes = File.ReadAllBytes(file);
    foreach(byte character in bytes)
    {
        Console.Write($"{character} ");
    }
}