class Helicopter : FlyingMachine
{
    public override bool Landing()
    {
        SetAltitude(0);
        Console.Write("Вертолёт приземлился успешно");
        return true;
    }

    public override bool TakeOff()
    {
        SetAltitude(2000);
        Console.Write("Вертолёт взлетел успешно");
        return true;
    }
}