// See https://aka.ms/new-console-template for more information
class sort
{
    //Merge Sort- Work on Divide and conquer concept 
    //step 1: Divide the array into two equals halves.
    //step2: Sort the two sub array separately using recursion.
    //step3: Merge two sorted  sub arrays to create an overall sorted array
    //For more info check this url : https://www.youtube.com/watch?v=H88uKxPLA48
    public void MergeSort(int[]A,int l,int r)
    {   if (l >= r) return;
        int mid = (l + r) / 2;
        MergeSort(A, l, mid);
        MergeSort(A, mid + 1, r);
        Merge(A, l, mid, r);
       
    }

    public void Merge(int[] A,int l,int m,int r)
    {
        int n1 = m - l + 1;
        int n2 = r - m;
        int[] left = new int[n1];
        int[] right = new int[n2];
        int i, j, k;
        for (i = 0; i < n1; i++) left[i] = A[l + i];
        for (j = 0; j < n2; j++) right[j] = A[m + 1 + j];
        i = 0;j = 0;k = l;
        while (i < n1 && j < n2)
        {
            if (left[i] < right[j])
            {
                A[k] = left[i];
                k = k + 1; i = i + 1;
            }
            else
            {
                A[k] = right[j];
                k = k + 1; j = j + 1;
            }
        }
        while(i<n1)
        {
            A[k] = left[i];
            k = k + 1;i = i + 1;
        }
        while(j<n2)
        {
            A[k] = right[j];
            k = k + 1; j = j + 1;
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
        Console.WriteLine("Before performing Insertion sort");
        s.display(A, 6);
        Console.WriteLine("After Performing Insertion sort");
        int l = 0, r = A.Length-1;
        s.MergeSort(A, l,r);
        s.display(A, 6);
        Console.ReadKey();
      }
}
