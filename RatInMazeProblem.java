Rat in a Maze Problem - I

/*Input:
N = 4
m[][] = {{1, 0, 0, 0},
         {1, 1, 0, 1}, 
         {1, 1, 0, 0},
         {0, 1, 1, 1}}
Output:
DDRDRR DRDDRR
Explanation:
The rat can reach the destination at 
(3, 3) from (0, 0) by two paths - DRDDRR 
and DDRDRR, when printed in sorted order 
we get DDRDRR DRDDRR.*/


// User function Template for Java

// m is the given matrix and n is the order of matrix
class Solution {
    static ArrayList<String> ans=new ArrayList<String>();
    public static ArrayList<String> findPath(int[][] m, int n) {
        // Your code here
     
       boolean[][] isVisited=new boolean[n][n];
       findMazePath(0,0,n-1,n-1,"",m,isVisited);
       return ans;
    }
    
    public static void findMazePath(int sr,int sc,int er,int ec,String path,int[][] maze,boolean[][] isVisited)       
    {
        //ArrayList<String> list=new ArrayList<String>();
        if(sr<0 || sc<0) return;
        if(sr>er ||sc>ec) return;
       
        if(maze[sr][sc] == 0)
        return;
        //if(maze[sr][sc] == -1) 
        //return;
        if(isVisited[sr][sc]==true) return;
        if(sr==er && sc==ec)
        {
         ans.add(path);
         return;
        }
        
        isVisited[sr][sc]=true;
        //go right
        findMazePath(sr,sc+1,er,ec,path+"R",maze,isVisited);
        //go down
        findMazePath(sr+1,sc,er,ec,path+"D",maze,isVisited);
        //go left
        findMazePath(sr,sc-1,er,ec,path+"L",maze,isVisited);
        //go up
        findMazePath(sr-1,sc,er,ec,path+"U",maze,isVisited);
        
        //Bactracking
        isVisited[sr][sc]=false;
    }
}
