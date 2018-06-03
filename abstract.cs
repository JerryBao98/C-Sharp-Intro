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
    public abstract void Draw{

    }
}

class circle:shape{
    public override void Draw{
        System.Console.WriteLine("I am drawing a circle");
    }

}