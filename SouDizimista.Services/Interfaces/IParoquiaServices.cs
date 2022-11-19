using SouDizimista.Services.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SouDizimista.Services.Interfaces
{
    public interface IParoquiaServices
    { 
        Task AddSave(ParoquiaDTO dto);
        Task<IEnumerable<ParoquiaDTO>> GetAll();
        Task<ParoquiaDTO> Update(ParoquiaDTO dto);
        Task MarkAsDeleted(Guid id);
        Task<ParoquiaDTO> GetById(Guid id);
    }
}
