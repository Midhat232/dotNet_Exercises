# dotNet_Exercises
The Program for Mean and median of an unsorted array.
Given n size unsorted array, find it’s mean, median and mode. 
 
Mean is nothing but the sum of all elements divided by the number of total elements.
Mean of an array = (sum of all elements) / (number of elements)
 
Median of a sorted array of size n is defined as the middle element when n is odd and average of middle two elements when n is even.
Since the array is not sorted here, we sort the array first, then apply below formula.

Mode is nothing but the number which is repeted the most in the given unsorted/sorted array.
 
EXAMPLES

Input  : a[] = { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19}
Output : Mean = 31.4
         Median =31
         Mode = 30
         
Sum of the elements is 40+38+37+36+34+33+32+31+30+30+30+29+26+26+19 = 471
Total number of emelemts = 15
Mean = 471/15 = 31.4

Since number of elements are odd, median = 31.

Mode = 30 , which is the most repeted number.
