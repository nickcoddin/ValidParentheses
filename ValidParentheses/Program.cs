namespace ValidParentheses
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string sequenceOne = "(()())";
            string sequenceTwo = "())()";
            Console.WriteLine(IsProperly(sequenceOne));
            Console.WriteLine(IsProperly(sequenceTwo));
        }
        public static bool IsProperly(string sequence)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char parentheses in sequence)
            {
                if (parentheses == '(')
                {
                    stack.Push('(');
                }
                else if (parentheses == ')')
                {
                    if (stack.Count == 0 || stack.Pop() != '(')
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
    }
}

    