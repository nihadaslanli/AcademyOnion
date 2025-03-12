using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Application.DTOs
{
    public class TeacherDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? GroupName { get; set; }
        public string? Subject { get;  set; }
        public List<GroupDto> Teachers { get; set; } = new List<GroupDto>();
    }
}
