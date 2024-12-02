using System;
using System.Collections.Generic;

/// <summary>
/// Interface for defining the behavior of objects in different states.
/// </summary>
public interface IState
{
    void HandleRequest();
}

/// <summary>
/// Concrete implementation of a specific state that handles the request in one way.
/// </summary>
public class ConcreteStateA : IState
{
    public void HandleRequest()
    {
        Console.WriteLine("State A: Handling request in State A.");
    }
}

/// <summary>
/// Concrete implementation of another specific state that handles the request differently.
/// </summary>
public class ConcreteStateB : IState
{
    public void HandleRequest()
    {
        Console.WriteLine("State B: Handling request in State B.");
    }
}

/// <summary>
/// Context class that maintains a reference to a State object and delegates handling requests to the current state.
/// </summary>
public class Context
{
    private IState _state;

    /// <summary>
    /// Initializes the context with an initial state.
    /// </summary>
    /// <param name="state">Initial state.</param>
    public Context(IState state)
    {
        _state = state;
    }

    /// <summary>
    /// Changes the current state of the context.
    /// </summary>
    /// <param name="state">New state to transition to.</param>
    public void SetState(IState state)
    {
        _state = state;
        Console.WriteLine($"State changed to: {state.GetType().Name}");
    }

    /// <summary>
    /// Handles a request by delegating to the current state.
    /// </summary>
    public void Request()
    {
        _state.HandleRequest();
    }
}

/// <summary>
/// Client code demonstrating the use of the State pattern.
/// </summary>
public class Program
{
    public static void Main()
    {
        // Create initial context with a specific state.
        Context context = new Context(new ConcreteStateA());

        // Request handling in the initial state.
        Console.WriteLine("Initial request handling:");
        context.Request();

        // Change state to a different behavior.
        context.SetState(new ConcreteStateB());

        // Request handling in the new state.
        Console.WriteLine("\nRequest handling after state change:");
        context.Request();
    }
}
