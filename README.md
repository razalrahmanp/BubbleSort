# BubbleSort

This code implements the Bubble Sort algorithm to sort an array of integers. 
 The code first prompts the user to enter the number of elements in the array. It then creates an integer array of the specified length.
 Next, the code prompts the user to enter the elements of the array one by one. It uses a for loop to iterate through the array and store the user input in each element.
 After that, the code calls the BubbleSort method passing the array as an argument. 
 The BubbleSort method implements the Bubble Sort algorithm. It takes an integer array as a parameter. The method uses two nested for loops to compare adjacent elements of the array and swap them if they are in the wrong order. The outer loop iterates from the beginning of the array to the second-to-last element, while the inner loop iterates from the beginning of the array to the current index of the outer loop. 
 If a swap is made during an iteration of the inner loop, a boolean variable named "swapped" is set to true. If no swaps are made during an iteration of the inner loop, it means that the array is already sorted, and the outer loop is terminated using the "break" statement.
 Finally, the code prints the sorted array by iterating through each element of the array and displaying it on the console.
