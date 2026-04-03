public class Solution {

    public string Encode(IList<string> strs) {
        string res = "";
        // Concatenate the string to contain the length of the word + the delimiter + the actual word itself.
        foreach (string word in strs) {
            res += word.Length + "#" + word;
        }
        return res;
    }

    public List<string> Decode(string s) {
        int i = 0;
        List<string> res = new List<string>();

        // Loop throught the incoming string as long as the index 'i' is less than the length of the string.
        while (i < s.Length) {
            int j = i;

            // Find the delimiter.
            while (s[j] != '#') {
                j += 1;
            }
            
            // Extract the length from the encoded string and parse it to a number.
            int length = int.Parse(s[i..j]);

            // Append the exact amount of words of the number length after the delimiter .
            res.Add(s[(j+1)..(j+1+length)]);

            // Reset the index 'i' to start at the next character after the end of the word.
            i = j + 1 + length;
        }

        return res;
   }
}
