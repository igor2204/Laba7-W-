class MyArray<T>
{
    private T[] array;

    public MyArray(int capacity = 0)
    {
        array = new T[capacity];
    }

    public int Length
    {
        get { return array.Length; }
    }

    public void Add(T item)
    {
        T[] newArray = new T[array.Length + 1];
        Array.Copy(array, newArray, array.Length);
        newArray[array.Length] = item;
        array = newArray;
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= array.Length)
        {
            throw new ArgumentOutOfRangeException("index");
        }

        T[] newArray = new T[array.Length - 1];
        Array.Copy(array, 0, newArray, 0, index);
        Array.Copy(array, index + 1, newArray, index, array.Length - index - 1);
        array = newArray;
    }

    public T Get(int index)
    {
        if (index < 0 || index >= array.Length)
        {
            throw new ArgumentOutOfRangeException("index");
        }

        return array[index];
    }
}

class Program
{
    static void Main()
    {
   
        MyArray<int> intArray = new MyArray<int>();
        intArray.Add(10);
        intArray.Add(20);
        intArray.Add(30);

     
        MyArray<string> stringArray = new MyArray<string>();
        stringArray.Add("Hello");
        stringArray.Add("World");

    
        MyArray<double> doubleArray = new MyArray<double>();
        doubleArray.Add(3.14);
        doubleArray.Add(2.71);

      
        Console.WriteLine("Целочисленный массив:");
        for (int i = 0; i < intArray.Length; i++)
        {
            Console.WriteLine(intArray.Get(i));
        }
      
        Console.WriteLine("\nСтроковый массив:");
        for (int i = 0; i < stringArray.Length; i++)
        {
            Console.WriteLine(stringArray.Get(i));
        }

  
        Console.WriteLine("\nМассив с плавающей точкой:");
        for (int i = 0; i < doubleArray.Length; i++)
        {
            Console.WriteLine(doubleArray.Get(i));
        }
    }
}
