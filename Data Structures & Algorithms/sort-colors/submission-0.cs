public class Solution {
    public void SortColors(int[] nums) {
        int[] count = {0,0,0};
        // Loop through the nums array to populate the count arr.
        for (int i = 0; i < nums.Length; i++) {
            count[nums[i]] += 1;
        }

        // Re-building the nums array in the specified order.
        int p = 0;
        for (int n = 0; n < count.Length; n++) {
            for (int j = 0; j < count[n]; j++) {
                nums[p] = n;
                p++;
            }
        }
    }
}