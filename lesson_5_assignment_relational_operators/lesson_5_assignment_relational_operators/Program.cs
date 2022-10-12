// Assignment Operator
using System.Collections.Concurrent;

int myAgeNow = 21;
int aYear = 1;
int myAgeNextYear = myAgeNow + aYear;
Console.WriteLine(myAgeNextYear);


int myVar = 5;

// without a compound assignment operator
int anotherVar = myVar + 2;
myVar = anotherVar;
Console.WriteLine($"Without using compound assignment operator: {myVar}");

// another way to do the same
myVar = myVar + 2;
Console.WriteLine($"Without using compound assignment operator 2: {myVar}");

// compound assignment operator
myVar += 2;
Console.WriteLine($"Using compound assignment: {myVar}");

// There are other compound operators as well, addition, subtraction, multiplication and division, and modulus.
myVar -= 2;
Console.WriteLine($"subtraction: {myVar}");

myVar *= 2;
Console.WriteLine($"Multiplication: {myVar}");

myVar /= 2;
Console.WriteLine($"Division: {myVar}");

myVar %= 2;
Console.WriteLine($"Modulus: {myVar}");

// myVar = myVar + 1;       without using compound assignment
// myVar += 1;              using compound assignment
myVar++;
Console.WriteLine($"Increment: {myVar}");
myVar--;
Console.WriteLine($"Decrement: {myVar}");

Console.WriteLine("\n-------------------\n");
Console.WriteLine("RELATIONAL OPERATORS\n");

int talhaSession = 22;
int amadSession = 22;

bool canBePaired = talhaSession != amadSession;
Console.WriteLine($"Can Amad and Talha form a Pair? {canBePaired}");