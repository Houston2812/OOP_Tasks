namespace task3;

public abstract class AbstractUser{
    protected string current_status;
    protected  string Name;
    protected List<Observer> subscribers;
    public void Notify(string status){
        foreach(var subscriber in subscribers){
            subscriber.Update(status);
        }
    }

    public AbstractUser(string name){
        this.current_status = "";
        subscribers = new List<Observer>();
        this.Name = name;
    }

    public string GetName(){
        return this.Name;
    }

    public void SetStatus(string status){
            this.current_status = status;
            this.Notify(status);
    }

    public void AttachSubscriber(Observer subscriber){
        this.subscribers.Add(subscriber);
    }
    public void RemoveSubscriber(Observer subscriber){
        this.subscribers.Remove(subscriber);
    }
    
    public  List<Observer> GetFollowers(){
        return this.subscribers;
    }
}

