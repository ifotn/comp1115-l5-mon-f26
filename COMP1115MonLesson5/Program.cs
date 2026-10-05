//// Ex. 1 - basic IF decision
//Console.WriteLine("Enter your quiz score");

//// store input in variable
//int quizScore = int.Parse(Console.ReadLine());
//string bonus = "None";

//// use decision to determine if user gets a bonus or not
//if (quizScore > 1000)
//{
//    bonus = "Double Points";
//}

//Console.WriteLine($"Bonus: {bonus}");

// Ex 2. - if / else
Console.WriteLine("Enter round 1 quiz score");
int quiz1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter round 2 quiz score");
int quiz2 = int.Parse(Console.ReadLine());

// compare scores & show meaningful output
if (quiz2 > quiz1)
{
    // score went up
    Console.WriteLine("You've improved");
}
else if (quiz1 > quiz2)
{
    // score went down
    Console.WriteLine("You've got to improve");

    // if 2nd score under 50
    if (quiz2 < 50)
    {
        Console.WriteLine("You need to redo Quiz 2");
    }
}
else
{
    // score stayed the same.  all previous conditions are false
    Console.WriteLine("You got the same score");
}

// Ex 3: AND conditions - check 2 things at a time
// if both scores over 80, show another message.  && means "AND" in c#
// like a marriage - all must be true
if (quiz1 > 80 && quiz2 > 80)
{
    Console.WriteLine("You've made the Leaderboard");
}

// Ex 4: OR conditions - only 1 condition needs to be true to evaluate to true
// if either score under 50, show another message.  || means "OR" in c#
// like a divorce - only 1 must be true
if (quiz1 < 50 || quiz2 < 50)
{
    Console.WriteLine("You're dropping down a level");
}

// Ex 5: switch to evaluate 1 variable for a range of different values
Console.WriteLine("Enter difficulty (1=Easy, 2-Medium, 3-Hard)");
int difficulty = int.Parse(Console.ReadLine());

int pointsMultiplier;

switch (difficulty)
{
    case 1:
        pointsMultiplier = 1;  // base points only, no multiplier
        break;
    case 2:
        pointsMultiplier = 2; // double points on medium
        break;
    case 3:
        pointsMultiplier = 3;
        break;
    default:
        pointsMultiplier = 1;
        break;
}

Console.WriteLine($"Difficulty: {difficulty} - {pointsMultiplier}x - Points Multiplier");


// Debug Exercise
Console.Write("Enter your quiz score (0-100): ");

double QuizScore = double.Parse(Console.ReadLine());

if (QuizScore > 74)
{
    Console.WriteLine("You did well");
}

else if (QuizScore > 50)
{
    Console.WriteLine("You did ok");
}

else 
{
    Console.WriteLine("You need some help");
}

string grade;

if (QuizScore >= 90)
{
  grade = "A";
}
else if (QuizScore >= 80)
{
   grade = "B";
}
else if (QuizScore >= 70)
{
   grade = "C";
}
else if (QuizScore >= 60)
{
   grade = "D";
}
else
{
   grade = "F";
}

Console.WriteLine("Your grade: " + grade);