#Column Names

 Microsoft Excel uses a special convention to name its column headers. The first 26 columns use the letters 'A' to 'Z'. Then, Excel names its column headers using two letters, so that the 27th and 28th column are 'AA' and 'AB'. After 'ZZ', Excel uses three letters.

Write a function that takes as input the number of the column, and returns its header. The input will not ask for a column that would be greater than 'ZZZ'.
Input sample:
 
The first argument is a path to a file. Each line of the input file contains one test case represented by one integer.
Output sample:

52

3702

For each test case your program must print one line containing the Excel column heading corresponding to the integer in the input.

AZ

ELJ

Constraints:

    The number of test cases is 40.
    The input will not ask for a column that would be greater than 'ZZZ'.
