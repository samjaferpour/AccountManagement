using AccountManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace AccountManagement.Persistence.Implimentation
{
    public class AccountManagementDbContext : DbContext
    {
        public AccountManagementDbContext(DbContextOptions options)
         : base(options)
        {
        }
        public DbSet<Letter> Letters { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<DemandPacket> DemandPackets { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<AccountOwnershipType> AccountOwnershipType { get; set; }
        public DbSet<BlockUnblockReason> BlockUnblockReasons { get; set; }
        public DbSet<DemandStatus> DemandStatus { get; set; }
        public DbSet<LetterType> LetterType { get; set; }
        public DbSet<BlockAccountTransaction> BlockAccountTransactions { get; set; }
        public DbSet<WithdrawAccountTransaction> WithdrawAccountTransactions { get; set; }
       
        public DbSet<SubscriptionType> SubscriptionTypes { get; set; }
        public DbSet<SwiftType> SwiftTypes { get; set; }
        public DbSet<DemandPacketSubscriptionType> DemandPacketSubscriptionTypes { get; set; }
        public DbSet<DemandPacketAccountOwnershipType> DemandPacketAccountOwnershipTypes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AccountManagementDbContextHelpers.EntityConfigurations(modelBuilder);
        }
    }
}
