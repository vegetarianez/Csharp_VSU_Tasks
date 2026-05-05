


public class SimulationControl : UserControl
{
    private StoreViewModel _vm;
    private System.Windows.Forms.Timer _timer;
    private Random _rnd = new Random();
    private List<string> _logs = new List<string>();

    public SimulationControl(StoreViewModel vm)
    {
        _vm = vm;
        this.DoubleBuffered = true;
        this.Size = new Size(400, 300);
        this.BorderStyle = BorderStyle.Fixed3D;
        this.BackColor = Color.White;

        _vm.Model.OnEvent += (msg, alert) => {
            _logs.Add(msg);
            if (_logs.Count > 5) _logs.RemoveAt(0);
        };

        _timer = new System.Windows.Forms.Timer { Interval = 30 };
        _timer.Tick += UpdateSimulation;
        _timer.Start();
    }

    private void UpdateSimulation(object sender, EventArgs e)
    {
        if (_rnd.Next(100) < 5)
        {
            _vm.ActiveCustomers.Add(new Customer(
                new PointF(_rnd.Next(this.Width), this.Height),
                (float)(_rnd.NextDouble() * 3 + 1),
                0.7
            ));
        }

        Point storePos = new Point(this.Width / 2, 50);
        for (int i = _vm.ActiveCustomers.Count - 1; i >= 0; i--)
        {
            var c = _vm.ActiveCustomers[i];
            c.MoveTowards(storePos);

            if (c.IsFinished)
            {
                if (c.DecideToBuy())
                {
                    _vm.Model.ProcessPurchase("Товар", 1);
                }
                _vm.ActiveCustomers.RemoveAt(i);
            }
        }
        this.Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        g.FillRectangle(Brushes.RoyalBlue, this.Width / 2 - 30, 20, 60, 40);
        g.DrawString(_vm.GetModelInfo(), this.Font, Brushes.Black, 10, 5);

        int y = 70;
        foreach (var p in _vm.Model.Products)
        {
            float fill = (float)p.Stock / p.MaxStock * 100;
            g.DrawString($"{p.Name}: {p.Stock}", this.Font, Brushes.Black, 10, y);
            g.FillRectangle(Brushes.LightGray, 100, y, 100, 10);
            g.FillRectangle(fill < 20 ? Brushes.Red : Brushes.Green, 100, y, fill, 10);
            y += 20;
        }

        foreach (var c in _vm.ActiveCustomers)
        {
            g.FillEllipse(Brushes.OrangeRed, c.Position.X - 5, c.Position.Y - 5, 10, 10);
        }

        for (int i = 0; i < _logs.Count; i++)
            g.DrawString(_logs[i], this.Font, Brushes.Gray, 220, 70 + (i * 15));
    }
}
