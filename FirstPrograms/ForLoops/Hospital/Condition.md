Hospital
For a given period of time, every day patients arrive at the hospital for examination. It has initially 7 doctors. Each doctor can only examine one patient per day, but sometimes there is a shortage of doctors, so the remaining patients are sent to other hospitals. Every third day, the hospital does a calculation and if the number of unexamined patients is greater than the number of examined patients, another doctor is assigned. As the appointment is done before the admission of patients for the day starts.
Write a program that calculates for the given period the number of examined and unexamined patients.
Login
The input is read from the console and contains:
On the first line, the period for which you need to make calculations. An integer in the range [1 ... 1000]
On the following lines(equal to the number of days) - the number of patients who arrive for examination for the current day. Integer in the range [0...10 000]
Output
To print on the console 2 rows :
On the first line: "Treated patients: {number of patients examined}."
On the second line: "Untreated patients: {number of untreated patients}."
