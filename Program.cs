namespace NonPrimitiveType
{
    internal class Program
    {
        enum hariDalamSeminggu
        {
            Senin = 0,
            Selasa = 1,
            Rabu = 2,
            Kamis = 3,
            Jumat = 4,
            Sabtu = 5,
            Minggu = 6
        }

        static void Main(string[] args)
        {
            /* Assign person object using normal method */
            /* 
            Person person = new Person();
            person.FirstName = "Widyan";
            person.LastName = "Irwadi";
            person.Age = 29;
            person.Introduce(); 
            */

            /* Assign newPerson object using normal method */
            /*
            Person newPerson = new Person();
            newPerson.FirstName = "Arum";
            newPerson.LastName = "Widyanti";
            newPerson.Age = 23;
            newPerson.Introduce();
            */

            /* Assign person object using constructor */
            /*
            Person person = new Person("Widyan", "Irwadi", 29);
            person.Introduce();
            */

            /* Penggunaan Inheritance */
            /*
            Animal animal = new Animal();
            animal.Name = "Angel";
            animal.Eat();

            Dog dog = new Dog();
            dog.Name = "Buddy";
            dog.Bark();
            dog.Eat();
            */

            /* Array */
            /*
            string[] color = new string[3];
            color[0] = "Red";
            color[1] = "Green";
            color[2] = "Blue";

            for (var i = 0; i < 3; i++)
            {
                Console.WriteLine(color[i]);
            }
            */

            /* Array Multidimensi */
            /*
            int[,] matrix = new int[3, 4]; // Deklarasi dan inisialisasi array multidimensi dengan 3 baris dan 4 kolom

            matrix[0, 0] = 1; // Menyimpan nilai 1 di baris 0, kolom 0
            matrix[0, 1] = 2; // Menyimpan nilai 2 di baris 0, kolom 1
            matrix[0, 2] = 3; // Menyimpan nilai 3 di baris 0, kolom 2
            matrix[0, 3] = 4; // Menyimpan nilai 4 di baris 0, kolom 3

            matrix[1, 0] = 1; // Menyimpan nilai 1 di baris 1, kolom 0
            matrix[1, 1] = 2; // Menyimpan nilai 2 di baris 1, kolom 1
            matrix[1, 2] = 3; // Menyimpan nilai 3 di baris 1, kolom 2
            matrix[1, 3] = 4; // Menyimpan nilai 4 di baris 1, kolom 3

            matrix[2, 0] = 1; // Menyimpan nilai 1 di baris 2, kolom 0
            matrix[2, 1] = 2; // Menyimpan nilai 2 di baris 2, kolom 1
            matrix[2, 2] = 3; // Menyimpan nilai 3 di baris 2, kolom 2
            matrix[2, 3] = 4; // Menyimpan nilai 4 di baris 2, kolom 3

            int[,] matrix2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }; // Inisialisasi array multidimensi dengan nilai awal

            Console.WriteLine(matrix[0, 1]); // Output: 2
            Console.WriteLine(matrix2[1, 2]); // Output: 6
            

            string[,] alamat = new string[2, 3];
            alamat[0, 0] = "a";
            alamat[0, 1] = "b";
            alamat[0, 2] = "c";

            alamat[1, 0] = "d";
            alamat[1, 1] = "e";
            alamat[1, 2] = "f";

            Console.WriteLine(alamat[0, 0]); // Output: a
            Console.WriteLine(alamat[1, 2]); // Output: f
            string joinedString = string.Join(", ", alamat);
            Console.WriteLine(joinedString);
            */

            /* String Join */
            /*
            string[] fruits = new string[3];
            fruits[0] = "Apple";
            fruits[1] = "Banana";
            fruits[2] = "Orange";

            string joinedString2 = string.Join(", ", fruits);

            Console.WriteLine(joinedString2);
            */

            /* Enum */

            /*
            hariDalamSeminggu today = hariDalamSeminggu.Senin;

            if (today == hariDalamSeminggu.Senin)
            {
                Console.WriteLine("Today is Monday");
            } else
            {
                Console.WriteLine("Today is not Monday");
            }
            */

            /* for loop */
            /*
            for (var i = 0; i < 3; i++)
            {
                Console.WriteLine(i);
            }
            */

            /* while loop */
            /*
            int count = 0;

            while (count < 5)
            {
                Console.WriteLine("test" + " " + count);
                count++;
            }
            */

            /* do while loop */
            /*
            int count2 = 0;

            do
            {
                Console.WriteLine("Test2" + " " + count2);
                count2++;
            } while (count2 < 5);
            */

            /* foreach loop */
            /*
            string joinedString2 = "";
            foreach (int testing in matrix)
            {
                joinedString2 = joinedString2 + testing.ToString();
            }
            Console.WriteLine(joinedString2);\
            */
        }
    }
}