namespace Academy.Application.DTOs;

public class GroupDto
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public List<StudentDto> Students { get; set; } = new List<StudentDto>();
    public string? TeacherName { get; set; }
    public TeacherDto? Teacher { get; set; }
    public int TeacherId { get; set; }
}

public class GroupCreateDto
{
    public string Name { get; set; }
}
