int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

//Length
Console.WriteLine("Length:" + numbers.Length);


//IndexOf()
int index = Array.IndexOf(numbers, 4);
Console.WriteLine("Index of 4: " + index);


//clear()
Array.Clear(numbers, 0, 2);

Console.WriteLine("Effect of Clear():");
foreach (int number in numbers)
    Console.WriteLine(number);


//Copy
int[] another = new int[3];
Array.Copy(numbers, another, 3);

Console.WriteLine("Effect of Copy():");

foreach (int number in another)
{
    Console.WriteLine(number);

}


//Sort()
Array.Sort(numbers);

Console.WriteLine("Effect of Sort():");

foreach (int number in numbers)
{
    Console.WriteLine(number);
}


//Reverse()
Array.Reverse(numbers);

Console.WriteLine("Effect of Reverse():");

foreach (int number in numbers)
{
    Console.WriteLine(number);
}