namespace Article.Api.Repository
{
    public interface IArticleRepository
    {
        int Delete(int id);
        Models.Article? Get(int id);
        List<Models.Article> GetAll();
    }
}