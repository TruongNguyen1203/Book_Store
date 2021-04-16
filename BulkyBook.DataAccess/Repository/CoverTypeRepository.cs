﻿using BulkyBook.DataAccess.Data;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BulkyBook.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CoverType CoverType)
        {
            var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.Id == CoverType.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = CoverType.Name;
            }
        }
    }
}
