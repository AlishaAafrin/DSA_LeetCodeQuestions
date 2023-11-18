<!-------------------1502. Can Make Arithmetic Progression From Sequence-------------------!>
Input: arr = [3,5,1]
Output: true
Explanation: We can reorder the elements as [1,3,5] or [5,3,1] with differences 2 and -2 respectively, between each consecutive elements.

class Solution {
    public boolean canMakeArithmeticProgression(int[] arr) {
      //sorting array in ascending order
       int size=arr.length;
    //we can either use bubble sort or directly we can sort the array by using Arrays.sort
    //    for(int i=0;i<size-1;i++)
    //    {
    //        for(int j=0;j<size-i-1;j++)
    //        {
    //            if(arr[j]<arr[j+1])
    //            {
    //                int temp=arr[j];
    //                arr[j]=arr[j+1];
    //                arr[j+1]=temp;
    //            }
    //        }
    //    } 
        Arrays.sort(arr);
       //we got the sorted array ,now it's time to get difference so we can compare the two element'
       int diff=arr[size-1]-arr[size-2];
       for(int i=size-2;i>0;i--)
       {
           if(arr[i]-arr[i-1]!=diff)
           {
               return false;
           }
       }
      return true;
    }
}
