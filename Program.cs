// User entry 
Console.WriteLine("Welcome to Grand Circus’ Room Detail Generator!");
Console.WriteLine("Enter the length of the room ");
double length=double.Parse(Console.ReadLine());
Console.WriteLine("Entered the width of the room ");
double width=double.Parse(Console.ReadLine());
Console.WriteLine("Enter the height ");
double  height=double.Parse(Console.ReadLine());

//Mathlogic 
double squarefeet= length*width;
double perimeter= (length*2)+(width*2);
double volume = squarefeet * height;
double surfaceArea=(squarefeet*2)+((height*length)*2)+((height*width)*2);

//output 
Console.WriteLine($"Area: {squarefeet}");
Console.WriteLine($"Perimeter: {perimeter}");
Console.WriteLine($"Volume: {volume}");
Console.WriteLine($"SurfaceArea: {surfaceArea}");
if (squarefeet>=650)
{
    Console.WriteLine("calculated: This is a large-sized room.");
}
else if (squarefeet >= 250)
{
    Console.WriteLine("calculated: This is a medium-sized room.");
}
else
{

    Console.WriteLine("calculated: This is a small-sized room.");
}

