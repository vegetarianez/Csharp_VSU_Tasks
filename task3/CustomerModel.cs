


public class Customer
{
    public PointF Position;
    public float Speed;
    public bool IsFinished { get; set; }
    private Random _rnd = new Random();

    public double PurchaseProbability { get; set; }

    public Customer(PointF startPos, float speed, double prob)
    {
        Position = startPos;
        Speed = speed;
        PurchaseProbability = prob;
    }

    public void MoveTowards(Point target)
    {
        float dx = target.X - Position.X;
        float dy = target.Y - Position.Y;
        float dist = (float)Math.Sqrt(dx * dx + dy * dy);

        if (dist > 5)
        {
            Position.X += (dx / dist) * Speed;
            Position.Y += (dy / dist) * Speed;
        }
        else
        {
            IsFinished = true;
        }
    }

    public bool DecideToBuy()
    {
        return _rnd.NextDouble() < PurchaseProbability;
    }
}
