


public class AutoDeliveryService
{
    public event Action<string> OnDeliveryNotify;

    public async Task StartAutoRestock(Action restockAction)
    {
        while (true)
        {
            await Task.Delay(50000);
            restockAction.Invoke();
            OnDeliveryNotify?.Invoke("Служба доставки: Машина прибыла.");
        }
    }

    public void Deliver(string product, int count) { }
}

