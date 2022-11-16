namespace SolidPrinciples;

// Before

// interface IHuman
// {
//     void Eat();
//     void Talk();
//     void Walk();
//     void Sleep();
//     void Run();
// }
// 
// class Human : IHuman
// {
//     public void Eat() => throw new NotImplementedException();
//     public void Run() => throw new NotImplementedException();
//     public void Sleep() => throw new NotImplementedException();
//     public void Talk() => throw new NotImplementedException();
//     public void Walk() => throw new NotImplementedException();
// }
// class FoodBank
// {
//     public void AddToList(IHuman human) => throw new NotImplementedException();
//     public void AddToList(IAnimal animal) => throw new NotImplementedException();
// }
// interface IAnimal
// {
//     void Eat();
//     void Bark();
//     void Walk();
//     void Sleep();
//     void Run();
//     void Bite();
// }

// After

interface IOmnivore
{
    void Eat();
}

interface IHuman : IOmnivore
{
    void Talk();
    void Walk();
    void Sleep();
    void Run();
}

interface IAnimal : IOmnivore
{
    void Bark();
    void Walk();
    void Sleep();
    void Run();
    void Bite();
}

class FoodBank
{
    public void AddToList(IOmnivore omnivore) => throw new NotImplementedException();
}