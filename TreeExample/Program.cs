public class TreeNode<T>
{
    // Property to store the value of the node
    public T Value { get; set; }

    // List to store the child nodes of the current node
    public List<TreeNode<T>> Children { get; set; }

    // Constructor to initialize the node with a value
    public TreeNode(T value)
    {
        // Set the value of the node
        Value = value;

        // Initialize the list of children as an empty list
        Children = new List<TreeNode<T>>();
    }

    // Method to add a child node to the current node
    public void AddChild(TreeNode<T> child)
    {
        // Add the child node to the list of children
        Children.Add(child);
    }
}



public static class TreeExample
{
    public static void Main(string[] args)
    {
        //creating a root node
        var root = new TreeNode<string>("root");
        
        //creating children nodes
        var child1 = new TreeNode<string>("child 1");
        var child2 = new TreeNode<string>("child 2");
        
        //adding the children nodes to the root
        root.AddChild(child1);
        root.AddChild(child2);
        
        //creating grandchildren nodes and adding them to the child nodes
        child1.AddChild(new TreeNode<string>("grandchild 1.1"));
        child2.AddChild(new TreeNode<string>("grandchild 2.1"));
        child2.AddChild(new TreeNode<string>("grandchild 2.2"));
        
        //printing the tree out
        PrintTree(root,0);
    }
    static void PrintTree(TreeNode<string> node, int depth)
    {
        // Print the current node with indentation
        Console.WriteLine(new string('-', depth * 2) + node.Value);

        // Recursively print each child
        foreach (var child in node.Children)
        {
            PrintTree(child, depth + 1);
        }
    }
}