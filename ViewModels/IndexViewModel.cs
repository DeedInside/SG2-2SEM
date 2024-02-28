using SG2.Models;

namespace SG2.ViewModels
{
    public class IndexViewModel
    {
        public User user;
        public Car car;
        public string? value;

        public IndexViewModel(User user, Car car, string? value)
        {
            this.user = user;
            this.car = car;
            this.value = value??"not";
        }
    }
}
