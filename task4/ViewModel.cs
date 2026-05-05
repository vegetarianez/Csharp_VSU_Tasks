using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;


public class MainViewModel
{
    public List<Type> AvailableTypes { get; private set; } = new List<Type>();
    private object _currentInstance;


    public void LoadLibrary(string path)
    {
        Assembly asm = Assembly.LoadFrom(path);
        AvailableTypes = asm.GetTypes()
            .Where(t => t.IsClass && !t.IsAbstract && IsSubclassOfRawGeneric(t, "FlyingMachine"))
            .ToList();
    }


    private bool IsSubclassOfRawGeneric(Type type, string baseName)
    {
        while (type != null && type != typeof(object))
        {
            if (type.Name == baseName || (type.BaseType != null && type.BaseType.Name == baseName))
                return true;
            type = type.BaseType;
        }
        return false;
    }

    public void CreateInstance(Type type, object[] args)
    {
        _currentInstance = Activator.CreateInstance(type, args);
    }


    public string InvokeMethod(string methodName, object[] parameters)
    {
        if (_currentInstance == null) return "Сначала создайте объект!";

        MethodInfo method = _currentInstance.GetType().GetMethod(methodName);
        object result = method.Invoke(_currentInstance, parameters);

        return result?.ToString() ?? "Метод выполнен";
    }

    public object GetCurrentInstance() => _currentInstance;
}
