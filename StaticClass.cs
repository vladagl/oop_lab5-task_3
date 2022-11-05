public static class StaticClass
{
    public static T[] GetArray<T>(this IEnumerable<T> list)
    {
        int i = 0; T[] array = new T[i];
        foreach (T item in list)
        {
            T[] NewArray = new T[array.Length + 1];
            array.CopyTo(NewArray, 0);
            NewArray[array.Length] = item;
            array = NewArray;

        }
        return array;
    }
}