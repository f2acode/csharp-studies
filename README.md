# Visual Studio + C# + .NET studies

## [1: The famous HelloWorld]()

### Simple code:
```csharp
using System;

class HelloWorld
{
  public static void Main()
  {
    Console.WriteLine("Hello World!");
  }
}
```
### Compile with:
```csc HelloWorld.cs```
### Run with: 
```HelloWorld.exe```

## [2: Concepts]()

### Entity framework:
A framework to work easily with database inside the code. It auto creates connections, and we don't need to take care about many things.

### Scaffolding:
Framework that creates methods and views of CRUD.

## [3: Events and Delegate](https://github.com/felipeaugustox/csharp-studies/tree/master/EventsAndDelegate)

### Event
> A mechanism for communication between objects

> This is a way to use some methods without the needy of the entire class.

### Delegate
> A agreement/contract between publisher and subscriber

> Determines the signature of the event handler method in subscriber

### Way to use them:

- [x] **Define a delegate and define an event based on that delegate**

**First way:**

```csharp
Public delegate void MethodNameEventHandler(object source, EventArgs args)
```
* Source: the class that is pusblishing/sending the event
* Args: any arguments we could pass
* In .NET there is a convention to name the delegate method as Name + EventHandler ( ```MethodNameEventHandler``` )
	
```csharp
Public event MethodNameEventHandler VideoEncoded;
```

**Other (best) way:**

Define a without args as parameters

```csharp
public event EventHandler VideoEncoded;
```

Define a with args as parameters

```csharp
public event EventHandler<EventArgs> VideoEncoded;
```

* The event. It's just a pointer to the events that we can define after.
* ○ The event has the same name of the eventHandler

- [x] **Raise the event**

```csharp
Protected virtual void OnEventName(){}
```
* The method that calls the event
* .NET suggestions that the event publisher methods should be protected, virtual and void, start with the word On and the name of the event (VideoEncoded)

### The benefits

We can see that it's not necessary to change the class that have the delegates, we can just put more and more events.