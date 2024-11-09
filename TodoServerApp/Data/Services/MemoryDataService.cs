using TodoServerApp.Data.Interfaces;

namespace TodoServerApp.Data.Services
{
    public class MemoryDataService : IDataService
    {
        public static IEnumerable<TaskItem> tasks { get; } = [
            new(){ Id = 1, Title="Задание 1", Description="Описание задачи 1", CreatedDate=DateTime.Now },
            new (){ Id = 2, Title="Задание 2", Description="Описание задачи 2", CreatedDate=DateTime.Now },
            new (){ Id = 3, Title="Задание 3", Description="Описание задачи 3", CreatedDate=DateTime.Now },
        ];

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TaskItem> GetTaskAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TaskItem>> GetAllAsync()
        {
            await Task.Delay(1000);
            return await Task.FromResult(tasks);
        }

        public Task SaveAsync(TaskItem item)
        {
            throw new NotImplementedException();
        }
    }
}
