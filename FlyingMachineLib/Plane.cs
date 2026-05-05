public class Plane : FlyingMachine
{
    private int runwayLenght;

    private int NEEDED_LENGHT = 2000;

    public Plane(int runwayLenght)
    {
        if (runwayLenght > 0)
        {
            this.runwayLenght = runwayLenght;
        }
        else
        {
            throw new Exception("Длина должна быть больше 0");
        }
        
    }

    public int GetRunwayLenght()
    {
        return runwayLenght;
    }

    public int SetRunwayLenght(int runwayLenght)
    {
        if (runwayLenght > 0)
        {
            this.runwayLenght = runwayLenght;
        }
        throw new Exception("Длина должна быть больше 0");
    }

    public override bool Landing()
    {
        if (isInAir)
        {
            SetAltitude(0);
            isInAir = false;
            Console.WriteLine("Самолёт приземлился успешно");
            return true;
        }
        
        Console.WriteLine("Самолёт уже в воздухе");
        return false;
    }

    public override bool TakeOff()
    {
        if (runwayLenght >= NEEDED_LENGHT && !isInAir)
        {
            Console.WriteLine("Самолёт взлетел успешно");
            SetAltitude(12000);
            isInAir = true;
            return true;
        }
        else if (isInAir)
        {
            Console.WriteLine("Самолёт уже в небе");
            return false;
        }
        else
        {
            Console.WriteLine("Самолёт разбился");
            return false;
        }
    }
}