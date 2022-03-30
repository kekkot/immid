namespace immid.Models
{
    public class HomeModel
    {
        public IEnumerable<ProjectModel> Projects { get; set; } = null!;
        public IEnumerable<NewsModel> News { get; set; } =null!;
    }
}
