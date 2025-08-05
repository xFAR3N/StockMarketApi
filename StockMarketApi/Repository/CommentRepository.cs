using Azure.Core;
using Microsoft.EntityFrameworkCore;
using StockMarketApi.Data;
using StockMarketApi.Interfaces;
using StockMarketApi.Models;

namespace StockMarketApi.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly AppDbContext _context;
        public CommentRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Comment>> GetAllAsync()
        {
            return await _context.Comments.ToListAsync();
        }
    }
}
