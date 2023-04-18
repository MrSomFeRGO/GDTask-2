object[] array = { 1, "2", 3, "4", "5" };

int sum = 0;
int count = 0;

foreach (object element in array)
{
    if (element is int)
    {
        sum += (int)element;
    }

    if (element is string)
    {
        count++;
    }
}

int result = sum - count;

Console.WriteLine(result);