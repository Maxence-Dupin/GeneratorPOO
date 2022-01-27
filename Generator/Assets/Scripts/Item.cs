using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Generator.GeneratorScript
{
	public class Item
	{
		protected string _name;
		protected int level;
		protected Sprite _itemSprite;
		protected BaseStats _itemBaseStats;
		protected ItemType _itemType;
		protected int _damageAmount;

		public void DisplayStats(Item _item)
		{
			throw new NotImplementedException();
		}

		public Item()
		{
			throw new NotImplementedException();
		}
	}
}
