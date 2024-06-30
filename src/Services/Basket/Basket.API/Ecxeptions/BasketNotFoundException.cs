
namespace Basket.API.Ecxeptions
{
    public class BasketNotFoundException:NotFoundException
    {
        public BasketNotFoundException(string userName) : base("Basket", userName)
        {

        }
    }
}
