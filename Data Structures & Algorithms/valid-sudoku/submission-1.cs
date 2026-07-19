public class Solution {
    public bool IsValidSudoku(char[][] board) {
        Dictionary<int,HashSet<char>> rows = new Dictionary<int,HashSet<char>>();
        Dictionary<int,HashSet<char>> columns = new Dictionary<int,HashSet<char>>();
        Dictionary<int,HashSet<char>> squares = new Dictionary<int,HashSet<char>>();
        int n = board.Length;

        for(int i = 0; i < 9; i++){
            for(int j = 0; j < 9; j++){
                if(board[i][j] != '.') {
                    int sq = (i/3)*3 + (j/3);
                    if (!rows.ContainsKey(i)) rows[i] = new HashSet<char>();
                    if (!columns.ContainsKey(j)) columns[j] = new HashSet<char>();
                    if (!squares.ContainsKey(sq)) squares[sq] = new HashSet<char>();

                    if(rows[i].Contains(board[i][j]) || columns[j].Contains(board[i][j]) || squares[sq].Contains(board[i][j])) return false;
                    else {
                        rows[i].Add(board[i][j]);
                        columns[j].Add(board[i][j]);
                        squares[sq].Add(board[i][j]);
                    }
                }
            }
        }
        return true;
    }
}
