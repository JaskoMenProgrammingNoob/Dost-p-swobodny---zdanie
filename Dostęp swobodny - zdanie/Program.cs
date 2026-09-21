using System.IO;
class Program
{


    public void zadanie_zdanie()
    {
        char[] zdanie =[ 'P','R','O','G','R','A','M','O','W','A','N','I','E',' ','W',' ','C','#' ];
        FileStream F;
        F = new FileStream("zdanie.txt", FileMode.Create);
        for(int i = 0; i < zdanie.Length; i++)
        {
            F.WriteByte((byte)zdanie[i]);
        }
        F.Close();
        F = new FileStream("zdanie.txt", FileMode.Open);
        for(int i = 0; i < zdanie.Length; i++)
        {
            Console.Write((char)F.ReadByte());
        }
        Console.WriteLine();
        F.Seek(1, SeekOrigin.Begin);
        Console.Write((char)F.ReadByte());
        F.Seek(2,SeekOrigin.Begin);
        Console.Write((char)F.ReadByte());
        F.Seek(6, SeekOrigin.Begin);
        Console.Write((char)F.ReadByte());
        F.Seek(-9, SeekOrigin.End);
        Console.Write((char)F.ReadByte());
        F.Seek(-8, SeekOrigin.End);
        Console.Write((char)F.ReadByte());
        F.Close();
    }





    static void Main(string[] args)
    {
        Program program = new Program();
        program.zadanie_zdanie();

        
    }
}