string[] arr = new[] { "один", "два", "три", "четыре", "пять", "нет", "вотоно" };

string[] arr_out = new string[] {};

int str_len = 3;

int i = 0;

int j = 0;

while (i < arr.Length)
{
    if (arr[i].Length <= str_len)
    {
        arr_out = arr_out.Append(arr[i]).ToArray();
    }
    i++;
}

while (j  < arr_out.Length)
{
    Console.WriteLine(arr_out[j]);
    j++;
}