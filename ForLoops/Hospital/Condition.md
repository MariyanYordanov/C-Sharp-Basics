For a given period of time, every day patients arrive at the hospital for examination. It has initially 7 doctors. Each doctor can only examine one patient per day, but sometimes there is a shortage of doctors, so the remaining patients are sent to other hospitals. Every third day, the hospital makes a calculation and if the number of unexamined patients is greater than the number of examined patients, another doctor is assigned. As the appointment is done before the admission of patients for the day starts.
Write a program that calculates for the given period the number of examined and unexamined patients.
Login
The input is read from the console and contains:
On the first line, the period for which you need to make calculations. An integer in the range [1 ... 1000]
On the following lines(equal to the number of days) - the number of patients who arrive for examination for the current day. Integer in the range [0...10 000]
Output
To print on the console 2 rows :
On the first line: "Treated patients: {number of patients examined}."
On the second line: "Untreated patients: {number of untreated patients}."
Sample input and output
Input Output Explanations
4
7
27
9
1 Treated patients: 23.
Untreated patients.
Day 2: 7 screened and 20 unscreened patients for the day
Day 3: 14 patients seen so far and 20 patients not seen -> New doctor assigned ->
8 patients seen and 1 patient not seen for the day
Day 4: 1 reviewed and 0 not reviewed patients for the day
Total: 23 reviewed and 21 not reviewed patients.

6
25
25
25
25
25
2 Treated patients: 40.
Untreated patients: 87. 3
7
7
7 Treated patients: 21.
Untreated patients: 0.
Logistics
You are responsible for the logistics of various loads. Depending on the weight of the cargo, a different vehicle is needed. The price per ton for which the cargo is transported is different for each vehicle:
Up to 3 tonnes - van (200 leva per tonne)
From 4 to 11 tonnes - truck (175 leva per tonne)
12 tonnes and more - train (120 leva per tonne)
Your task is to calculate the average cost per tonne of freight carried, and the percentage of tonnes carried by each vehicle, relative to the total weight (in tonnes) of all freight.
Login
A series of numbers are read from the console, each on a separate line:
On the first line - the number of loads to be transported - an integer in the range [1...1000]
For each load on a separate line - the tonnage of the load - an integer in the range [1...1000]
Output
Print 4 rows on the console as follows:
First line - the average price per ton of freight (rounded to the second decimal place);
Second line - the percentage of tons transported by van (percentage between 0.00% and 100.00%);
Third line - the percentage of tons transported by truck (percentage between 0.00% and 100.00%);
Fourth row - the percentage of tonnes transported by train (percentage between 0.00% and 100.00%).
Sample entry and exit
Input Output Explanations Input Output
4
1
5
16
3
	143.80
16.00%
20.00%
64.00% All loads 1 + 5 + 16 + 3 = 25 tonnes
(4 * 200 + 5 * 175 + 16 * 120)/25 = 143.80 (average per tonne)
By van - 4/25*100 = 16.00%
By truck - 5/25*100 = 20.00%
By train - 16/25*100 = 64.00% 5
2
10
20
1
7 149.38
7.50%
42.50%
50.00%
Ratings
Write a program to compute statistics of exam grades. At the beginning, the program gets the number of students who took the exam and, for each student, his/her grade. At the end, the program should print the percentage of students with scores between 2.00 and 2.99, between 3.00 and 3.99, between 4.00 and 4.99, 5.00 or more. Also the average grade on the exam.
Login
A series of numbers are read from the console, each on a separate line:
On the first line - the number of students who took the exam - an integer in the range [1...1000]
For each student on a separate line - the exam grade - a real number in the range [2.00...6.00]
Output
Print 5 rows on the console containing the following information:
"Top students: {percentage of students with a grade of 5.00 or higher}%"
"Between 4.00 and 4.99: {between 4.00 and 4.99 inclusive}%"
"Between 3.00 and 3.99: {between 3.00 and 3.99 inclusive}%"
"Fail: {less than 3.00}%"
"Average: {average success}"
All numbers must be formatted to the second decimal place.
