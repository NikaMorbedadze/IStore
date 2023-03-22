using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IStore.Identity.Configurations;

public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        builder.HasData(
            new IdentityRole
            {
                Id = "7b8ea170-e1b2-49bf-a81a-e392e14ef238",
                Name = "Employee",
                NormalizedName = "EMPLOYEE"
            },
            new IdentityRole
            {
                Id = "706e3b97-eb09-4cfa-9490-a20a8021c501",
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR"
            }
        );
    }
}