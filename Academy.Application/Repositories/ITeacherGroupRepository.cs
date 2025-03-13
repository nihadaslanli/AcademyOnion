using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Application.Services;
using Academy.Domain.Entities;

namespace Academy.Application.Repositories
{
    public interface ITeacherGroupRepository
    {
        TeacherManager GetTeacherGroup(Func<TeacherGroup, bool> predicate);
        List<TeacherManager> GetTeacherGroups(Func<TeacherGroup, bool> predicate);
        void AddTeacherGroup(TeacherGroup teacherGroup);
        void RemoveTeacherGroup(int id);
        void UpdateTeacherGroup(int id, TeacherGroup teacherGroup);
        void DeleteTeacherGroup(int id);
    }
}
