#Guess the Number

 Let’s play “Guess the number” game. This game is for two players, and it has simple rules:

    one person (master) picks an integer in a certain range (for example, from 0 to 100 inclusive)
    another person (you) tries to guess it in a certain number of attempts.

The task is facilitated by the fact that after each attempt, a master gives you a hint whether the number is higher or lower.

A reasonable approach to this game is to use the “divide and conquer” principle: in a range of numbers, always select a middle number. Then, based on the received response, discard the upper or the lower half of this range (together with the selected number) as it cannot contain the right answer. Now, the range of numbers is halved. Again, select the middle number. (If the number of integers in the range is even, select the greater one out of two middle numbers.) Repeat until you hear “Yay!” from a master — you guessed the number.

With this algorithm, you can win in at most log2 N attempts, where N is the range size.
Game example

Guess the number in an inclusive range 0..9, where computer is a master (also see the diagram below):

Computer: range form 0 to 9
Player:   5
Computer: Higher!
Player:   8
Computer: Lower!
Player:   7
Computer: Yay!

https://www.codeeval.com/static/images/kbase/guess_the_number.png

Input sample:

The task in this challenge is to guess the number. Because you have to use the proposed algorithm, we know all your answers in advance. Thus, your program should take the path to the file, in which each row stands for a different game, as first argument. At the beginning of each line, upper bound of the range is specified (the lower bound is 0, both are included in the range). Then, master’s answers go, separated by spaces. E.g.

100 Lower Lower Higher Lower Lower Lower Yay!

948 Higher Lower Yay!

Output sample:

13

593

Print to stdout a single guessed number for each row. E.g.
