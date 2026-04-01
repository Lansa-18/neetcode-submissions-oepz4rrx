public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> numsObj = new Dictionary<int, int>();
        List<int>[] frequencyArr = new List<int>[nums.Length + 1];
        List<int> resultList = new List<int>();

        for (int i = 0; i < nums.Length; i++) {
            if (!numsObj.ContainsKey(nums[i])) {
                numsObj[nums[i]] = 1;
            } else {
                numsObj[nums[i]] += 1;
            }
        }

        for (int i = 0; i < frequencyArr.Length; i++) {
            frequencyArr[i] = new List<int>();
        }

        foreach (var items in numsObj) {
            frequencyArr[items.Value].Add(items.Key);
        }

        for (int i = frequencyArr.Length - 1; i > 0; i--) {
            foreach (int n in frequencyArr[i]) {
                resultList.Add(n);
                if (resultList.Count == k) return resultList.ToArray();
            }
        }

        return resultList.ToArray();
    }
}
