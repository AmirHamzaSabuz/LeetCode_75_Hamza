using System;

public class D_09_01_733_ Flood Fill
{
    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
    {
        var oldColor = image[sr][sc];
        if (oldColor == newColor) return image;

        var rows = image.Length;
        var cols = image[0].Length;
        var queue = new Queue<(int row, int col)>();
        queue.Enqueue((sr, sc));
        while (queue.Count > 0)
        {
            (int row, int col) = queue.Dequeue();
            image[row][col] = newColor;

            if (row > 0 && image[row - 1][col] == oldColor)
				queue.Enqueue((row - 1, col));
            if (row < rows - 1 && image[row + 1][col] == oldColor)
				queue.Enqueue((row + 1, col));
            if (col > 0 && image[row][col - 1] == oldColor)
				queue.Enqueue((row, col - 1));
            if (col < cols - 1 && image[row][col + 1] == oldColor)
				queue.Enqueue((row, col + 1));
        }

        return image;
    }
    /*
    public static void Main(String[] args)
    {
        int[][] screen = new int[8][];

        screen[0] = new int[] { 1, 1, 1, 1, 1, 1, 1, 1 };
        screen[1] = new int[] { 1, 1, 1, 1, 1, 1, 0, 0 };
        screen[2] = new int[] { 1, 0, 0, 1, 1, 0, 1, 1 };
        screen[3] = new int[] { 1, 2, 2, 2, 2, 0, 1, 0 };
        screen[4] = new int[] { 1, 1, 1, 2, 2, 0, 1, 0 };
        screen[5] = new int[] { 1, 1, 1, 2, 2, 2, 2, 0 };
        screen[6] = new int[] { 1, 1, 1, 1, 1, 2, 1, 1 };
        screen[7] = new int[] { 1, 1, 1, 1, 1, 2, 2, 1 };


        int x = 4, y = 4, newC = 3;
        Program p1 = new Program();
        p1.FloodFill(screen, x, y, newC);

        Console.WriteLine("Updated screen after" +
                          "call to floodFill: ");
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
                Console.Write(screen[i][j] + " ");
            Console.WriteLine();
        }

        int[][] scr = new int[3][];

        scr[0] = new int[] { 1, 1, 1 };
        scr[1] = new int[] { 1, 1, 0 };
        scr[2] = new int[] { 1, 0, 1 };

        int a = 1, b = 1, newCo = 2;
        Program p2 = new Program();
        p2.FloodFill(scr, a, b, newCo);

        Console.WriteLine("Updated scr after" +
                          "call to floodFill: ");
        for (int k = 0; k < 3; k++)
        {
            for (int l = 0; l < 3; l++)
                Console.Write(scr[k][l] + " ");
            Console.WriteLine();
        }
    }
    */
}


/*
 733. Flood Fill

An image is represented by an m x n integer grid image where image[i][j] represents the pixel value of the image.

You are also given three integers sr, sc, and color. You should perform a flood fill on the image starting from the pixel image[sr][sc].

To perform a flood fill, consider the starting pixel, plus any pixels connected 4-directionally to the starting pixel of the same color as the starting pixel, plus any pixels connected 4-directionally to those pixels (also with the same color), and so on. Replace the color of all of the aforementioned pixels with color.

Return the modified image after performing the flood fill.

 

Example 1:

Input: image = [[1,1,1],[1,1,0],[1,0,1]], sr = 1, sc = 1, color = 2
Output: [[2,2,2],[2,2,0],[2,0,1]]
Explanation: From the center of the image with position (sr, sc) = (1, 1) (i.e., the red pixel), all pixels connected by a path of the same color as the starting pixel (i.e., the blue pixels) are colored with the new color.
Note the bottom corner is not colored 2, because it is not 4-directionally connected to the starting pixel.


Example 2:

Input: image = [[0,0,0],[0,0,0]], sr = 0, sc = 0, color = 0
Output: [[0,0,0],[0,0,0]]
Explanation: The starting pixel is already colored 0, so no changes are made to the image.
 
 */