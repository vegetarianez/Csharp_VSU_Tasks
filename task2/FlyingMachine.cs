abstract class FlyingMachine
{
    protected int altitude = 0;
    protected bool isInAir = false;

    public void SetAltitude(int altitude)
    {
        this.altitude = altitude;
    }

    public int GetAltitude()
    {
        return this.altitude;
    }


    public abstract bool TakeOff();
    public abstract bool Landing();
}