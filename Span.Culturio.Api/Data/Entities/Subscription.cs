using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Span.Culturio.Api.Models;

namespace Span.Culturio.Api.Data.Entities
{
    public class Subscription
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PackageId { get; set; }
        public string Name { get; set; }
        public DateTime ActiveFrom { get; set; }
        public DateTime ActiveTo { get; set; }
        public string State { get; set; }

        public virtual User User { get; set; }
        public virtual Package Package { get; set; }
        
        public int RecordedVisits { get; set; }
        //public virtual ICollection<RecordedVisits> RecordedVisits { get; set; }
    }

    public class SubscriptionConfigurationBuilder : IEntityTypeConfiguration<Subscription>
    {
        public void Configure(EntityTypeBuilder<Subscription> builder)
        {
            builder.ToTable(nameof(Subscription));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name)
                 .IsRequired();
            builder.Property(x => x.ActiveFrom)
                 .IsRequired();
            builder.Property(x => x.ActiveTo)
                .IsRequired();
            builder.Property(x => x.State)
                .IsRequired();
            builder.HasOne(x => x.User)
                .WithMany(u => u.Subscriptions)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Package)
                .WithMany(u => u.Subscriptions)
                .HasForeignKey(x => x.PackageId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
