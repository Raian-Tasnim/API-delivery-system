using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Doner, int, Doner> DonerData()
        {
            return new DonerRepo();
        }

        public static IRepo<Campaign, int, Campaign> CampaignData()
        {
            return new CampaignRepo();
        }

        public static IRepo<Donation, int, Donation> DonationData()
        {
            return new DonationRepo();
        }
       
       public static IAuth<bool> AuthData()
        {
            return new DonerRepo();
        }
        public static IRepo<Token, string, Token> TokenData()
        {
            return new TokenRepo();
        }
    }
}
