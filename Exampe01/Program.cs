List<int> list = new List<int>();


FillList(list, 5);

void FillList(List<int> list, int count)
{
    for (int i = 0; i < count; i++)
    {
        list.Add(new Random().Next(0,11));
    }
}

foreach (int number in list)
{
    Console.WriteLine(number);
}


Console.WriteLine();

List<int> evenNumbers = list.FindAll(x => x % 2 == 0);


foreach (int x in evenNumbers)
{
    Console.WriteLine(x);
}

