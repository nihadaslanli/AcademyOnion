using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Academy.Application.DTOs;
using Academy.Application.Repositories;
using Academy.Application.Services.Contracts;
using Academy.Domain.Entities;

namespace Academy.Application.Services
{
    internal class TeacherManager: ITeacherService
    {
        private readonly ITeacherRepository _repository;

        public TeacherManager(ITeacherRepository repository)
        {
            _repository = repository;
        }
        public void AddTeacher(TeacherDto createDto)
        {
            var teacher = new Teacher
            {
                Name = createDto.Name,
                Subject = createDto.Subject
            };
            _repository.Add(teacher);
        }

        public TeacherDto GetTeacher(Func<Teacher, bool> predicate)
        {
            var teacher = _repository.Get(predicate);
            var teacherDto = new TeacherDto
            {
                Id = teacher.Id,
                Name = teacher.Name,
                GroupName = teacher.Group?.Name,
                Subject = (string)teacher.Subject
            };
            return teacherDto;
        }

        public List<TeacherDto> GetTeachers(Expression<Func<Teacher, bool>>? predicate = null)
        {
            var teacherDtos = new List<TeacherDto>();
            foreach (var item in _repository.GetAll(predicate))
            {
                teacherDtos.Add(new TeacherDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    GroupName = item.Group?.Name,
                    Subject = (string)item.Subject
                });
            }
            return teacherDtos;
        }
        public void RemoveTeacher(int id)
        {
            _repository.Remove(id);
        }

        public void UpdateTeacher(int id, Teacher teacher)
        {
            _repository.Update(id, teacher);
        }
    }
}
