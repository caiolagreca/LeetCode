namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsValid("()[]{}")); //true
            Console.WriteLine(IsValid("({})")); //true
            Console.WriteLine(IsValid("()[{]")); //false
            Console.WriteLine(IsValid("([]){}")); //true
        }

        static bool IsValid(string s)
        {
            // Create a dictionary to map each opening bracket to its corresponding closing bracket
            Dictionary<char, char> peers = new Dictionary<char, char>
            {
                {'{', '}'},
                {'(', ')'},
                {'[', ']'}
            };

            // Create a stack to keep track of opening brackets (remember that Stack is "Last In, First Out")
            Stack<char> stack = new Stack<char>();

            // Iterate over each character in the string
            foreach (char character in s)
            {
                // Check if the current character is an opening bracket by seeing if it exists as a key in the dictionary
                if (peers.ContainsKey(character))
                {
                    // If it's an opening bracket, push it onto the stack for future matching
                    stack.Push(character);
                }
                else
                {
                    // If it's not an opening bracket (it's a closing bracket)
                    // First, we check if the stack is empty (no opening brackets to match with)
                    if (stack.Count == 0)
                    {
                        // If the stack is empty, there's no matching opening bracket, so the string is invalid
                        return false;
                    }
                    // Pop the last opening bracket from the stack to attempt to match with the current closing bracket
                    var topStackItem = stack.Pop();

                    // Use the dictionary to find the expected closing bracket for the popped opening bracket
                    // Compare it with the current character (which is a closing bracket)
                    if (character != peers[topStackItem])
                    {
                        // If they don't match, the brackets are not properly closed, so the string is invalid
                        return false;
                    }
                }
            }
            // After iterating through the string, check if there are any unmatched opening brackets left in the stack
            // If the stack is empty, all brackets were matched correctly, so the string is valid
            // If not, there are unmatched opening brackets, so the string is invalid
            return stack.Count == 0;
        }
    }
}