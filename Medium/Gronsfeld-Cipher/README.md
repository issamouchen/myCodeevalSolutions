#Gronsfeld cipher

You are given a key and an enciphered message. The message was enciphered with the following vocabulary:

 !"#$%&'()*+,-./0123456789:<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz

Note: The first symbol is space.

Your task is to decipher the message that was enciphered with the Gronsfeld cipher using the given key.

The Gronsfeld cipher is a kind of the Vigenère cipher and is similar to the Caesar cipher. The only difference is that in the Caesar cipher, each character is shifted along by the same number, while in the Gronsfeld cipher, each character has its own number of shifts. It means that the length of key for the Gronsfeld cipher must be the same as the length of the message. But since it is difficult to remember such a key, especially if the message is long, the key of the message is repeated until it has the same length as the message.

For example:

For the word "EXALTATION" and the key "31415", the ciphertext is the following:

https://www.codeeval.com/static/images/kbase/gronfeld_cipher_02.JPG

https://www.codeeval.com/static/images/kbase/gronfeld_cipher_02.JPG

Accordingly, enciphered message is the following:

HYEMYDUMPS

Input sample:

The first argument is a file with different test cases (there are possible test cases with spaces at enciphered message). Each test case contains a key and an enciphered message separated by semicolon.
For example: 

31415;HYEMYDUMPS

45162;M%muxi%dncpqftiix"

14586214;Uix!&kotvx3


Output sample:

Print to stdout a deciphered message.
For example:

EXALTATION

I love challenges!

Test input.

Constraints:

    To decode a message, use the following alphabet: " !"#$%&'()*+,-./0123456789:<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
    Number of test cases is 40.
