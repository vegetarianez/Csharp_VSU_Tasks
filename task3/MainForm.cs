



public class MainForm : Form
{
    private FlowLayoutPanel _flow;

    public MainForm()
    {
        this.Text = "Динамическая симуляция торговых точек";
        this.Size = new System.Drawing.Size(1300, 800);

        _flow = new FlowLayoutPanel { Dock = DockStyle.Fill, AutoScroll = true, BackColor = System.Drawing.Color.DarkGray };
        Button btnAdd = new Button { Text = "Добавить модель точки", Dock = DockStyle.Top, Height = 40 };
        btnAdd.Click += AddModel;
        this.Controls.Add(_flow);
        this.Controls.Add(btnAdd);
    }

    private void AddModel(object sender, EventArgs e)
    {
        var products = new List<Product> {
            new Product("Товар", 50, 50)
        };
        var store = new TradingPoint($"Магазин #{_flow.Controls.Count + 1}", products);
        var vm = new StoreViewModel(store);
        var view = new SimulationControl(vm);
        _flow.Controls.Add(view);
    }
}
