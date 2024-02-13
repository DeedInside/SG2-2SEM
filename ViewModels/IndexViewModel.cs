using SG2.Models;

namespace SG2.ViewModels
{
    public class IndexViewModel
    {
        public User user;
        public Car car;

        public IndexViewModel(User user, Car car)
        {
            this.user = user;
            this.car = car;
        }
    }
}
