


//control statements

bool condition = true;
int number = 10;
if (condition)
{
    Console.WriteLine("Condition is true");
}
else
{
    Console.WriteLine("Condition is false");
}

if (number > 5)
{
    Console.WriteLine("Number is greater than 5");
}
else if (number < 5)
{
    Console.WriteLine("Number is less than 5");
}else if (number == 5)
{
    Console.WriteLine("Number is equal to 5");
}
else if (number <= 5)
{
    Console.WriteLine("Number is less than or equal to 5");
}
else if (number >= 5)
{
    Console.WriteLine("Number is greater than or equal to 5");
}
else
{
    Console.WriteLine("Number is not a number");
}

//switch statement
int day = 4;
switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Invalid day");
        break;
}

//logical operators
int x = 10;
int y = 20;
if (x == 10 && y == 20)
{
    Console.WriteLine("x is 10 and y is 20");
} else if (x == 10 || y == 20)
{
    Console.WriteLine("x is 10 or y is 20");
} else if (x != 10)
{
    Console.WriteLine("x is not 10");
} else if (y != 20)
{
    Console.WriteLine("y is not 20");
} else if (!(x == 10 && y == 20))
{
    Console.WriteLine("x is not 10 and y is not 20");
} else if (!(x == 10 || y == 20))
{
    Console.WriteLine("x is not 10 or y is not 20");
} else if (!(x != 10))
{
    Console.WriteLine("x is 10");
} else if (!(y != 20))
{
    Console.WriteLine("y is 20");
} else
{
    Console.WriteLine("Invalid");
}



// while loop
int i = 0;
while (i < 5)
{
    Console.WriteLine(i);
    i++;
}

// do while loop
int j = 0;
do
{
    Console.WriteLine(j);
    j++;
} while (j < 5);

// for loop
for (int k = 0; k < 5; k++)
{
    Console.WriteLine(k);
}

// foreach loop
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
foreach (string car in cars)
{
    Console.WriteLine(car);
}

// break statement
for (int l = 0; l < 10; l++)
{
    if (l == 5)
    {
        break;
    }
    Console.WriteLine(l);
}

// continue statement

for (int m = 0; m < 10; m++)
{
    if (m == 5)
    {
        continue;
    }
    Console.WriteLine(m);
}


//nested loop
for (int n = 0; n < 5; n++)
{
    for (int o = 0; o < 5; o++)
    {
        Console.WriteLine(n + " " + o);
    }
}