public class Post
{
    public string Title;
    public string Description;
    public int LikeCount;
    public List<string> Coments = [];
    public bool IsPublisher;
    public bool Publish()
    {
        System.Console.WriteLine("The post is published.");
        return true;
    }
    public int Like()
    {
        LikeCount++;
        return LikeCount;
    }
    public void Comments(string massage)
    {
        Coments.Add(massage);
    }
    
}