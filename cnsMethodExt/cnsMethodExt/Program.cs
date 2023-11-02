
internal class Program
{
    private static void Main(string[] args)
    {
        Student student = new("Иванов", "Иван");

        //student.get_FullName();

        //Console.WriteLine(StudendExt.get_FullName());
        Console.WriteLine(student.get_FullName());
    }
}