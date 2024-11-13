

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[Controller]")]

public class OrderController : GenericController<Order>
{
    public OrderController(ICRUDinterface<Order> CRUDinterface, ModelContext context) : base(CRUDinterface, context)
    {
    }
}