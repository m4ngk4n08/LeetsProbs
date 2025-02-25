

using System.ComponentModel;

int[][] grid = new int[][]
{
    new int[] { 0, 0, 0, 0 },
    new int[] { 0, 1, 1, 0 },
    new int[] { 1, 1, 0, 0 },
    new int[] { 1, 1, 0, 0 }
};

var rows = grid.Length;
var cols = grid[0].Length;

for (int r = 0; r < rows; r++)
{
    for (int c = 0; c < cols; c++)
    {
        if (grid[r][c] == 1)
        {
            Console.WriteLine(DFS(grid, r, c, new bool[rows, cols]));

        }
    }
}
int DFS(int[][] grid, int row, int col, bool[,] visited)
{
    // Boundary & water check
    if (row < 0 || col < 0 || row >= grid.Length || col >= grid[0].Length || grid[row][col] == 0)
        return 1;

    if (visited[row,col])
        return 0;

    visited[row,col] = true;

    Console.WriteLine("Row: " + row + " Col: " + col);

    int perimeter = 0;
    // recursively check all 4 sides
    perimeter += DFS(grid, row - 1, col, visited); // UP
    perimeter += DFS(grid, row + 1, col, visited); // down
    perimeter += DFS(grid, row, col - 1, visited); // left
    perimeter += DFS(grid, row, col + 1, visited); // right

    return perimeter;
}

