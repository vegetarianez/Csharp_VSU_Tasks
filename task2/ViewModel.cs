using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class ViewModel
    {
        FlyingMachine? machine;

        internal void Create(int altitude, string type)
        {
            switch (type)
            {
                case "Самолёт":
                    machine = new Plane(altitude);
                    break;
                case "Вертолёт":
                    machine = new Helicopter(altitude);
                    break;
                default:
                    throw new ArgumentException($"Неизвестный тип: { type }");
            }
        }

        internal string Landing()
        {
            if (machine.Landing())
            {
                return $"Судно село успешно. Высота: { machine.GetAltitude() }";
            }
            return $"Судно не смогло сесть Высота: {machine.GetAltitude() }";
        }

        internal string TakeOff()
        {
            if (machine.TakeOff())
            {
                return $"Судно в воздухе успешно Высота: {machine.GetAltitude() }";
            }
            return $"Судно не смогло взлететь Высота: {machine.GetAltitude() }";
        }
    }
}
