using System;
using System.Collections.Generic;
using System.Text;

namespace Generator.GeneratorScript
{
	public class OffensiveItem : Item
	{
		public void IncreaseDamage()
		{
			throw new NotImplementedException();
		}

		public OffensiveItem(string name, DamageType damageType) : base(name, damageType)
        {
			_itemType = ItemType.OFFENSIVE;
			GetBaseStats = new BaseStats(0, 10 + _level * 5, 0);
		}
		
		public OffensiveItem(string name, int level, DamageType damageType) : base(name, level, damageType)
        {
			_itemType = ItemType.OFFENSIVE;
			GetBaseStats = new BaseStats(0, 10 + _level * 5, 0);
		}
	}
}
