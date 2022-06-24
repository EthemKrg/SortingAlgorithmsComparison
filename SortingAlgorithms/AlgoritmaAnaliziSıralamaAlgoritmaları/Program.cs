using System.Diagnostics;

Console.WriteLine("Sıralama Algoritmaları: 1000000 elemanlı veri için");

int[] sayilarListesi = new int[1000000]; // dizemiz
Random rnd = new Random(); // random fonksiyonu
Stopwatch süreHesapla = new Stopwatch(); // süre hesaplama kodu

AddRandomNumbers(); // random sayı atama fonksiyonu

Console.WriteLine("\nSıralama Algoritmaları: BubbleSort (çok uzun sürdüğü için 500bin ve 1 milyona dahil etmedim)");

#region InsertionSort
Console.WriteLine("\nSıralama Algoritmaları: InsertionSort");
süreHesapla.Restart();
süreHesapla.Start(); // sıralama algoritmasından hemen önce süre ölçer başlıyor
InsertionSort(sayilarListesi);
süreHesapla.Stop(); // süre ölçer bitir.

TimeSpan time = süreHesapla.Elapsed; // bu kısımda hesaplanan zamanı bir string ile saat dakika saniye saliseye ayırıp ekrana yazdırıyorum
string result = string.Format("{0:00}:{1:00}:{2:00}:{3:00}:",
time.Hours, time.Minutes, time.Seconds, time.Milliseconds / 10);
Console.WriteLine("Kodun çalışma zamanı" + result);
#endregion

#region SelectionSort
Console.WriteLine("\nSıralama Algoritmaları: SelectionSort");
süreHesapla.Restart();
süreHesapla.Start(); // sıralama algoritmasından hemen önce süre ölçer başlıyor
SelectionSort(sayilarListesi);
süreHesapla.Stop(); // süre ölçer bitir.

time = süreHesapla.Elapsed; // bu kısımda hesaplanan zamanı bir string ile saat dakika saniye saliseye ayırıp ekrana yazdırıyorum
result = string.Format("{0:00}:{1:00}:{2:00}:{3:00}:",
time.Hours, time.Minutes, time.Seconds, time.Milliseconds / 10);
Console.WriteLine("Kodun çalışma zamanı" + result);
#endregion

#region MergeSort
Console.WriteLine("\nSıralama Algoritmaları: MergeSort");
süreHesapla.Restart();
süreHesapla.Start(); // sıralama algoritmasından hemen önce süre ölçer başlıyor
MergeSort(sayilarListesi);
süreHesapla.Stop(); // süre ölçer bitir.

time = süreHesapla.Elapsed; // bu kısımda hesaplanan zamanı bir string ile saat dakika saniye saliseye ayırıp ekrana yazdırıyorum
result = string.Format("{0:00}:{1:00}:{2:00}:{3:00}:",
time.Hours, time.Minutes, time.Seconds, time.Milliseconds / 10);
Console.WriteLine("Kodun çalışma zamanı" + result);
#endregion

#region HeapSort
Console.WriteLine("\nSıralama Algoritmaları: HeapSort");
süreHesapla.Restart();
süreHesapla.Start(); // sıralama algoritmasından hemen önce süre ölçer başlıyor
HeapSort(sayilarListesi);
süreHesapla.Stop(); // süre ölçer bitir.

time = süreHesapla.Elapsed; // bu kısımda hesaplanan zamanı bir string ile saat dakika saniye saliseye ayırıp ekrana yazdırıyorum
result = string.Format("{0:00}:{1:00}:{2:00}:{3:00}:",
time.Hours, time.Minutes, time.Seconds, time.Milliseconds / 10);
Console.WriteLine("Kodun çalışma zamanı" + result);
#endregion

#region Shellsort
Console.WriteLine("\nSıralama Algoritmaları: Shellsort");
süreHesapla.Restart();
süreHesapla.Start(); // sıralama algoritmasından hemen önce süre ölçer başlıyor
Shellsort(sayilarListesi);
süreHesapla.Stop(); // süre ölçer bitir.

time = süreHesapla.Elapsed; // bu kısımda hesaplanan zamanı bir string ile saat dakika saniye saliseye ayırıp ekrana yazdırıyorum
result = string.Format("{0:00}:{1:00}:{2:00}:{3:00}:",
time.Hours, time.Minutes, time.Seconds, time.Milliseconds / 10);
Console.WriteLine("Kodun çalışma zamanı" + result);
#endregion

Console.WriteLine("\n\n ---> sonuclar i5 9. nesil bir işlemciyle alındı" + "\n IBRAHIM ETHEM KURUGOL");
//(sayilarListesi, sayilarListesi[0], sayilarListesi[sayilarListesi.Length-1]);

void AddRandomNumbers()
{
    for (int i = 0; i < sayilarListesi.Length; i++)
    {
        sayilarListesi[i] = rnd.Next(1, sayilarListesi.Length + 1);
    }
} // random number function

void BubbleSort(int[] input)
{
    bool itemMoved = false;
    do
    {
        itemMoved = false;
        for (int i = 0; i < input.Count() - 1; i++)
        {
            if (input[i] > input[i + 1])
            {
                var lowerValue = input[i + 1];
                input[i + 1] = input[i];
                input[i] = lowerValue;
                itemMoved = true;
            }
        }
    } while (itemMoved);
}
void InsertionSort(int[] input)
{
    for (int i = 0; i < input.Count(); i++)
    {
        int item = input[i];
        int currentIndex = i;
        while (currentIndex > 0 && input[currentIndex - 1] > item)
        {
            input[currentIndex] = input[currentIndex - 1];
            currentIndex--;
        }
        input[currentIndex] = item;
    }
}

void SelectionSort(int[] input)
{
    for (int i = 0; i < input.Length; i++)
    {
        int min = i;
        for (int j = i + 1; j < input.Length; j++)
        {
            if (input[min] > input[j])
            {
                min = j;
            }
        }
        if (min != i)
        {
            int lowerValue = input[min];
            input[min] = input[i];
            input[i] = lowerValue;
        }
    }
}

int[] MergeSort(int[] d)
{
    if (d.Length <= 1)
        return d; //1 eleman zaten kıyaslanacak bir şey yok yukarı yolluyoruz.

    int i = 0;
    int bol = d.Length / 2; //ikiye bölüyoruz

    int[] sol = new int[bol]; //sol kısıma ilk yarısını
    int[] sag = new int[d.Length - bol]; //sağ kısma diğer yarısını atıyoruz



    for (i = 0; i < bol; i++)
    {
        sol[i] = d[i]; // sol diziyi dolduruyoruz
    }

    int k = 0;
    for (i = bol; i < d.Length; i++)
    {
        sag[k] = d[i]; //sağ diziyi dolduruyoruz
        k++;
    }

    sol = MergeSort(sol); //kalan diziyi tekrar yolluyoruz ikiye bölünsün diye
    sag = MergeSort(sag); //kalan diziyi tekrar yolluyoruz ikiye bölünsün diye

    return birlestir(sol, sag); // daha sonra birleştire gidiyoruz.
}
int[] birlestir(int[] sol, int[] sag)
{

    int[] a = new int[sol.Length + sag.Length]; // a dizisi oluşturduk.

    int i = 0, j = 0, k = 0;

    while (j < sol.Length && i < sag.Length)
        a[k++] = (sag[i] > sol[j]) ? sag[i++] : sol[j++];//sağ soldan büyük ise sağın bir sonrakine bak
                                                         //değilse solun bir sonraki indisine git ve a dizisine yaz.

    while (i < sag.Length)
        a[k++] = sag[i++]; //sağ kısım dönene kadar a dizisine sağı at

    while (j < sol.Length) //sol kısım tamamen bitene kadar a dizisine at
        a[k++] = sol[j++];

    return a; // en son a dizisini gönder diyoruz..
} // merge  sort devamı

void QuickSort(int[] A, int p, int r)
{
    if (p < r)
    {
        int q = Partition(A, p, r);
        QuickSort(A, p, q - 1);
        QuickSort(A, q + 1, r);
    }
}
int Partition(int[] A, int p, int r)
{
    double x = A[r];
    int i = p - 1;

    for (int j = p; j <= r - 1; j++)
    {
        if (A[j] <= x)
        {
            i = i + 1;
            int temp1 = A[i];
            A[i] = A[j];
            A[j] = temp1;
        }
    }

    int temp2 = A[i + 1];
    A[i + 1] = A[r];
    A[r] = temp2;
    return i + 1;
} // quick sort devamı

void HeapSort<T>(T[] array) where T : IComparable<T>
{
    int heapSize = array.Length;

    buildMaxHeap(array);

    for (int i = heapSize - 1; i >= 1; i--)
    {
        swap(array, i, 0);
        heapSize--;
        sink(array, heapSize, 0);
    }
}
void buildMaxHeap<T>(T[] array) where T : IComparable<T>
{
    int heapSize = array.Length;

    for (int i = (heapSize / 2) - 1; i >= 0; i--)
    {
        sink(array, heapSize, i);
    }
}
void sink<T>(T[] array, int heapSize, int toSinkPos) where T : IComparable<T>
{
    if (getLeftKidPos(toSinkPos) >= heapSize)
    {
        // No left kid => no kid at all
        return;
    }


    int largestKidPos;
    bool leftIsLargest;

    if (getRightKidPos(toSinkPos) >= heapSize || array[getRightKidPos(toSinkPos)].CompareTo(array[getLeftKidPos(toSinkPos)]) < 0)
    {
        largestKidPos = getLeftKidPos(toSinkPos);
        leftIsLargest = true;
    }
    else
    {
        largestKidPos = getRightKidPos(toSinkPos);
        leftIsLargest = false;
    }



    if (array[largestKidPos].CompareTo(array[toSinkPos]) > 0)
    {
        swap(array, toSinkPos, largestKidPos);

        if (leftIsLargest)
        {
            sink(array, heapSize, getLeftKidPos(toSinkPos));

        }
        else
        {
            sink(array, heapSize, getRightKidPos(toSinkPos));
        }
    }

}
void swap<T>(T[] array, int pos0, int pos1)
{
    T tmpVal = array[pos0];
    array[pos0] = array[pos1];
    array[pos1] = tmpVal;
}
int getLeftKidPos(int parentPos)
{
    return (2 * (parentPos + 1)) - 1;
}
int getRightKidPos(int parentPos)
{
    return 2 * (parentPos + 1);
}

void Shellsort(int[] arr)
{
    int n = arr.Length;

    for (int gap = n / 2; gap > 0; gap /= 2)
    {
        for (int i = gap; i < n; i += 1)
        {
            int temp = arr[i];

            int j;
            for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                arr[j] = arr[j - gap];

            arr[j] = temp;
        }
    }
}
