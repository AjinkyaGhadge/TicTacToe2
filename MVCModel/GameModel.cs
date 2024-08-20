namespace MVCModel
{
    public class GameModel
    {
        #region private members
        public string player1Name { get; private set; }
        public string player2Name { get; private set; }
        public int player1ID { get; private set; }
        public int player2ID { get; private set; }
        public int currentPlayerID { get; private set; }
        public List<List<int>> grid { get; private set; }
        #endregion

        public enum GameResult
        {
            None,  // No winner
            Zero,  // Player 0 wins
            One,   // Player 1 wins
            Tie    // All possible rows, columns, and diagonals are filled and no winner
        }

        #region Constructors
        public GameModel(string p1_name = "Player X", string p2_name = "Player Y")
        {
            player1Name = p1_name;
            player2Name = p2_name;
            player1ID = 1;
            player2ID = 0;
            grid = new List<List<int>>();

            // Fill the grid with default values (e.g., 0)
            for (int i = 0; i < 3; i++)
            {
                // Create a new list for each row
                List<int> row = new List<int>();

                for (int j = 0; j < 3; j++)
                {
                    // Add default values to each cell
                    row.Add(-1); // Replace 0 with any default value
                }
                // Add the row to the grid
                grid.Add(row);
            }
            currentPlayerID = player1ID;
        }
        #endregion



        public void OnGridEvent(int button)
        {
            Tuple<int, int> coordinate = GetCoordinate(button);
            if (currentPlayerID.Equals(player1ID))
            {
                this.grid[coordinate.Item1][coordinate.Item2] = 1;
                currentPlayerID = player2ID;
            }
            else
            {
                this.grid[coordinate.Item1][coordinate.Item2] = 0;
                currentPlayerID = player1ID;
            }
        }



        public int CheckGameStatus()
        {
            GameResult gameResult = CheckThreeInARow(this.grid);
            if (gameResult == GameResult.One)
            {
                return 1;
            }
            if (gameResult == GameResult.Zero)
            {
                return 0;
            }
            if (gameResult == GameResult.Tie)
            {
                return -1;
            }
            if (gameResult == GameResult.None)
            {
                return 2;
            }
            return 2;
        }

        #region helper functions
        private GameResult CheckThreeInARow(List<List<int>> grid)
        {
            // Validate grid size
            if (grid.Count != 3 || grid[0].Count != 3)
                throw new ArgumentException("Grid must be 3x3.");

            // Check rows and columns
            for (int i = 0; i < 3; i++)
            {
                GameResult rowResult = CheckLine(grid[i][0], grid[i][1], grid[i][2]);
                if (rowResult != GameResult.None) return rowResult;

                GameResult colResult = CheckLine(grid[0][i], grid[1][i], grid[2][i]);
                if (colResult != GameResult.None) return colResult;
            }

            // Check diagonals
            GameResult mainDiagResult = CheckLine(grid[0][0], grid[1][1], grid[2][2]);
            if (mainDiagResult != GameResult.None) return mainDiagResult;

            GameResult antiDiagResult = CheckLine(grid[0][2], grid[1][1], grid[2][0]);
            if (antiDiagResult != GameResult.None) return antiDiagResult;

            // Check for tie
            foreach (var row in grid)
            {
                if (row.Contains(-1)) // Assuming -1 is used for empty cells
                    return GameResult.None; // Not a tie yet
            }

            return GameResult.Tie;
        }


        private GameResult CheckLine(int a, int b, int c)
        {
            // Check if all elements in the line are the same and either 0 or 1
            if (a == b && b == c)
            {
                if (a == 0) return GameResult.Zero;
                if (a == 1) return GameResult.One;
            }
            return GameResult.None;
        }

        public Tuple<int, int> GetCoordinate(int digit)
        {
            if (digit < 1 || digit > 9)
                throw new ArgumentOutOfRangeException("digit", "Digit must be between 1 and 9.");

            int row = (digit - 1) / 3;
            int col = (digit - 1) % 3;

            return Tuple.Create(row, col);
        }
        #endregion
    }
}