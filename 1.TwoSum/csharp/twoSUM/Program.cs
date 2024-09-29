public class Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return [i, j];
                }
            }
        }
        throw new Exception("No two sum solution found");
    }

    public static void Main(string[] args)
    {

        Solution solution = new();

        int[] nums = [2, 7, 11, 15];
        int target = 9;

        try
        {
            int[] result = TwoSum(nums, target);
            Console.WriteLine($"Result: {result[0]}, {result[1]}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
