using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Generator.GeneratorScript
{
    public class ShowItemStats : MonoBehaviour
    {
        private Item _item;

        public Item SetItem
        {
            get { return _item; }
            set { _item = value; }
        }

        private void OnMouseEnter()
        {
            if (_item != null)
            {
                this.transform.parent.parent.GetComponent<Frame>().DisplayItemStats(_item);
            } 
        }

        private void OnMouseExit()
        {
            this.transform.parent.parent.GetComponent<Frame>().UnDisplayLastPrefab();
        }
    }
}

