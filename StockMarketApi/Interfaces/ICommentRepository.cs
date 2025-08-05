using StockMarketApi.Models;

namespace StockMarketApi.Interfaces
{
    public interface ICommentRepository
    {
        Task<List<Comment>> GetAllAsync();

    }
}
