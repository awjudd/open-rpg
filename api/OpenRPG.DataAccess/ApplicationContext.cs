using Microsoft.EntityFrameworkCore;

namespace OpenRPG.DataAccess;

public class ApplicationContext: DbContext 
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
    {

    }
}