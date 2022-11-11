namespace Sloth3
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();
            chef.MakeChicken();
            chef.MakeSpecialDish();
            Console.WriteLine("\n");
            ItalianChef italianChef = new ItalianChef();
            italianChef.MakePasta();
            Console.WriteLine("\n");
            italianChef.MakeSpecialDish();

            Console.WriteLine("\n");
            Console.WriteLine(Math.Sqrt(144));
            // UsefulTools tools = new UsefulTools(); // unable to make an instance object since there is a static class 
            UsefulTools.SayHi("Vincent");

            Student student1 = new Student("Vincent", "Physical Therapy", 3.49);
            Student student2 = new Student("Anh", "Computer Science", 3.73);

            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");

            Song holiday = new Song("Memories", "Maroon 5", 200);
            Console.WriteLine(Song.songCount);

            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(kashmir.getSoungCount()); // getter method

            Console.WriteLine(kashmir.artist);

            // Getters and Setters
            shrek.Rating = "Cat"; // will be filted out by the setter

            Console.WriteLine(avengers.Rating);
            Console.WriteLine(shrek.Rating);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());
            Console.ReadLine();

        }
    }
}