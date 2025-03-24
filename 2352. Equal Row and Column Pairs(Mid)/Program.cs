








using System.Collections.Generic;
using System.Text;

EqualPairs([[11, 1], [1, 11]]);
int EqualPairs(int[][] grid)
{
    var rowDict = new List<string>();
    var colDict = new List<string>();

    var gridCount = 0;
    for (int i = 0; i < grid.Length; i++)
	{
        var row = new StringBuilder();
        var col = new StringBuilder();
        for (int j = 0; j < grid.Length; j++)
		{
            row.Append("," + grid[i][j]);
            col.Append("," + grid[j][i]);
        }
        rowDict.Add(row.ToString());
        colDict.Add(col.ToString());
    }

    foreach (var row in rowDict)
    {
        foreach (var col in colDict)
        {
            if (row == col)
            {
                gridCount++;
            }
        }
    }

    return gridCount;
}

//11,1
//1,11