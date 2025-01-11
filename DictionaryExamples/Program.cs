public class DictionaryExamples
{
    /*
     * Here we are going over the dictionary (aka the hashmap) datatype
     * this datatype is like an array, list,etc. the difference between them is
     * like list you can add things to the List BUT they call the key spot and then the value that spot holds
     *
     */
    public static void Main(string[] args)
    {
        //here we declare the dictionary, we call the datatype dictionary
        //and then give it 2 other datatypes that it has to hold
        Dictionary<int, string> dict = new Dictionary<int, string>();
        //here we add the key and the value of that key to the dictionary
        dict.Add(1, "one");
        dict.Add(2, "two");
        dict.Add(3, "three");
        dict.Add(4, "four");
        dict.Add(5, "five");
        
        //another way to declare a dictionary is by making the dictionary and then 
        //applying the keys and values right after with {}
        Dictionary<int, string> dict2 = new Dictionary<int, string>
        {
            //here we add the key and the value of that key to the dictionary
            { 1, "one" },
            { 2, "two" },
            { 3, "three" },
            { 4, "four" },
            { 5, "five" }
        };

        //we will now print the values of all 6 dictionary entries
        //we have to use KeyValuePair<int><string> because that is the pair we set
        //for the dictionary, if we wanted to we can also use var 
        foreach (KeyValuePair<int, string> kvp in dict)
        {
            
            Console.WriteLine($"Key: {kvp.Key}    Value: {kvp.Value}");
        }

        Console.WriteLine();
        //here we will update 1 of the values in the dictionary
        dict[1] = "Uno";
        //here we will remove the key AND value from the dictionary
        dict.Remove(5);
        //here we add Key 6 and value "Six" and it will not fill into Key slot 5
        dict.Add(6,"Six");
   
        foreach (KeyValuePair<int, string> kvp in dict)
        {
            Console.WriteLine($"Key: {kvp.Key}    Value: {kvp.Value}");
        }
        Console.WriteLine();
        
        //this should print false because there is no Key 5
        Console.WriteLine(dict.ContainsKey(5));
        //this should return true because we have the value "two"
        Console.WriteLine(dict.ContainsValue("two"));
    }
}