

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[Controller]")]

public class InventoryController : GenericController<Inventory>
{
    public InventoryController(ICRUDinterface<Inventory> CRUDinterface, ModelContext context) : base(CRUDinterface, context)
    {
    }
}