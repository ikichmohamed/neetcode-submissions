public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char,int> shash = new Dictionary<char,int>();
        Dictionary<char,int> thash = new Dictionary<char,int>();

        bool result = true;
        foreach (char cs in s){
            if (shash.ContainsKey(cs)){
                shash[cs]+=1;
            }
            else {
                shash.Add(cs,1);
            }
        }

        foreach (char ct in t){
            if (thash.ContainsKey(ct)){
                thash[ct]+=1;
            }
            else {
                thash.Add(ct,1);
            }
        }

        foreach (KeyValuePair<char,int> entry in shash) {
            if ((thash.ContainsKey(entry.Key) && thash[entry.Key] != shash[entry.Key]) || !thash.ContainsKey(entry.Key)) {
                result = false;
                break;
            }
        }
        foreach (KeyValuePair<char,int> entry in thash) {
            if ((shash.ContainsKey(entry.Key) && thash[entry.Key] != shash[entry.Key]) || !shash.ContainsKey(entry.Key)) {
                result = false;
                break;
            }
        }
        return result;
    }
}
