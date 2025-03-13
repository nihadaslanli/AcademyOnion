using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Application.DTOs
{
    public class TeacherGroupDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        TeacherCreateDto Teacher { get; set; }
        GroupCreateDto Group { get; set; }
        public TeacherGroupDto() 
        { 
            Group = new GroupCreateDto();
            Teacher = new TeacherCreateDto();

        }
    }

}
