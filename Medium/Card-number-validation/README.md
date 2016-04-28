# Card number validation

 To check whether a bank card number is valid or it is it just a set of random numbers, Luhn formula is used.

The formula verifies a number against its included check digit, which is usually appended to a partial account number to generate the full account number. This account number must pass the following test:

    From the rightmost digit, which is the check digit, moving left, double the value of every second digit; if the product of this doubling operation is greater than 9 (for example, 7×2=14), then sum the digits of the products (for example, 12:1+2=3, 14:1+4=5).
    Take the sum of all the digits.
    If the total modulo 10 is equal to 0 (if the total ends in zero) then, according to the Luhn formula, the number is valid; otherwise, it is not valid.

Examples of formula calculation and result checking:

Checking number 1556 9144 6285 339

1   5   5   6   9   1   4   4   6   2   8   5   3   3   9
1   10  5   12  9   2   4   8   6   4   8   10  3   6   9
1 + 1 + 5 + 3 + 9 + 2 + 4 + 8 + 6 + 4 + 8 + 1 + 3 + 6 + 9 = 70


70 mod 10 = 0, card number is valid

Checking number 6363 1811 2857 7650

6   3   6   3   1   8   1   1   2   8   5   7   7   6   5   0
12  3   12  3   2   8   2   1   4   8   10  7   14  6   10  0
3 + 3 + 3 + 3 + 2 + 8 + 2 + 1 + 4 + 8 + 1 + 7 + 5 + 6 + 1 + 0 = 57


57 mod 10 = 7 <> 0, card number is not valid
Input sample:

The first argument is a file that contains bank card numbers, one per line. For better readability, numbers are split into groups of 4 digits separated by spaces.
 
