public class Solution {
    public bool IsValidSudoku(char[][] board) {
        // 9 sets for rows, 9 for cols, 9 for boxes
        HashSet<char>[] rows    = new HashSet<char>[9];
        HashSet<char>[] cols    = new HashSet<char>[9];
        HashSet<char>[] boxes   = new HashSet<char>[9];

        for (int i = 0; i < 9; i++) {
            rows[i]  = new HashSet<char>();
            cols[i]  = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        for (int r = 0; r < 9; r++) {
            for (int c = 0; c < 9; c++) {
                char val = board[r][c];

                if (val == '.') continue;

                int boxIndex = (r / 3) * 3 + (c / 3);

                // Add() returns false if element already exists
                if (!rows[r].Add(val))      return false;
                if (!cols[c].Add(val))      return false;
                if (!boxes[boxIndex].Add(val)) return false;
            }
        }

        return true;
    }
}