using System;
using System.Collections.Generic;
using System.Text;

namespace Generator.GeneratorScript
{
	public class Paladin : Hero
	{
		public Paladin(string name, int level) : base(name, level)
        {
			_baseStats = new BaseStats(150 + _level * 75, 20 + _level * 10, 80 + _level * 10);
		}
		public override void SpecialAttack()
		{
			throw new NotImplementedException();
		}
	}
}
