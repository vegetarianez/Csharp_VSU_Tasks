class Helicopter : FlyingMachine
{
    public Helicopter(int altitude)
    {
        this.altitude = altitude;
    }

    public override bool Landing()
    {
        if (isInAir)
        {
            SetAltitude(0);
            isInAir = false;
            Console.Write("Вертолёт приземлился успешно");
            return true;
        }
        Console.Write("Вертолёт уже на земле");
        return false;
    }

    public override bool TakeOff()
    {
        if (isInAir)
        {
            Console.Write("Вертолёт уже в воздухе");
            return false;
        }
        SetAltitude(2000);
        Console.Write("Вертолёт взлетел успешно");
        isInAir = true;
        return true;
    }
}