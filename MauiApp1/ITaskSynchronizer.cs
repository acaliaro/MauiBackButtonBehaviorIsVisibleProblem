
namespace daze.dazeapp.tests.Dequeuer
{
    public interface ITaskSynchronizer
    {
        Task EnqueueCommand(Func<Task> func);
        Task<T> EnqueueCommand<T>(Func<Task<T>> func) where T : class;
    }
}