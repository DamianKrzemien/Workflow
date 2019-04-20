using Microsoft.EntityFrameworkCore;
using Workflow.BLL.Entities;

public class WorkflowContext : DbContext
{
    public WorkflowContext() : base("WorkflowContext")
    {

    }

    public DbSet<Expense> Expenses { get; set; }
    public DbSet<PaymentOnAccount> PaymentsOnAccount { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Report> Reports { get; set; }
    public DbSet<ReportedHours> ReportedHours { get; set; }
    public DbSet<StockItem> StockItems { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Worker> Workers { get; set; }
    public DbSet<WorkerAddress> WorkersAddresses { get; set; }
    public DbSet<Role> Roles { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
    }
}

