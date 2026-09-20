using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryMaintenance
{
    public class InvItemList
    {
        private List<InvItem> invItems;

        public delegate void ChangeHandler(InvItemList invItems);
        public event ChangeHandler Changed;

        // GEORGE FELDMANN
        public InvItemList()
        {
            invItems = new List<InvItem>();
        }

        public int Count => invItems.Count;

        public InvItem this[int i]
        {
            get
            {
                if (i < 0)
                {
                    throw new ArgumentOutOfRangeException(i.ToString());
                }
                else if (i > invItems.Count)
                {
                    throw new ArgumentOutOfRangeException(i.ToString());
                }
                return invItems[i];
            }
            set
            {
                invItems[i] = value;
                Changed(this);
            }
        }

        //public InvItem GetItemByIndex(int i) => invItems[i];

        // GEORGE FELDMANN
        public void Add(InvItem invItem)
        {
            invItems.Add(invItem);
            Changed(this);
        }

        // GEORGE FELDMANN
        public void Add(int itemNo, string description, decimal price)
        {
            InvItem i = new InvItem(itemNo, description, price);
            invItems.Add(i);
            Changed(this);
        }

        // GEORGE FELDMANN
        public void Remove(InvItem invItem)
        {
            invItems.Remove(invItem);
            Changed(this);
        }

        // GEORGE FELDMANN
        public static InvItemList operator +(InvItemList il, InvItem i)
        {
            il.Add(i);
            return il;
        }

        // GEORGE FELDMANN
        public static InvItemList operator -(InvItemList il, InvItem i)
        {
            il.Remove(i);
            return il;
        }

        // GEORGE FELDMANN
        public void Fill() => invItems = InvItemDB.GetItems();

        // GEORGE FELDMANN
        public void Save() => InvItemDB.SaveItems(invItems);
    }
}
