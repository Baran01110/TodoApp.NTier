using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.NTier.Dtos.WorkDtos;

namespace TodoApp.NTier.Business.Interfaces
{
   public interface IWorkService
    {
        Task<List<WorkListDto>> GetAll();

        Task Create(WorkCreateDto dto);
    }
}
