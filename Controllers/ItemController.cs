
using Microsoft.AspNetCore.Components;

[Route("api/[Controller]")]
public class ItemController : GenericController<Item>
{
    public ItemController(ICRUDinterface<Item> CRUDinterface, ModelContext context) : base(CRUDinterface, context)
    {

    }
}