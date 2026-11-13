public class Solution {
    public void Solve(char[][] board) {
        int rows = board.Length;
        if(rows == 0) return;
        int cols = board[0].Length;
        
        void Dfs(int i, int j) {
            if( i < 0 || i == rows || 
                j < 0 || j == cols ||
                board[i][j] != 'O') return;
            board[i][j] = '1';
            Dfs(i+1,j);
            Dfs(i-1,j);
            Dfs(i,j+1);
            Dfs(i,j-1);
        }
        for(int i = 0; i < cols; i++) {
            if(board[0][i] == 'O') Dfs(0,i);
            if(board[rows-1][i] == 'O') Dfs(rows-1,i);
        }
        for(int i = 0; i < rows; i++) {
            if(board[i][0] == 'O') Dfs(i,0);
            if(board[i][cols-1] == 'O') Dfs(i,cols-1);
        }
        for(int i = 0; i < rows; i++) {
            for(int j = 0; j < cols; j++) {
                if(board[i][j] == '1') board[i][j] = 'O';
                else if(board[i][j] == 'O') board[i][j] = 'X'; 
            }
        }
    }
}
