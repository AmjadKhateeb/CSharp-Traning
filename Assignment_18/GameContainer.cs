using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment_18
{
    public class GameContainer<T>
    {
        public T itm;

        public void SetItem(T item)
        {
            itm = item;
        }
        public T GetItem()
        {
            return itm;
        }
    }
}