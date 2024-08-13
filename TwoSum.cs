namespace Twosum;
class TwoSum{

public static int[] TwoSumRun(int[] nums, int target){
        foreach(int num in nums){
            for (int i = 0; i < nums.Length; i++)
            {
                if(num + nums[i] == target){
                    int[] solution = new int[2];
                    Console.WriteLine(i);
                    if(Array.IndexOf(nums, num) != i){
                        solution[0] = Array.IndexOf(nums, num);
                        solution[1] = i;
                        return(solution);
                    }
                }
            }
        }
        return null;
    }
}