// See https://aka.ms/new-console-template for more information
class sort
{
    //Selection Sort
    public void selectionSort(int[]A,int n)
    {
        for (int i = 0; i < n - 1; i++)
        {
            int position = i;
            for (int j = i + 1; j < n; j++)
            {
                if (A[j] < A[position])
                {
                    position = j;
                }
            }
        
            int temp = A[i];
            A[i] = A[position];
            A[position] = temp;
        }
    }
    
       public void display(int[]A,int n)
       {
           for(int i=0;i<n;i++)
           Console.Write(A[i] + " ");
           Console.WriteLine();
     
        }

      static void Main(string[] args)
      {
        sort s= new sort();
        //int[] A = { 7, 2, 1, 4, 5,9 };
        int[] A = { 2,3,1,5,7,8 };
        Console.WriteLine("Before performing selection sort");
        s.display(A, 6);
        Console.WriteLine("After Performing Selection sort");
        s.selectionSort(A, 6);
        s.display(A, 6);
        Console.ReadKey();
      }
}
