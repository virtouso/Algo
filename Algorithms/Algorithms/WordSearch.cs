namespace Algorithms
{
    public class WordSearch
    {
        public bool Exist(char[][] board, string word) {
            if (board == null || board.Length == 0 || board[0].Length == 0)
                return false;

            int m = board.Length;
            int n = board[0].Length;

            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    if (Exist(board, word, i, j, 0))
                        return true;
                }
            }

            return false;
        }

        private bool Exist(char[][] board, string word, int i, int j, int index) {
            if (index == word.Length)
                return true;

            if (i < 0 || i >= board.Length || j < 0 || j >= board[0].Length || board[i][j] != word[index])
                return false;

            char temp = board[i][j];
            board[i][j] = '#'; // Mark the cell as visited

            bool found = Exist(board, word, i + 1, j, index + 1) ||
                         Exist(board, word, i - 1, j, index + 1) ||
                         Exist(board, word, i, j + 1, index + 1) ||
                         Exist(board, word, i, j - 1, index + 1);

            board[i][j] = temp; // Restore the cell value

            return found;
        }
    }
}