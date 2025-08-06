using StockMarketApi.Dtos.Stock;
using StockMarketApi.Models;

namespace StockMarketApi.Mappers
{
    public static class StockMappers
    {
        public static StockDto ToStockDto(this Stock stockModel)
        {
            return new StockDto
            {
                Id = stockModel.Id,
                Symbol = stockModel.Symbol,
                CompanyName = stockModel.CompanyName,
                Industry = stockModel.Industry,
                MarketCap = stockModel.MarketCap,
                PurchasePrice = stockModel.PurchasePrice,
                LastDiv = stockModel.LastDiv,
                Comments = stockModel.Comments.Select(c => c.ToCommentDto()).ToList()
            };
        }

        public static Stock ToStockFromCreateDto(this CreatStockRequestDto stockDto)
        {
            return new Stock
            {
                Symbol = stockDto.Symbol,
                CompanyName = stockDto.CompanyName,
                PurchasePrice = stockDto.PurchasePrice,
                LastDiv = stockDto.LastDiv,
                Industry = stockDto.Industry,
                MarketCap = stockDto.MarketCap,
            };
        }
    }
}
