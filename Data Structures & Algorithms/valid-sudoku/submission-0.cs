public class Solution {
    public bool IsValidSudoku(char[][] board) {
        Dictionary<int,HashSet<int>> rows = new Dictionary<int,HashSet<int>>();
        Dictionary<int,HashSet<int>> columns = new Dictionary<int,HashSet<int>>();
        Dictionary<int,HashSet<int>> squares = new Dictionary<int,HashSet<int>>();
        int n = board.Length;

        for(int i = 0; i < 9; i++){
            for(int j = 0; j < 9; j++){
                if(board[i][j] != '.') {
                    int sq = (i/3)*3 + (j/3);
                    if (!rows.ContainsKey(i)) rows[i] = new HashSet<int>();
                    if (!columns.ContainsKey(j)) columns[j] = new HashSet<int>();
                    if (!squares.ContainsKey(sq)) squares[sq] = new HashSet<int>();

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
