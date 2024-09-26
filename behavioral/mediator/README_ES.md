
# Mediator

El patrón **Mediator** define un objeto que encapsula cómo interactúan un conjunto de objetos. Este patrón promueve el acoplamiento débil al evitar que los objetos se refieran directamente entre sí, lo que permite variar sus interacciones independientemente.

## Diagrama

```mermaid
classDiagram
    class Mediator {
        +notify(sender, event)
    }

    class ConcreteMediator {
        +notify(sender, event)
    }

    class Component {
        +mediator: Mediator
        +doAction()
    }

    class Component1 {
        +doAction1()
    }

    class Component2 {
        +doAction2()
    }

    Mediator <|-- ConcreteMediator
    ConcreteMediator o--> Component : components
    Component <|-- Component1
    Component <|-- Component2
```

## Ejemplo

En este directorio, puedes encontrar ejemplos de cómo implementar el patrón en **C#** y **Python**, así como un diagrama en **Mermaid** que ilustra la estructura básica del patrón.

- **C#**: Ejemplo con clases que implementan un mediador para coordinar la interacción entre varios componentes.
- **Python**: Ejemplo similar que muestra cómo los componentes interactúan a través de un mediador.

**SPANISH VERSION / VERSIÓN EN ESPAÑOL:** Para la versión en inglés de este archivo, haz clic [aquí](README.md).
