using System;
using System.Collections.Generic;
using System.Text;

namespace Generator.GeneratorScript
{
	public class Mage : Hero
	{
		public Mage(string name, int level) : base(name, level)
        {
			_baseStats = new BaseStats(70 + _level * 25, 100 + _level * 50, 10 + _level * 1);
		}
		public override void SpecialAttack()
		{
			throw new NotImplementedException();
		}
	}
}
