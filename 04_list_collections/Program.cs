namespace _04_list_collections;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Lists collections!");
        // ListIntroduction();
        ListWithInteger();
        void ListIntroduction()
        {
            List<string> names = new List<string>(["<name>", "Tobias", "Crixus"]);
            
            Console.WriteLine();
            names.Add("Billy");
            names.Add("Gina");
            names.Add("Tai");

            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}");
            } 
            
            Console.WriteLine($"My name is {names[0]}.");
            Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");
            Console.WriteLine($"The list has {names.Count} people in it");
            
            var index = names.IndexOf("Gina");

            if (index == -1)
            {
                Console.WriteLine($"When items is not found, index of returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }
            
            index = names.IndexOf("Not Found");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }
            
            names.Sort();

            foreach (var name in names)
            {
                Console.WriteLine($"Names in order - {name}");
            }
        }

        void ListWithInteger()
        {
            List<int> fibonacci = [1, 1];
            for (int i = 2; i < 10; i++)
            {
                fibonacci.Add(fibonacci[i - 1] + fibonacci[i - 2]);
            }

            foreach (var item in fibonacci)
            {
                Console.WriteLine($"Values - {item}");
            }
            
        }
    }
}