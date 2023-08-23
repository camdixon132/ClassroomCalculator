/*What will the application do?
1 Point The application prompts the user to enter values of length and width of the classroom.
2 Points: The application displays the area and perimeter of that classroom.
2 Points: The application classifies the room as small (up to and including 250 square feet), medium(more than 250 but less than 650 square feet), or large(650 square feet or more).

Build Specifications:
1 Point: Assume that the rooms are rectangles (90 degree corners).
1 Point: Assume that the user will enter valid numeric data for length and width.
1 Point: The application should accept decimal entries.

Extra Challenges:
1 Point: Calculate the volume of the rooms.
1 Point: Calculate the surface area of the rooms.*/

Console.WriteLine("Please enter the length of the classroom.");
decimal length = decimal.Parse(Console.ReadLine());
Console.WriteLine("Please enter the width of the classroom.");
decimal width = decimal.Parse(Console.ReadLine());
decimal perimeter = width + width + length + length;
decimal area = length * width;
Console.WriteLine("Area: " + area + " Perimeter: " + perimeter);
Console.WriteLine("Would you like to calculate the volume as well? y/n");   
string answer = Console.ReadLine();
if (answer == "y")
{
    Console.WriteLine("Please enter the height of the classroom");
    decimal height = decimal.Parse(Console.ReadLine());
    decimal volume = length * width * height;
    Console.WriteLine("Volume: " + volume);
}
else { Console.WriteLine("Have a nice day!"); }

