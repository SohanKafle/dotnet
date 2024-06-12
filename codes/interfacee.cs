using System;
interface IAnimal 
{
  void animalSound(); 
}

class Dog : IAnimal 
{
  public void animalSound() 
  {
    Console.WriteLine("The dog says: bhau bhau");
  }
}

class Program 
{
  static void Main(string[] args) 
  {
    Dog myDog = new Dog();  
    myDog.animalSound();
  }
}