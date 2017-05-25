﻿using System;
using UklonBot.Models.Repositories.Exact;

namespace UklonBot.Models.Repositories.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        GenericRepository<User> Users { get; }

        void Save();
    }
}