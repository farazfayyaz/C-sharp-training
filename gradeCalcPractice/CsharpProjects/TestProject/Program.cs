/*

97 - 100   A+
93 - 96    A
90 - 92    A-
87 - 89    B+
83 - 86    B
80 - 82    B-
77 - 79    C+
73 - 76    C
70 - 72    C-
67 - 69    D+
63 - 66    D
60 - 62    D-
0  - 59    F


Student         Grade

Sophia:         92.2    A-
Andrew:         89.6    B+
Emma:           85.6    B
Logan:          91.2    A-

*/


// initialize variables - graded assignments 
int currentAssignments = 5; //num of assignments


//array of 5 integers, holding score info for each student
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };
//cleans up code

//stores total for each student's grade
int sophiaSum = 0;

//initialize decimal variables for the average
decimal sophiaScore;

foreach (int score in sophiaScores) {
    // add the exam score to the sum
    sophiaSum += score;
}

//calculate average and store into score variable
sophiaScore = (decimal)sophiaSum / currentAssignments;

//print lines with formatting
Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();