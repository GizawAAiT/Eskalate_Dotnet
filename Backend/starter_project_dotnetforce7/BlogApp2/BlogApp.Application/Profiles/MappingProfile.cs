﻿using AutoMapper;
using BlogApp.Application.Features._Indices.DTOs;
using BlogApp.Application.Features.Rates.DTOs;
using BlogApp.Application.Features.Reviews.DTOs;
using BlogApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Application.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            #region _index Mappings

            CreateMap<_Index, _IndexDto>().ReverseMap();
            CreateMap<_Index, Create_IndexDto>().ReverseMap();

            #endregion _index

            #region rate Mappings
            CreateMap<Rate, RateDto>().ReverseMap();
            CreateMap<Rate, UpdateRateDto>().ReverseMap();
            CreateMap<Rate, CreateRateDto>().ReverseMap();
            #endregion rate

            #region review Mappings
            CreateMap<Review, ReviewDto>().ReverseMap();
            CreateMap<Review, UpdateReviewDto>().ReverseMap();
            CreateMap<Review, CreateReviewDto>().ReverseMap();
            #endregion review
        }
    }
}