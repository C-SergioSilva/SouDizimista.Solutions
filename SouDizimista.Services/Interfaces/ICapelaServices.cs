using SouDizimista.Services.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SouDizimista.Services.Interfaces
{
    public interface ICapelaServices
    {
        Task AddSave(CapelaDTO dto);
        Task<IEnumerable<CapelaDTO>> GetAll();
        Task<CapelaDTO> Update(CapelaDTO dto);
        Task MarkAsDeleted(Guid? id);
        Task<CapelaDTO> GetById(Guid id);
    }
}
