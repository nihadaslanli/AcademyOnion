﻿namespace Academy.Application.DTOs;

public class TeacherDto
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public List<GroupDto> Groups = new List<GroupDto>();
}

public class TeacherCreateDto
{
    public string Name { get; set; }
    public List<int> GroupIds { get; set; } = new List<int>();
}