﻿using CashFlow.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CashFlow.Infrastructure.DataAccess;

internal class CashFlowDbContext : DbContext
{
    public DbSet<Expense> Expenses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "Server=localhost;Database=cashflowdb;Uid=root;Pwd=root;";
        var MySqlVersion = new Version(8, 0, 37);
        var serverVersion = new MySqlServerVersion(MySqlVersion);

        optionsBuilder.UseMySql(connectionString, serverVersion);
    }
}