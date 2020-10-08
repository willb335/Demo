using Demo.Dtos;
using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace Demo.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {

            // Source -> Target
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
        }

    }
}
