using Domain.Models;
using System.Collections.ObjectModel;

namespace CamotWPF.Stores
{
    public class ItemStore
    {
        private ObservableCollection<Item> _items;

        public ObservableCollection<Item> Items
        {
            get => _items;
            set
            {
                _items = value;
                ItemsChanged?.Invoke();
            }
        }

        public event Action ItemsChanged;

        public ItemStore()
        {
            _items = new ObservableCollection<Item>();
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
            ItemsChanged?.Invoke();
        }

        public void UpdateItem(Item item)
        {
            var existingItem = Items.FirstOrDefault(i => i.Id == item.Id);
            if (existingItem != null)
            {
                var index = Items.IndexOf(existingItem);
                Items[index] = item;
                ItemsChanged?.Invoke();
            }
        }

        public void RemoveItem(int id)
        {
            var item = Items.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                Items.Remove(item);
                ItemsChanged?.Invoke();
            }
        }
    }
}
