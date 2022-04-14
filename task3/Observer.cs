namespace task3;
public abstract class Observer{
    protected AbstractUser subscription_acc;
    protected string Name;
    public void follow(AbstractUser _subscription){
        this.subscription_acc = _subscription;
        this.subscription_acc.AttachSubscriber(this);
    }
    public Observer(string name){
        this.Name = name;
    }

    public string GetName(){
        return this.Name;
    }
    public abstract void Update(string status);
}


