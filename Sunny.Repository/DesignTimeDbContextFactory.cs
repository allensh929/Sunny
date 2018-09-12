﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sunny.Repository
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<MyDbContext>

    { 

        public MyDbContext CreateDbContext(string[] args)

        {

            var builder = new DbContextOptionsBuilder<MyDbContext>();
            

            builder.UseMySql("server=localhost;database=test;user=root;password=myAdmin.;");
            
            return new MyDbContext(builder.Options);


        }

    }
}
