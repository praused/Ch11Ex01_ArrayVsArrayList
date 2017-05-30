using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11Ex01_ArrayVsArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create an Array type of Animal objects, and use it.");
            Animal[] animalArray = new Animal[2];
            Cow myCow1 = new Cow("Deirdre");
            animalArray[0] = myCow1;
            animalArray[1] = new Chicken("Ken");

            foreach (Animal myAnimal in animalArray)
            {
                Console.WriteLine($"New {myAnimal.ToString()} object added to Array collection, Name = {myAnimal.Name}.");
            }

            Console.WriteLine($"Array collection contains {animalArray.Length} objects.");
            animalArray[0].Feed();
            ((Chicken)animalArray[1]).LayEgg();
            Console.WriteLine();

            Console.WriteLine("Create an ArrayList type of Animal objects, and use it.");
            ArrayList animalArrayList = new ArrayList(); //ArrayList is in System.Collections
            Cow myCow2 = new Cow("Hayley");
            animalArrayList.Add(myCow2);
            animalArrayList.Add(new Chicken("Roy"));

            foreach (Animal myAnimal in animalArrayList)
            {
                Console.WriteLine($"New {myAnimal.ToString()} object added to ArrayList collection, Name = {myAnimal.Name}.");
            }

            Console.WriteLine($"ArrayList collection contains {animalArrayList.Count} objects.");
            ((Animal)animalArrayList[0]).Feed();
            ((Chicken)animalArrayList[1]).LayEgg();
            Console.WriteLine();

            Console.WriteLine("Additional manipulation of Arraylist:");
            animalArrayList.RemoveAt(0);
            ((Animal)animalArrayList[0]).Feed();
            animalArrayList.AddRange(animalArray);
            ((Chicken)animalArrayList[2]).LayEgg();
            Console.WriteLine($"The animal called {myCow1.Name} is at index {animalArrayList.IndexOf(myCow1)}.");
            myCow1.Name = "Janice";
            Console.WriteLine($"The animal is now called {((Animal)animalArrayList[1]).Name}.");
            Console.WriteLine();
        }
    }
}
