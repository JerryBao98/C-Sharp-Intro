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