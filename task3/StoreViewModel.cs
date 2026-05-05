

public class StoreViewModel
{
    public TradingPoint Model { get; }
    public List<Customer> ActiveCustomers { get; } = new List<Customer>();
    private AutoDeliveryService _delivery = new AutoDeliveryService();

    public StoreViewModel(TradingPoint model)
    {
        Model = model;
        _ = _delivery.StartAutoRestock(() => Model.RestockAll());
    }

    public string GetModelInfo()
    {
        Type t = Model.GetType();
        return $"[Class: {t.Name}] Store: {Model.Name}";
    }
}