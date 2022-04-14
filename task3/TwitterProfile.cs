namespace task3;

public class TwitterProfle{
    private string Name;

    private FollowManager followManager;
    
    public TwitterProfle(string name){
        this.Name = name;
        this.followManager = new FollowManager(name);
    }

    public string getName() {
        return this.Name;
    }

    public AbstractUser GetSubject(){
        return followManager.MyFollowers;
    }

    public void follow(TwitterProfle twitterProfle){
        followManager.subscribe(this.Name, twitterProfle);
    }

    public List<Observer> Followers(){
        return followManager.getFollowers(this.Name);
    }

    
     public List<Observer> Subscriptions(){
        return followManager.getSubscriptions(this.Name);
    }


}