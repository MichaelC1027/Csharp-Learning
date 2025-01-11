public class ListsVHashsets
{
    /*
     * So here we are going to look at the difference between lists and hashsets
     * Lists and Hashsets are VERY similar to each other when it comes to storing data
     * like arrays they are easier ways to add, remove, and sort data.
     *
     * just like the example projects you can do almost exactly the same thing with both
     *
     * the difference is very small but very important, lists can store duplicates, hashsets can not
     */
    public static void Main(string[] args)
    {
        List<string> list = ["Apple", "Orange", "Banana", "Pineapple" ];
        
        //printing out the list 
        foreach (string s in list)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine();
        
        HashSet<string> list2 = ["Apple", "Orange", "Banana", "Pineapple"];
        //printing out the hashset
        foreach (string s in list2)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine();
        //as you will notice they are the same
        //but if we were to add another apple you will see the hashset WILL NOT 
        //store that value into its array
        list.Add("Apple");
        list2.Add("Apple");
        
        foreach (string s in list)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine();
        foreach (string s in list2)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine();
        
        //here I wanted to see what gets removed first, the first apple or the second
        //the first one gets remove which makes sense going from 0 to X
        list.Remove("Apple");
        foreach (string s in list)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine();
    }
}