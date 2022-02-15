using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//MonoBehaviours can be attached to Unity game objects
public class OOP : MonoBehaviour
{
    private void Start()
    {
        Fish fish; //Create an empty variable that stores fish data type
        //Instantiate fish and store in variable
        fish = new Fish("Paratilapia polleni", 7);
        fish.PrintAnimal(); //Call PrintAnimal method from fish
    }
}

//Abstract classes can only be inherited from, not instantiated
public abstract class Animal
{
    private string name;
    private int age;

    //Class constructor for instantiating the object
    public Animal(string _name, int _age) //Class constructor
    {
        name = _name;
        age = _age;
    }

    //Abstract method must be implemented in derived (child) classes
    public abstract void Eat();
    public abstract void Eat(string food);

    //Virtual method may have implementation overridden
    public virtual void PrintAnimal()
    {
    Debug.Log("Name: " + name);
    Debug.Log("Age: " + age);
    }
}


public class Fish : Animal //Fish class inherits the animal class
{
    //Fish constructor 
    //Passes parameters to base class constructor
    public Fish(string _name, int _age) : base(_name, _age)
    {

    }

    //Overridden versions of Animal's Eat method
    public override void Eat()
    {
        Debug.Log("Fish is eating.");
    }

        public override void Eat(string food)
    {
        Debug.Log("Fish has eaten: " + food);
    }

    //Extended version of Animal's PrintAnimal method
    public override void PrintAnimal()
    {
        base.PrintAnimal();
        Debug.Log("This is a fish");
    }
}