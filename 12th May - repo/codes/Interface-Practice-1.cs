interface IShape{
    void Draw();
}

class Circle: IShape{
    public void Draw("Drawing a circle");
}
class Program{
    static void Main(){
        Circle circle = new Circle();
        circle.Draw();
    }
}