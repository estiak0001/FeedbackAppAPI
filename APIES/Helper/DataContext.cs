//using APIES.DBEntities;
//using APIES.Models.customerPO;
//using APIES.Models.CustomID;
//using APIES.Models.Transport;
using APIES.Entities;
using AutoMapper.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIES.Helper
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<MobileRND_UserFeedback> MobileRND_UserFeedback { get; set; }
        public DbSet<MobileRND_UserFeedbackCriteria> MobileRND_UserFeedbackCriteria { get; set; }
        public DbSet<MobileRND_ModelWiseCriteria> MobileRND_ModelWiseCriteria { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }


    }
}
