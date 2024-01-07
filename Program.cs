int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

int currentSmallest = int.MaxValue; // Start higher than anything in the array.
foreach (int integerYo in array)
{
    if (integerYo < currentSmallest)
        currentSmallest = integerYo;
}
Console.WriteLine(currentSmallest);


int total = 0;
foreach (int totalScore in array)
    total += totalScore;
float average = (float)total / array.Length;
Console.WriteLine(average);

