# UML Animal Kingdom

```mermaid

classDiagram
    class Animal {
        + virtual string Sound ()
    }

    class Cat {
        + override string Sound ()
        + NumberOfNipples : int
    }

    class Dog {
        + override string Sound ()
        + NumberOfNipples : int
    }

    class Bat {
        + override string Sound ()
        + NumberOfWings : int
        + NumberOfNipples : int
    }

    class Bee {
        + override string Sound ()
        + NumberOfWings : int
    }

    class IMammal {
        <<interface>>
        + NumberOfNipples : int
    }

    class ICanFly {
        <<interface>>
        + NumberOfWings : int
    }

    class Program {
        - void main$ 
    }

Program <|.. Animal
Animal <|-- Cat
Animal <|-- Dog
Animal <|-- Bat
Animal <|-- Bee
Cat ..|> IMammal
Dog ..|> IMammal
Bat ..|> IMammal
Bat ..|> ICanFly
Bee ..|> ICanFly
