// See https://aka.ms/new-console-template for more information
class sort
{

    public void bubbleSort(int[]A)
    {
       for(int i=0;i<A.Length-1;i++)
        {
            for(int j=0;j<A.Length-i-1;j++)
            {
                if (A[j] > A[j+1])
                {
                    int temp = A[j];
                    A[j] = A[j + 1];
                    A[j + 1] = temp;
                }
            }
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
        int[] A = {6,5,4,3,2,1};
        Console.WriteLine("Before performing Bubble sort");
        s.display(A, 6);
        Console.WriteLine("After Performing Bubble sort");
        s.bubbleSort(A);
        s.display(A, 6);
        Console.ReadKey();
      }
}// See https://aka.ms/new-console-template for more information
class sort
{

    public void bubbleSort(int[]A)
    {
       for(int i=0;i<A.Length-1;i++)
        {
            for(int j=0;j<A.Length-i-1;j++)
            {
                if (A[j] > A[j+1])
                {
                    int temp = A[j];
                    A[j] = A[j + 1];
                    A[j + 1] = temp;
                }
            }
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
        int[] A = {6,5,4,3,2,1};
        Console.WriteLine("Before performing Bubble sort");
        s.display(A, 6);
        Console.WriteLine("After Performing Bubble sort");
        s.bubbleSort(A);
        s.display(A, 6);
        Console.ReadKey();
      }
}
