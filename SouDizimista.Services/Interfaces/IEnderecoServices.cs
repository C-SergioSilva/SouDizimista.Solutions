using SouDizimista.Services.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SouDizimista.Services.Interfaces
{
    public interface IEnderecoServices
    {
        Task AddSave(EnderecoDTO dto);
        Task<IEnumerable<EnderecoDTO>> GetAll();
        Task<EnderecoDTO> Update(EnderecoDTO dto);
        Task MarkAsDeleted(Guid id);
        Task<EnderecoDTO> GetById(Guid id);
    }
}
