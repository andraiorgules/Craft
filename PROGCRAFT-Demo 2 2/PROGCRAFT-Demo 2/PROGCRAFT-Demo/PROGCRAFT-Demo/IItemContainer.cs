using System;
namespace PROGCRAFT_Demo
{
    public interface IItemContainer
    {
        bool ContainsItem(Item item);
        bool RemoveItem(Item item);
        bool AddItem(Item item);
        int ItemCount(Item item);
    }
}
