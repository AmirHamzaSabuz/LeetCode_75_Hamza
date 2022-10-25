public class NumberOfIslands
{
    public int NumIslands(char[][] grid)
    {
        int numIsland = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == '1')
                {
                    dfs(grid, i, j);
                    numIsland++;
                }
            }
        }
        return numIsland;
    }
    public void dfs(char[][] grid, int i, int j)
    {
        if (i >= 0 && j >= 0 && i < grid.Length && j < grid[0].Length && grid[i][j] == '1')
        {
            grid[i][j] = '0';
            dfs(grid, i + 1, j);
            dfs(grid, i - 1, j);
            dfs(grid, i, j + 1);
            dfs(grid, i, j - 1);
        }
    }

    /*
    public int NumIslands(char[][] grid)
    {
        // if(grid == null || grid.Length == 0)
        // {
        // return 0;
        // }
        int numIsland = 0;

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == '1')
                {
                    numIsland += dfs(grid, i, j);
                }
            }
        }
        return numIsland;
    }

    int dfs(char[][] grid, int i, int j)
    {
        if (i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length || grid[i][j] == '0')
        {
            return 0;
        }
        grid[i][j] = '0';
        dfs(grid, i + 1, j);
        dfs(grid, i - 1, j);
        dfs(grid, i, j + 1);
        dfs(grid, i, j - 1);

        // dfs(grid, i + 1, j + 1);
        // dfs(grid, i + 1, j - 1);
        // dfs(grid, i - 1, j + 1);
        // dfs(grid, i - 1, j - 1);

        return 1;
    }

    */


    /*
    public int NumIslands(char[][] grid)
    {

        
        if (grid == null || grid.Length == 0 || grid[0].Length == 0)
            return 0;

        var uf = new UnionFind(grid);
        int m = grid.Length;
        int n = grid[0].Length;
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                if (grid[i][j] == '1')
                {
                    if (i - 1 >= 0 && grid[i - 1][j] == '1')
                        uf.Union(i * n + j, (i - 1) * n + j);
                    if (i + 1 < m && grid[i + 1][j] == '1')
                        uf.Union(i * n + j, (i + 1) * n + j);
                    if (j - 1 >= 0 && grid[i][j - 1] == '1')
                        uf.Union(i * n + j, i * n + j - 1);
                    if (j + 1 < n && grid[i][j + 1] == '1')
                        uf.Union(i * n + j, i * n + j + 1);
                }
        return uf.Count();
    }

    public class UnionFind
    {
        private int count = 0;
        private int[] parents;
        private int[] ranks;

        public UnionFind(char[][] grid)
        {
            count = 0;
            int m = grid.Length;
            int n = grid[0].Length;

            parents = new int[m * n];
            ranks = new int[m * n];
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        parents[i * n + j] = i * n + j;
                        count++;
                    }
                    ranks[i * n + j] = 0;
                }
        }

        public int Find(int index)
        {
            if (parents[index] != index)
                parents[index] = Find(parents[index]);

            return parents[index];
        }

        public void Union(int index1, int index2)
        {
            var pIndex1 = Find(index1);
            var pIndex2 = Find(index2);

            if (pIndex1 != pIndex2)
            {
                if (ranks[pIndex1] >= ranks[pIndex2])
                {
                    parents[pIndex2] = pIndex1;
                    ranks[pIndex1]++;
                }
                else
                {
                    parents[pIndex1] = pIndex2;
                    ranks[pIndex2]++;
                }
                count--;
            }
        }

        public int Count()
        {
            return count;
        }
    }
    */


}

/*
internal class Program
{
    private static void Main(string[] args)
    {

        char[][] scr = new char[4][];

        scr[0] = new char[] { '1', '1', '0', '0', '0' };
        scr[1] = new char[] { '1', '1', '0', '0', '0' };
        scr[2] = new char[] { '0', '0', '1', '0', '0' };
        scr[3] = new char[] { '0', '0', '0', '1', '1' };

        NumberOfIslands numberOfIslands1 = new NumberOfIslands();

        Console.Write("Number of islands is: " + numberOfIslands1.NumIslands(scr));




        //char[][] grid = new char[5][];

        //grid[0] = new char[] { '1', '1', '0', '0', '0' };
        //grid[1] = new char[] { '0', '1', '0', '0', '1' };
        //grid[2] = new char[] { '1', '0', '0', '1', '1' };
        //grid[3] = new char[] { '0', '0', '0', '0', '0' };
        //grid[4] = new char[] { '1', '0', '1', '0', '1' };

        //NumberOfIslands numberOfIslands2 = new NumberOfIslands();

        //Console.Write("Number of islands is: " + numberOfIslands2.NumIslands(grid));

        Console.ReadKey();
    }
}
*/

/*
 200. Number of Islands

Given an m x n 2D binary grid grid which represents a map of '1's (land) and '0's (water), return the number of islands.

An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. 
You may assume all four edges of the grid are all surrounded by water.

 

Example 1:

Input: grid = [
  ["1","1","1","1","0"],
  ["1","1","0","1","0"],
  ["1","1","0","0","0"],
  ["0","0","0","0","0"]
]
Output: 1
Example 2:

Input: grid = [
  ["1","1","0","0","0"],
  ["1","1","0","0","0"],
  ["0","0","1","0","0"],
  ["0","0","0","1","1"]
]
Output: 3

*/
