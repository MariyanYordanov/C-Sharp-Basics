Return to the past
Ivancho is 18 years old and receives an inheritance that consists of X amount of money and a time machine. He decides to go back to 1800, but he doesn't know if the money will be enough to live without working. Write a program that calculates whether Ivancho will have enough money to not have to work up to and including a given year. Assume that for each even-numbered (1800, 1802, etc.) year he will spend 12,000 leva. For each odd year (1801,1803, etc.) he will spend 12,000 + 50 * [the years he is in that year].
Login
The input is read from the console and contains exactly 2 lines:
Inherited money - a real number in the range [1.00 ... 1,000,000.00]
The year to live to (inclusive) - an integer in the range [1801 ... 1900]
Output
To print 1 line on the console. The amount must be formatted to two decimal places:
If enough money:
"Yes! He will live a carefree life and will have {N} dollars left." - where N is the money he will have left.
If the money is NOT enough:
"He will need {M} dollars to survive." - where M is the amount that is NOT enough.
