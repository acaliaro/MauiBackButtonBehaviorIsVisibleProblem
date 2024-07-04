namespace daze.dazeapp.tests.Dequeuer;

public class TaskSynchronizer : ITaskSynchronizer
{
    private SemaphoreSlim _lock = new SemaphoreSlim(1, 1);
    public async Task<T> EnqueueCommand<T>(Func<Task<T>> func) where T : class
    {
        await _lock.WaitAsync();
        try
        {
            return await func();
        }
        finally
        {
            _lock.Release();
        }
    }

    public async Task EnqueueCommand(Func<Task> func)
    {
        await _lock.WaitAsync();
        try
        {
            await func();
        }
        finally
        {
            _lock.Release();
        }
    }
}