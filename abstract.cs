class shape{
    public int size { get; set; }   
    //Doesnt make sense for a shape to be drawn, use abstraction to clarify it must be implemented later
    public virtual void Draw{

    }
}

class circle:shape{
    public override void Draw{
        System.Console.WriteLine("I am drawing a circle");
    }

}


//Here is an abstract implementation of the same agorithm
public abstract class shape{
    public int size { get; set; }   
    //Doesnt make sense for a shape to be drawn, use abstraction to clarify it must be implemented later
    //Cannot include implementation, but only a declaration, if a method is abstract, so is the class
    //The derived class must override all the abstractions
    //Abstract classes cannot be initialized
    public abstract void Draw{

    }
}

class circle:shape{
    // Note the override
    public override void Draw{
        System.Console.WriteLine("I am drawing a circle");
    }

}