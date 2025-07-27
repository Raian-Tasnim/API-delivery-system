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
    public class CampaignService
    {
        public static List<CampaignDTO> Get()
        {
            var data = DataAccessFactory.CampaignData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Campaign, CampaignDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<CampaignDTO>>(data);
            return mapped;
        }
        public static CampaignDTO Get(int id)
        {
            var data = DataAccessFactory.CampaignData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Campaign, CampaignDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<CampaignDTO>(data);
            return mapped;

        }
    }
}
