﻿using AutoMapper;
using E_Learning_Management_System.DTO;
using E_Learning_Management_System.Models;

namespace E_Learning_Management_System
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CourseDTO, Course>();
            CreateMap<Course, CourseDTO>();
        }
    }
}