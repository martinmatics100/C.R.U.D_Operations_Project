using BE_CRUD_Operations.Core.Interfaces.IRepository;
using BE_CRUD_Operations.Data.AppDbContext;
using BE_CRUD_Operations.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_CRUD_Operations.Data.Repository
{
    public class StudentRepository : IBaseRepository<Student>
    {
        private readonly CRUD_DbContext _context;

        public StudentRepository(CRUD_DbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Student entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            try
            {
                _context.students.Add(entity);
                await SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public async Task DeleteAsync(Student entity)
        {
            _context.students.Remove(entity);
            await SaveChangesAsync();
        }

        public async Task<IEnumerable<Student>> GetAllAsync()
        {
            return await _context.students.ToListAsync();
        }

        public async Task<Student> GetByIdAsync(string Id)
        {
            return await _context.students.FirstOrDefaultAsync(s => s.StudentId == Id);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Student entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
