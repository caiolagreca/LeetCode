public static class Program
{
    public static void Main(string[] arg)
    {
        string[] list = ["caio", "cain", "cainao", "caito"];
        string result = GetPrefix(list);
        Console.WriteLine($"the prefix is: {result}");
    }

    public static string GetPrefix(string[] list)
    {
        if (list == null || list.Length == 0)
        {
            return "";
        }

        string prefix = list[0];

        for (int i = 1; i < list.Length; i++)
        {
            while (list[i].IndexOf(prefix) != 0)
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
                if (prefix == "")
                {
                    return "";
                }
            }
        }
        return prefix;
    }

}