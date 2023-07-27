namespace LeetCodeProblems;

class Program
{
    public static void Main(string[] args)
    {
        TwoSumTest();
    }

    public static void TwoSumTest()
    {
        int target = 19;
        
        Console.WriteLine("01 - Two Sum");

        int[] nums = {1,2,3,4,5,6,7,8,9,10,35};
        int[] result = Problems.twoSum(nums, target);

        Console.WriteLine($"Result: {nums[result[0]]} + {nums[result[1]]} = {target}");
    }
}
