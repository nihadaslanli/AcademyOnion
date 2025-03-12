using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Academy.Application.DTOs;
using Academy.Domain.Entities;

namespace Academy.Application.Services.Contracts
{
    public interface ITeacherService
    {
        void AddTeacher(TeacherDto createDto);
        TeacherDto GetTeacher(Func<Teacher, bool> predicate);
        List<TeacherDto> GetTeachers(Expression<Func<Teacher, bool>>? predicate = null);
        void RemoveTeacher(int id);
        void UpdateTeacher(int id, Teacher teacher);
    }
}
