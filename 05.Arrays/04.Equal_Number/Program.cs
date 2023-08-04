// Create a program that reads 10 numbers from the user and shows the numbers that are repeated.
int[] num = new int[10] {0,0,1,0,5,5,5,5,6,7};
int[] EqualNum = new int[10];

// Create a variable to store the position of the array EqualNum
int position = 0;
int confirm = 0;

// First selection
for (int outer = 0; outer < num.Length; outer++)
{
    // Second selection
    for (int inner = 0; inner < num.Length; inner++) 
    {
        // Check if the numbers are equal and if they are not in the same position
        if (num[outer] == num[inner] && outer != inner)
        {
            confirm = 0; // Reset the variable confirm
            
            // Check if the number is already in the array EqualNum
            for (int p = 0; p < position; p++) 
            {
                // If the number is already in the array, confirm = 1
                if (num[outer] == EqualNum[p])
                {
                    confirm++;
                    break;
                }
            }

            // Add the number to the array EqualNum if it is not repeated
            if (confirm == 0)
            {
                EqualNum[position] = num[outer];
                position++;
            }
        }   
    }   
}

// Print the numbers that are repeated
for (int i = 0; i < position; i++)
{
    Console.Write(EqualNum[i] + " ");
}

/* 
Output

0 5
*/