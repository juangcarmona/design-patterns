
# Factory Method

The **Factory Method** pattern defines an interface for creating an object, but lets subclasses decide which class to instantiate. The Factory Method lets a class defer instantiation to subclasses.

## Diagram

```mermaid
classDiagram
    class Creator {
        +factoryMethod() Product
        +someOperation() void
    }

    class ConcreteCreatorA {
        +factoryMethod() ConcreteProductA
    }

    class ConcreteCreatorB {
        +factoryMethod() ConcreteProductB
    }

    class Product {
        <<Interface>>
        +use() void
    }

    class ConcreteProductA {
        +use() void
    }

    class ConcreteProductB {
        +use() void
    }

    Creator o--> Product : "Factory returns"
    Creator <|-- ConcreteCreatorA
    Creator <|-- ConcreteCreatorB
    Product <|-- ConcreteProductA
    Product <|-- ConcreteProductB

```

## Example

In this directory, you can find examples of how to implement the pattern in **C#** and **Python**, as well as a **Mermaid** diagram illustrating the basic structure of the pattern.

- **C#**: Example with classes implementing the Factory Method pattern to delegate the creation of objects to subclasses.
- **Python**: A similar example that shows how subclasses can decide which instances to create.

**SPANISH VERSION / VERSIÓN EN ESPAÑOL:** For the Spanish version of this file, **click [here](README_ES.md)**.
