
```mermaid
classDiagram
    class Prototype {
        +clone()
    }

    class ConcretePrototype1 {
        +clone()
    }

    class ConcretePrototype2 {
        +clone()
    }

    Prototype <|-- ConcretePrototype1
    Prototype <|-- ConcretePrototype2
```
