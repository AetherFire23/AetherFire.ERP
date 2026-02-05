using Mediator;

namespace ERP.Application.Features.ManualAdjustmentFeature.Commands.ModifyItemQuantity;

public class ModifyItemQuantityRequest : IRequest
{
    public Guid ProductId { get; set; }
    public int NewQuantity { get; set; }
    public Guid WarehouseId { get; set; }
}