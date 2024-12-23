#region Functions 

// Task 1 Function : SimpleAdding 
int SimpleAdding(int num)
    {
        int total = 0;
        for (int i = 1; i <= num; i++)
        {
            total += i;
        }
        return total;
    }

// Task 2 Function : VowelCount 
int VowelCount(string str)
{
    int vowelcount = 0;
    string vowels = "aeiou";
    foreach (char v in str)
    {
        if (vowels.Contains(v)) { 
            vowelcount++; }
    }
    return vowelcount;
} 
// Task 3 Function : FirstFactorial 
int FirstFactorial(int first)
{
    int start = 1;
    for (int i = 1; i <= first; i++)
    {
        start *= i;
    }
    return start;
}

// Task 4 Function : Simple Evens 
int SimpleEvens(int even)
{
    if (even % 2 == 0)
    {
        Console.WriteLine("true");
    }
    else if (even % 2 != 0){
        Console.WriteLine("false");
    }
    return even;
}

// Task 5 Function : One Decremented 

#endregion




#region calls

// Task 1 Simple Adding 
  Console.WriteLine("For SimpleAdding. Enter number : ");
  int num = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Result is = " + SimpleAdding(num));

// Task 2 Vowel Count 
    Console.WriteLine("For VowelCount. Enter Words : ");
    string str = Console.ReadLine();
    Console.WriteLine("Number of vowels is = " + VowelCount(str));

// Task 3 First Factorial 
    Console.WriteLine("First Factorial. Enter number : ");
    int first = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Factorial of " + first + " is " + FirstFactorial(first));

// Task 4 Simple Evens 
  Console.WriteLine("SimpleEvens. Enter number : ");
  int even = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine(SimpleEvens(even));

// Task 5 

#endregion