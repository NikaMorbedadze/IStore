using IStore.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IStore.Identity.Configurations;

public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
{
    public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
    {
        builder.HasData(
            new IdentityUserRole<string>
            {
                RoleId = "7b8ea170-e1b2-49bf-a81a-e392e14ef238",
                UserId = "477f9652-bf0d-4cf8-8eb7-4f0fe7faffd3"
            },
            new IdentityUserRole<string>
            {
                RoleId = "706e3b97-eb09-4cfa-9490-a20a8021c501",
                UserId = "c96c9530-fcf8-4a61-b0a7-f01df388c8f0"
            }
        );
    }
}