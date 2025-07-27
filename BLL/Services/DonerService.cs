using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class DonerService
    {
        public static List<DonerDTO> Get()
        {
            var data = DataAccessFactory.DonerData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Doner, DonerDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<DonerDTO>>(data);
            return mapped;
        }
        public static DonerDTO Get(int id)
        {
            var data = DataAccessFactory.DonerData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Doner, DonerDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<DonerDTO>(data);
            return mapped;

        }
    }
}
