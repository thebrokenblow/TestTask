namespace TestTask;

public static class ThirdExercise
{
    private static int count;
    private static readonly ReaderWriterLockSlim countLock = new();

    public static int GetCount()
    {
        countLock.EnterReadLock();
        try
        {
            return count;
        }
        finally
        {
            countLock.ExitReadLock();
        }
    }

    public static void AddToCount(int value)
    {
        countLock.EnterWriteLock();
        try
        {
            count += value;
        }
        finally
        {
            countLock.ExitWriteLock();
        }
    }
}
