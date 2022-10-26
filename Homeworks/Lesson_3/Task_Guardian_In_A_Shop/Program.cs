
// Метод ввода и получения часов посещения (для одного посетителя)

string GetVisitHoursOfOneVisitor()
{
    string text, from, till, hours = String.Empty;
    int dashPos = 0;
    int frm = 0;
    int tll = 0;

    text = Console.ReadLine();
    dashPos = text.IndexOf('-');

    from = text.Substring(0, dashPos);
    frm = int.Parse(from);

    till = text.Substring(dashPos + 1);
    tll = int.Parse(till);

    string[] visitHours = new string[tll - frm + 1];

    if (frm == tll) visitHours[0] = from;

    else
    {
        int i = 0;
        while (frm <= tll)
        {
            visitHours[i] = Convert.ToString(frm);
            frm++;
            i++;
        }
    }
    hours = String.Join(" ", visitHours);
    return hours;
}


// ======= Метод получения "всех" часов посещения (для всех посетителей) =======
// ======= (требует доработки для непрерывного ввода с каким-либо прерыванием ввода) =======

string GetAllVisitHours(string hours, int itemsQuantity)
{
    int i = 1;
    while (i < itemsQuantity)
    {
        hours += " " + GetVisitHoursOfOneVisitor();
        i++;
    }
    return hours;
}


// ======= Метод преобразования массива из строки string в массив типа int =======

int[] GetArray(string visitHours)
{
    string[] a = visitHours.Split(' ');
    int i = 0;
    int[] c = new int[a.Length];

    while (i < a.Length)
    {
        c[i] = Convert.ToInt32(a[i]);
        i++;
    }
    return c;
}


// ======= Метод сортировки массива =======

void SortAscend(int[] a)
{
    for (int i = 0; i < a.Length - 1; i++)
    {
        for (int j = i + 1; j < a.Length; j++)
        {
            if (a[j] < a[i])
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
            }
        }
    }
}


// ======= Getting Frequences =======
// ======= Input: {1, 1, 1, 1, 5, 7, 7, 4, 4, 4} --- часы посещений =======
// ======= Output: {0, 4, 0, 0, 3, 1, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0} =======
// ======= Выход означает: в 1(час) было 4 посещения, в 4(четыре) было 3 посещения, в 5(пять) было 1 посещение и т. д. =======

int[] GetFrequences(int[] arr)
{
    int[] res = new int[25];
    int count = 0;

    for (int k = 0; k < res.Length; k++)
    {
        count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == k) count++;
        }
        res[k] = count;
    }
    return res;
}


// ======= Getting max frequencies =======
// ======= так как максимумов посещений может быть несколько, то нужно найти, =======
// ======= какому времени соответствуют такие максимумы =======

int[] GetMaxFreqsAndRespectiveHours(int[] a)
{
    int count = 0;
    int max = a[0];

    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] > max) max = a[i];
    }

    for (int j = 0; j < a.Length; j++)
    {
        if (a[j] == max) count++;
    }

    int[] hours = new int[count];

    int l = 0;
    for (int k = 0; k < a.Length; k++)
    {
        if (a[k] == max)
        {
            hours[l] = k;
            l++;
        }
    }
    return hours;
}


// ======= Output visit intervals =======

string GenerateIntervals(int[] array)
{
    int length = array.Length;

    string interval = string.Empty;
    int startPos = 0;
    int endPos = 0;

    for (int i = 0; i < length; i++)
    {
        while ((i + 1 < length) && (array[i] == array[i + 1] - 1))
        {
            endPos = i + 1;
            i++;
        }
        interval += $"{array[startPos]}-{array[endPos]} ";
        endPos++;
        startPos = endPos;
    }
    return interval;
}

// ========================================================================================

Console.Clear();

Console.WriteLine("Enter quantity of unique items in \'Журнал охранника\': ");
int itemsQuantity = int.Parse(Console.ReadLine());

Console.WriteLine("Enter all unique \"visit intervals\" using \"from-till\" format");

string allVisitHours = GetAllVisitHours(GetVisitHoursOfOneVisitor(), itemsQuantity);

int[] hours = GetArray(allVisitHours);

SortAscend(hours);

int[] b = GetFrequences(hours);

int[] c = GetMaxFreqsAndRespectiveHours(b);

Console.WriteLine("===================");

string intervals = GenerateIntervals(c);
Console.WriteLine("Hours with maximum visitors: " + intervals);
