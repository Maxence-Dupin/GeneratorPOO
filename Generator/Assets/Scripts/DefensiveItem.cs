using System;
using System.Collections.Generic;
using System.Text;

namespace Generator.GeneratorScript
{
	public class DefensiveItem : Item
	{
		public void ReduceDamage()
		{
			throw new NotImplementedException();
		}

		public DefensiveItem(string name, DamageType damageType) : base(name, damageType)
		{
			_itemType = ItemType.DEFENSIVE;
			GetBaseStats = new BaseStats(100 + _level * 50, 0, 10 + _level * 5);
		}

		public DefensiveItem(string name, int level, DamageType damageType) : base(name, level, damageType)
		{
			_itemType = ItemType.DEFENSIVE;
			GetBaseStats = new BaseStats(100 + _level * 50, 0, 10 + _level * 5);
		}
	}
}
