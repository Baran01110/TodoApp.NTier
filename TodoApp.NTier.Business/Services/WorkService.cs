using System.Collections.Generic;
using System.Threading.Tasks;
using TodoApp.NTier.Business.Interfaces;
using TodoApp.NTier.DataAccess.UnitofWork;
using TodoApp.NTier.Entities.Domains;
using ToDoApp.NTier.Dtos.WorkDtos;

namespace TodoApp.NTier.Business.Services
{
    public class WorkService : IWorkService
    {
        private readonly IUow _uow;

        public WorkService(IUow uow)
        {
            _uow = uow;
        }

        public async Task Create(WorkCreateDto dto)
        {
            await _uow.GetRepository<Work>().Create(new()
            {
                IsCompleted = dto.IsCompleted,
                Definition = dto.Definition,
            });
            await _uow.SaveChanges();
        }

        public async Task<List<WorkListDto>> GetAll()
        {
           var list = await _uow.GetRepository<Work>().GetAll();
            var worklist = new List<WorkListDto>();
            if (list != null && list.Count > 0)
            {
                foreach (var work in list)
                {
                    worklist.Add(new()
                    {
                        Definition = work.Definition,
                        Id = work.Id,
                        IsCompleted = work.IsCompleted,
                    });
                }
            }
            return worklist;
        }
    }
}
