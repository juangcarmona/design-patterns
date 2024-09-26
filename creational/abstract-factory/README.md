
# Abstract Factory

The **Abstract Factory** pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes. This pattern is useful when you want to create related objects without coupling to their concrete implementations.

## Diagram

```mermaid
classDiagram
    class AbstractFactory {
        +createProductA()
        +createProductB()
    }

    class ConcreteFactory1 {
        +createProductA()
        +createProductB()
    }

    class ConcreteFactory2 {
        +createProductA()
        +createProductB()
    }

    class AbstractProductA {
        +useProductA()
    }

    class AbstractProductB {
        +useProductB()
    }

    class ConcreteProductA1 {
        +useProductA()
    }

    class ConcreteProductA2 {
        +useProductA()
    }

    class ConcreteProductB1 {
        +useProductB()
    }

    class ConcreteProductB2 {
        +useProductB()
    }

    AbstractFactory <|-- ConcreteFactory1
    AbstractFactory <|-- ConcreteFactory2
    AbstractProductA <|-- ConcreteProductA1
    AbstractProductA <|-- ConcreteProductA2
    AbstractProductB <|-- ConcreteProductB1
    AbstractProductB <|-- ConcreteProductB2
```

## Example

In this directory, you can find examples of how to implement the pattern in **C#** and **Python**, as well as a **Mermaid** diagram illustrating the basic structure of the pattern.

- **C#**: Example with classes implementing the Abstract Factory pattern to create related products without specifying their concrete implementations.
- **Python**: A similar example that shows how to create families of related objects without depending on concrete classes.

**SPANISH VERSION / VERSIÓN EN ESPAÑOL:** For the Spanish version of this file, **click [here](README_ES.md)**.
