using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Generator.GeneratorScript
{
	public class Item
	{
		protected string _name;
		public string GetName
        {
			get { return _name; }
			private set { _name = value; }
        }

		protected int _level;
		public int GetLevel
		{
			get { return _level; }
			set { _level = value; }
		}

		protected BaseStats _itemBaseStats;
		public BaseStats GetBaseStats
		{
			get { return _itemBaseStats; }
			set { _itemBaseStats = value; }
		}

		protected Sprite _itemSprite;

		protected ItemType _itemType;
		public ItemType GetItemType
        {
			get { return _itemType; }
			private set { _itemType = value; }
        }

		protected DamageType _damageType;

		public void DisplayStats(Item _item)
		{
			throw new NotImplementedException();
		}

		public Item(string name, DamageType damageType)
		{
			_name = name;
			_level = UnityEngine.Random.Range(1, 100);
			_damageType = damageType;
		}

		public Item(string name, int level, DamageType damageType)
		{
			_name = name;
			_level = level;
			_damageType = damageType;
		}
	}
}
