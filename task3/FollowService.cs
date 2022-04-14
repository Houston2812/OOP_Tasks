namespace task3;

public class FollowManager{

    private List<Observer> MySubscriptions;
    public AbstractUser MyFollowers;
    public FollowManager(string name){
        this.MySubscriptions = new List<Observer>();
        this.MyFollowers = new User(name);
    }

    public void subscribe(string name, TwitterProfle twitterProfle) {
        Console.WriteLine("[+] " + name + " started following " + twitterProfle.getName()); 
        var follower_ = new Follower(name);
        follower_.follow(twitterProfle.GetSubject());
        this.MySubscriptions.Add(new Follower(twitterProfle.getName()));
    }

    public List<Observer> getFollowers(string name){
        return MyFollowers.GetFollowers();
    }

    public List<Observer> getSubscriptions(string name){
        return this.MySubscriptions;
    }
}