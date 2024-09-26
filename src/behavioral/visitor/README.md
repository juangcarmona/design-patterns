
# Visitor

The **Visitor** pattern allows you to define new operations on a structure of objects without changing the classes of the objects on which it operates. This pattern is useful when you need to perform operations on a structure of objects and want to keep the behavior separate from the structure.

## Diagram

```mermaid
classDiagram
    class Visitor {
        +visitConcreteElementA(ConcreteElementA element)
        +visitConcreteElementB(ConcreteElementB element)
    }

    class ConcreteVisitor {
        +visitConcreteElementA(ConcreteElementA element)
        +visitConcreteElementB(ConcreteElementB element)
    }

    class Element {
        +accept(Visitor visitor)
    }

    class ConcreteElementA {
        +accept(Visitor visitor)
    }

    class ConcreteElementB {
        +accept(Visitor visitor)
    }

    Visitor <|-- ConcreteVisitor
    Element <|-- ConcreteElementA
    Element <|-- ConcreteElementB
    ConcreteElementA o--> Visitor : visitor
    ConcreteElementB o--> Visitor : visitor
```

## Example

In this directory, you can find examples of how to implement the pattern in **C#** and **Python**, as well as a **Mermaid** diagram illustrating the basic structure of the pattern.

- **C#**: Example with classes implementing the Visitor pattern to perform operations on a structure of objects.
- **Python**: A similar example that shows how to separate behavior from the structure using the Visitor pattern.

**SPANISH VERSION / VERSIÓN EN ESPAÑOL:** For the Spanish version of this file, **click [here](README_ES.md)**.
