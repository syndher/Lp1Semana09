# UML Animal Kingdom
``` mermaid

classDiagram
    class Program{
    }

    class Bat{
        +NumberOfNipples(4)
        +NumberOfWings(2)
    }
    class Bee{
        +NumberOfWings(4)
    }
    class Cat{
        +NumberOfNipples(8)
    }
    class Dog{
        +NumberOfNipples(10)
    }
    class IMammal{
        +NumberOfNipples(amount)
    }
    class ICanFly{
        +NumberOfWings(amount)
    }


Program <.. ICanFly
Program <.. IMammal

ICanFly <|.. Bat
ICanFly <|.. Bee

IMammal <|.. Cat
IMammal <|.. Dog
IMammal <|.. Bat

```
