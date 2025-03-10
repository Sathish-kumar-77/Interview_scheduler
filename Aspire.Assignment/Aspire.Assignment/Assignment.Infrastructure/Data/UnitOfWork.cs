﻿using Assignment.Contracts.Data;
using Assignment.Contracts.Data.Repositories;
using Assignment.Core.Data.Repositories;
using Assignment.Infrastructure.Data.Repositories;
using Assignment.Migrations;

namespace Assignment.Core.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }
        public IAppRepository App => new AppRepository(_context);

        public IUserRepository User => new UserRepository(_context);

        public IUsersRepository Users => new UsersRepository(_context);
        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}