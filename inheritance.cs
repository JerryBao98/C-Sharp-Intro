//Inheritance can also implement polymorphic behaviour
//A class can only have one parent, use interfaces otherwise

//The super class
class presentationObject
{
    public int width { get; set; };
    public int height { get; set; };

    public void Copy(){
        System.Console.WriteLine("Object has been copied");
    }
}

//This is the child class
class Text:presentationObject
{
    
}