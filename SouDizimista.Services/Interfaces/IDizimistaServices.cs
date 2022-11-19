using SouDizimista.Services.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SouDizimista.Services.Interfaces
{
    public interface IDizimistaServices
    {
        Task AddSave(DizimistaDTO dto);
        Task<IEnumerable<DizimistaDTO>> GetAll();
        Task<DizimistaDTO> Update(DizimistaDTO dto);
        Task MarkAsDeleted(Guid id);
        Task<DizimistaDTO> GetById(Guid id);
    }
}
