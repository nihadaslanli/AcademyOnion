using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Application.Repositories;
using Academy.Domain.Entities;
using Academy.Infrastructure.EfCore;

namespace Academy.Infrastructure.Repositories
{
    public class TeacherRepository: EfCoreRepository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(AppDbContext context) : base(context)
        {
        }
    }
}
