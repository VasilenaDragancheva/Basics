namespace Tests
{
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {


            List<Student> names = new List<Student> { new Student("Ivan"), new Student("Ivaaan"), new Student("AiVan") };
            var ivan = new Student("Ivan");
            bool hasIvan = names.Contains(ivan);
        }
    }
}