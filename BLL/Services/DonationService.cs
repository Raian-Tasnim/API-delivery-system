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
    public class DonationService
    {
        public static List<DonationDTO> Get()
        {
            var data = DataAccessFactory.DonationData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Donation, DonationDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<DonationDTO>>(data);
            return mapped;
        }
        public static DonationDTO Get(int id)
        {
            var data = DataAccessFactory.DonationData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Donation, DonationDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<DonationDTO>(data);
            return mapped;

        }
    }
}
