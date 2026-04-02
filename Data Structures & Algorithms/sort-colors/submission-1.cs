public class Solution {
    public void SortColors(int[] nums) {
        int l = 0;
        int r = nums.Length - 1;
        int i = 0;

        void Swap(int i, int j) {
            int tmp = nums[i];
            nums[i] = nums[j];
            nums[j] = tmp;
        }

        while (i <= r) {
            if (nums[i] == 0) {
                Swap(l, i);
                l++;
            } else if (nums[i] == 2) {
                Swap(i, r);
                r--;
                i--;
            }
            i++;
        }

    }
}