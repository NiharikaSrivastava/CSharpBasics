/*
//Q4. Consider the code below. The comment in the implementation function can be thought of as the
//intended behavior of the object for that method. The comment 'no impl' means that there is no
//easy way for the object to implement the method.
//Which of the SOLID principles the following code primarily violates? And, re-write the code to show how will you fix it

//Ans) Interface Segrergation Principle - has been violated as a clients should never be forced to depend on methods they do not use.
//     here, class Fish was forced to depend on Walk() method and Class Bull was forced to depend on Swim() method although they both
//     do not implement it. Hence, the single interface IAnimal needs to be segregated into ITerrestrialAnimal and IAquaticAnimal and
//     have methods accordingly.       
namespace InSem2Practice
{
    class q4
    {
        static void Main(string[] args)
        {
            Bull b = new Bull();
            b.Breathe();
            b.Walk();
            //b.Swim(); //Not allowed
        }
    }
    interface IAnimal
    {
        void Breathe(); //All animals breathe
    }
    interface ITerrestrial: IAnimal
    {
        void Walk(); //All animals which live on land
    }
    interface IAquatic : IAnimal
    {
        void Swim(); //All animals which live in water
    }
    class Fish : IAquatic
    {
        public void  Breathe() {// breathe
        }
        public void Swim() { // swim 
        }
    }
    class Bull : ITerrestrial
    {
        public void Breathe(){ // breathe
        }
        public void Walk() { // walk
        }
    }
    class Frog : IAquatic, ITerrestrial //Multiple inheritance via interfaces is allowed, frog is an amphibian and by combination of both interfaces we can use all methods
    {
        public void Breathe()
        { // breathe
        }
        public void Walk()
        { // walk
        }
        public void Swim()
        { // swim 
        }
    }
}
*/