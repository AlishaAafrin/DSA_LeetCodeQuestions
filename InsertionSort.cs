// See https://aka.ms/new-console-template for more information
class sort
{
    //InsertionSort 
    public void InsertionSort(int[]A,int n)
    {
        for(int i=1;i<n;i++)
        {
            int temp = A[i];
            int position = i;
            while (position > 0 && A[position - 1] > temp)
                {
                A[position] = A[position - 1];
                position = position - 1;
                }
            A[position]=temp;
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
        int[] A = {3,5,8,9,6,2};
        Console.WriteLine("Before performing Insertion sort");
        s.display(A, 6);
        Console.WriteLine("After Performing Insertion sort");
        s.InsertionSort(A, 6);
        s.display(A, 6);
        Console.ReadKey();
      }
}
