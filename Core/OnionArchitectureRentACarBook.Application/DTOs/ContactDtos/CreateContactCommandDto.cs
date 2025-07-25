﻿namespace OnionArchitectureRentACarBook.Application.DTOs.ContactDtos;

public class CreateContactCommandDto
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Subject { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public DateTime SendDate { get; set; }  
}
