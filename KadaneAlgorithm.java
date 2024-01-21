//Kadane's Algorithm conceppt
//1.If sum<0 ,assign sum=0;
//2.take max=arr[0] first element of array as max and whenever sum value is greater than max, assign sum to max;

class Solution{

    // arr: input array
    // n: size of array
    //Function to find the sum of contiguous subarray with maximum sum.
    long maxSubarraySum(int arr[], int n){
        
        // Your code here
        long sum=0;
        long max=arr[0];
        for(int i=0;i<n;i++)
        {
            sum+=arr[i];
            if(sum>max) max=sum;
            if(sum<0) sum=0;
        }
    
        return max;
    } 
}
