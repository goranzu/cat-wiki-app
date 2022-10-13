namespace CatWikiApp.Api;

public static class ThreadSafeRandom
{
    [ThreadStatic] private static Random Local = null!;

    public static Random ThisThreadsRandom
    {
        get { return Local ??= new Random(unchecked(Environment.TickCount + 31 + Environment.CurrentManagedThreadId)); }
    }

}

public static class MyExtensions
{
    public static void Shuffle<T>(this IList<T> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = ThreadSafeRandom.ThisThreadsRandom.Next(n + 1);
            (list[n], list[k]) = (list[k], list[n]);
            // T value = list[k];
            // list[k] = list[n];
            // list[n] = value;
        }
    }
}