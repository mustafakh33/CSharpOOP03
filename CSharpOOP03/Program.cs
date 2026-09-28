namespace CSharpOOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions
            #region Question01

            // Q1  Overloading, Overriding, and Binding
            // a)  What is the difference between Method Overloading and Method Overriding?
            // Asnwer:
            // Method Overloading is a feature that allows a class to have multiple methods with the same name but different parameters (different type, number, or order of parameters). It is resolved at compile time (static binding).
            // Method Overriding, on the other hand, occurs when a subclass provides a specific implementation of a method that is already defined in its superclass. It is resolved at runtime (dynamic binding).

            // b)  What is the difference between Static Binding and Dynamic Binding?
            // Asnwer:
            // Static Binding is the process of resolving a method call at compile time, based on the type of the reference variable.
            // Dynamic Binding is the process of resolving a method call at runtime, based on the actual type of the object.

            #endregion

            #region Question02
            // Q2  Sealed Classes and Methods
            // a)  What is the purpose of the sealed keyword when applied to a class?
            // Answer: The purpose of the sealed keyword when applied to a class is to prevent the class from being inherited by other classes.

            // b)  What is the difference between a sealed class and a sealed method?
            // Answer: A sealed class is a class that cannot be inherited, while a sealed method is a method that cannot be overridden in a derived class.

            // c)  Can a sealed method be overridden? Why?
            // Answer: No, a sealed method cannot be overridden because the sealed keyword prevents any further overriding of that method in derived classes.

            #endregion
            #endregion
        }
}
}
