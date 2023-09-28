﻿using Microsoft.EntityFrameworkCore;
using Proje.Domain;
using Proje.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Persistance
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private CompanyDbContext _context;

        public void SetDbContextInstance(DbContext context)
        {
            _context= (CompanyDbContext)context;    
        }

        public async Task<int> SaveChangeAsync()
        {
            int count = await _context.SaveChangesAsync();
            return count;
        }
    }
}
