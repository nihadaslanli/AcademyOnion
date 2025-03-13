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
    public interface ITeacherGroupService
    {
        TeacherManager GetTeacherGroup(Func<TeacherGroup, bool> predicate);
        List<TeacherManager> GetTeacherGroups(Expression<Func<TeacherGroup, bool>>? predicate = null);
        void AddTeacherGroup(TeacherGroupDto teacherGroup);
        void RemoveTeacherGroup(int id);
        void UpdateTeacherGroup(int id, TeacherGroup teacherGroup);
        void DeleteTeacherGroup(int id);

    }

  
}
