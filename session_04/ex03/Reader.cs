using System;
using System.IO;
using System.Threading.Tasks;

class Reader
{
    string fileName;
    public string Data { get; set; }

    public Reader(string fn) { fileName = fn; }

    public void Read()
    {
        while (true)
        {

            System.Console.WriteLine($"Task number {Task.CurrentId} is trying to access {fileName}");
            FileStream s = new FileStream(fileName, FileMode.Open);
            StreamReader r = new StreamReader(s);
            Data = r.ReadToEnd();
            if (Data != null)
            {
                r.Close();
                s.Close();
                break;
            }
            else continue;
        }

    }

    public bool compareTo(Reader reader)
    {



        while (Data == null)
        {

            System.Console.WriteLine($"Fetching data from {fileName}");
            System.Console.WriteLine(Data);
            try
            {
                Read();
            }
            catch (IOException e)
            {
                System.Console.WriteLine(e.Data);
                continue;
            }

        }

        while (reader.Data == null)
        {
            System.Console.WriteLine($"Fetching data from {reader.GetHashCode()}");
            System.Console.WriteLine(reader.Data);
            try
            {
                reader.Read();
            }
            catch (IOException e)
            {
                System.Console.WriteLine(e.Data);
                continue;
            }
        }




        return reader.Data.Equals(Data) ? true : false;
    }


}