namespace Kata.KarateChop
{
    /// <summary>
    /// Kata from this link - http://codekata.com/kata/kata02-karate-chop/
    /// </summary>
    public class KarateChop
    {
        /// <summary>
        /// Binary Search
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public int Chop(int[] nums, int value)
        {
            if(nums == null || nums.Length==0)
                return -1;

            int l = 0, r = nums.Length - 1;
            while (l <= r)
            {
                int mid = (l + r) / 2;
                if (nums[mid] == value)
                    return mid;
                else if (nums[mid] < value)
                    l = mid + 1;
                else
                    r = mid - 1;
            }
            return -1;
        }

        public int ChopRecursive(int[] nums, int value)
        {
            return ChopRecursive(nums, value, 0, nums.Length-1);
        }

        private int ChopRecursive(int[] nums, int value, int l, int r)
        {
            if(l <= r)
            {
                int mid = (l + r )/ 2;
                if(nums[mid]==value)
                    return mid;
                if (nums[mid] < value)
                    return ChopRecursive(nums, value, mid + 1, r);//search in left part
                else
                    return ChopRecursive(nums, value, l, mid - 1);//search in right part
            }
            return -1;
        }
    }
}