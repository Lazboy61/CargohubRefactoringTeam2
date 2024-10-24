

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[Controller]")]

public class LocationController : GenericController<Location>
{
    public LocationController(ICRUDinterface<Location> CRUDinterface, ModelContext context) : base(CRUDinterface, context)
    {
    }
}