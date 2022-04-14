namespace task3;
public class Follower:Observer{

    public Follower(string name):base(name){}
    public override void Update(string status)
    {
        Console.WriteLine($"{this.Name} has updated the status to {status}");
        Console.WriteLine();
    }

}
