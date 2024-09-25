# Chain of Responsibility

The **Chain of Responsibility** pattern allows multiple handler objects to have the opportunity to process a request without the sender knowing which one will handle it. Each handler can decide to either process the request or pass it to the next handler in the chain.

**SPANISH VERSION / VERSIÓN EN ESPAÑOL:** For the Spanish version of this file, **click [here](README_ES.md)**.

## Diagram

```mermaid
classDiagram
    class Handler {
        +Handler nextHandler
        +handleRequest()
    }

    class ConcreteHandler1 {
        +handleRequest()
    }

    class ConcreteHandler2 {
        +handleRequest()
    }

    Handler <|-- ConcreteHandler1
    Handler <|-- ConcreteHandler2
    Handler --> Handler : nextHandler
