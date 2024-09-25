# Chain of Responsibility

El patrón **Chain of Responsibility** permite que varios objetos manejadores tengan la oportunidad de procesar una solicitud sin que el emisor sepa cuál de ellos la manejará finalmente. Cada manejador puede decidir si procesa la solicitud o la pasa al siguiente manejador de la cadena.


## Diagrama

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


## Ejemplo

En este directorio, puedes encontrar ejemplos de cómo implementar el patrón en **C#** y **Python**, así como un diagrama en **Mermaid** que ilustra la estructura básica del patrón.

- **C#**: Ejemplo con clases que implementan la cadena de responsabilidad para un sistema de aprobación de solicitudes.
- **Python**: Ejemplo similar que muestra cómo los objetos se encadenan para procesar solicitudes en un sistema de manejo de eventos.

Para la versión en inglés, haz clic [aquí](README.md).
