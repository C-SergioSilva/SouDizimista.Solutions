﻿using SouDizimista.Domain.Entities;
using SouDizimista.Domain.Interfaces;
using SouDizimista.Repository.ContextDB;

namespace SouDizimista.Repository.Repository
{
    public class ParoquiaRepository : RepositoryBase<Paroquia>, IParoquiaRepository
    {
        public ParoquiaRepository(Context context) : base(context){}
    }
}
