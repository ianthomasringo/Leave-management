﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using leave_management.Models;

namespace leave_management.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<LeaveRequest> LeaveRequests { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }
        //public DbSet<leave_management.Models.LeaveRequestVM> LeaveRequestVM { get; set; }
        public DbSet<TestAppFormGen> TestAppFormGens { get; set; }
        public DbSet<TestAppFormSpecA> TestAppFormSpecAs { get; set; }
        public DbSet<TestAppFormSpecB> TestAppFormSpecBs { get; set; }
    }
}
