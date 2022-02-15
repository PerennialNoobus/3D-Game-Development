using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OOP2 : MonoBehaviour
{
    private void Start()
    {
        Vehicle vehicle;
        vehicle = new Vehicle("Toyota", 60);
        Vehicle.Drive();
    }
}

//Abstract classes can only be inherited from, not instantiated
public abstract class Vehicle
{
    private int speed;

    public Vehicle(int _speed)
    {
        speed = _speed;
    }

    public virtual void Drive()
    {
        Debug.Log("Driving at " + speed + " KMH.");
    }
}

public class Toyota : Vehicle
{
    public Toyota(int _speed)
    {

    }

    public override void Drive()
    base.Drive();
    Debug.Log("We be cruisin.");
}

//Base class
/*
 * Speed (var)
 * Drive (method)
 */
