Interval game
Write a program to calculate the result of a game. First you get a number that indicates how many moves the game will last. Then for each turn of the game you will get a new number. According to the interval in which the number falls, points are added. If the number is negative or greater than 50, then it is invalid. At the start of the game the score is 0 and on each turn points are added as follows:

0 to 9 20% of the number
10 to 19 30% of the number
20 to 29 40 % of the number
30 to 39 50 points
40 to 50 100 points
Invalid number score is divided by 2

In addition to the score, the program must output statistics for percentages of numbers in the given intervals.
Login
The input is read from the console:
First line - how many moves there will be during the game - integer in the range [1...100]
For each move - the numbers being checked in which interval - integers in the range [-100...100]
Output
Print 7 lines on the console:
1st line: "{Final result}"
2nd line: "From 0 to 9: {percent in interval}%"
3rd line: "From 10 to 19: {percentage in range}%"
4th line: "From 20 to 29: {percentage in range}%"
5th line: "From 30 to 39: {percentage in interval}%"
6th line: "From 40 to 50: {percentage in interval}%"
7th line: "Invalid numbers: {percentage in range}%"
All numbers must be formatted to the second decimal place.
