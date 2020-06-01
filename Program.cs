public class Solution {
    public int NumIslands(char[][] grid) {
        int numofdays=0;
        for(int i=0;i<grid.Length;i++)
        {
            for(int j=0;j<grid[i].Length;j++)
            {
                if(grid[i][j]=='1')
                {
                    CheckAdjacent(i,j,grid);
                    numofdays++;
                }
            }
        }
        return numofdays;
    }
    public void CheckAdjacent(int row,int column,char[][] grid)
    {
        if(row <0 || column <0 || row > grid.Length-1 || column > grid[0].Length -1)
            return;
        if(grid[row][column]=='0')
            return;
        else if(grid[row][column]=='1')
        {
            grid[row][column]='2';
            CheckAdjacent(row-1,column,grid);
            CheckAdjacent(row,column-1,grid);
            CheckAdjacent(row+1,column,grid);
            CheckAdjacent(row,column+1,grid);
        }
    }
}
