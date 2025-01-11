class ListExamples
{
    /*
     * here we are working with lists!
     * Lists are ways to store data like array and hashsets
     * this is a very simple way of storing data, and it's not hard locked like arrays
     */
    public static void Main(String[] args)
    {
        //here we are creating 3 generic lists
        //you can get spicy with some of the <T> values like List<int[]>
        List<int> numbers = new List<int>();
        
        //here we are adding to the list we declared
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);

        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();
        
        //this is another way to declare a list and set the values immediately 
        List<string> names =
        [
            "John",
            "Mary",
            "Jane"
        ];
        
        //and you can also mix it as well
        List<char> chars =
        [
            'a',
            'b'
        ];
        chars.Add('c');
        
        /*
         * from here on we are ONLY going to be using the List<int> numbers for
         * showing off things you can do with lists, the reason for this
         * is that all these things work on all types of lists
         */

        //here we are adding to the List
        numbers.Add(4);
        //here we are removing from the list
        numbers.Remove(1);
        //here we are getting the length of the list we have 
        int length = numbers.Count();
        Console.WriteLine($"The length of the List 'numbers' is {length}");
        Console.WriteLine();
        
        //here we are going to add 1 back
        numbers.Add(1);
        //and print out the order before we sort and print again
        Console.WriteLine("Here we are adding 1 back and showing its not sorted");
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();
        
        //here are sorting the numbers to be in the correct order
        numbers.Sort();
        Console.WriteLine("here we are showing its sorted after the sort call");
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();
        
        //here we are taking the order of the list and reversing it 
        numbers.Reverse();
        Console.WriteLine("here we are showing the list is reversed");
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();
    }
}
