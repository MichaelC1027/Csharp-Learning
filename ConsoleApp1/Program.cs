using System.Collections.Generic;
using System.Security.Cryptography;

class Test
{
    //here is an example of a for loop being used into a switch case check instead of a if statement
    public static void FizzBuzz(int n)
    {
        for(int i = 1; i <= n; i++) {
            bool dub = (i % 3 == 0 && i % 5 == 0);
         
            switch (i)
            {
                case int j when j % 3 == 0 && j % 5 == 0:
                    Console.WriteLine("FizzBuzz");
                    break;

                case int j when j % 3 == 0:
                    Console.WriteLine("Fizz");
                    break;

                case int j when j % 5 == 0:
                    Console.WriteLine("Buzz");
                    break;

                default:
                    Console.WriteLine(i);
                    break;
            }

        }
    }

    //an example of a HashSet being used to look for the longest substring possible from a string and then clearing when the HashSet has the selected char
    public int LengthOfLongestSubstring(string s)
    {
        int result = 0;
        HashSet<char> str = new HashSet<char>();

        foreach (char c in s)
        {
            if (str.Contains(c))
            {
                if (result <= str.Count())
                {
                    result = str.Count();
                }
                    str.Clear();
            }
                str.Add(c);
        }

        if (result <= str.Count())
        {
            result = str.Count();
        }

        return result;
    }

    //an example of a HashSet being used to look for dublicate letters in a string and cutting the string off and starting new 
    public int PartitionStrings(string s)
    {
        int partitionCount = 1;
        HashSet<char> currentSubstring = new HashSet<char>();

        foreach (char c in s)
        {
            if (currentSubstring.Contains(c))
            {
                partitionCount++;
                currentSubstring.Clear();
            }
            currentSubstring.Add(c);
        }

        return partitionCount;
    }

    //an example of a List<int> being used to find a factor of the number being called and if it cant it will return a -1
    // other list examples can be things like List<string> List<char>, this is before we get into things like ArrayLists, SortedLists and LinkedLists which all have <datatype>
    public int KthFactor(int n, int k)
    { 
        List<int> list = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            if(n % i == 0)
            {
                list.Add(i);
            }
        }

        if(k <= list.Count)
        {
            return list[k - 1];
        } 
        else
        {
            return -1;
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        Test test = new Test();
        //int n = 30;
        //string str = "abcabc";
        //string str2 = "ssssss";
        string s = " ";

        //with this function we can just call the class straight forward, the reason is because it is a static void function so I dont have to make a new object variable
        //Test.FizzBuzz(n);

        // to access this function we had to make object to call it since it has a return value 
        //Console.WriteLine(test.PartitionStrings(str));
        //Console.WriteLine(test.KthFactor(12,3));
        Console.WriteLine(test.LengthOfLongestSubstring(s));

       Console.ReadKey();
    }
}