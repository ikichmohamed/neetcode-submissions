public class Solution {

    public string Encode(IList<string> strs) {
    string result = "";
    foreach (string str in strs) {
        result += $"{str.Length}#{str}";  // ✅ délimiteur # ajouté
    }
    return result;
}

public List<string> Decode(string s) {
    List<string> result = new List<string>();
    int i = 0;

    while (i < s.Length) {
        int j = i;

        // Avancer jusqu'au #
        while (s[j] != '#') j++;

        // Lire la longueur (entre i et j)
        int len = int.Parse(s.Substring(i, j - i));

        // Extraire le mot qui suit le #
        result.Add(s.Substring(j + 1, len));

        // Sauter : longueur_digits + '#' + mot
        i = j + 1 + len;
    }

    return result;
}
}
