using Party.Model;
using System.Collections.ObjectModel;

namespace Party.ViewModels
{
    public class ProductViewModel
    {
        public ObservableCollection<ItemModel> PartyList { get; set; }

        public ProductViewModel()
        {
            PartyList = new ObservableCollection<ItemModel>()
            {
                new ItemModel { Date = "01 / 12", Name = "Festa da Gabi", Quantity = 15, Value = "R$280,00" },
                new ItemModel { Date = "01 / 12", Name = "Festa da Gabi", Quantity = 15, Value = "R$280,00" },
                new ItemModel { Date = "01 / 12", Name = "Festa da Gabi", Quantity = 15, Value = "R$280,00" },
                new ItemModel { Date = "01 / 12", Name = "Festa da Gabi", Quantity = 15, Value = "R$280,00" }
            };
        }
    }
}
