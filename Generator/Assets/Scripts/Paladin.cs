using System;
using System.Collections.Generic;
using System.Text;

namespace Generator.GeneratorScript
{
	public class Paladin : Hero
	{
		public Paladin(string name) : base(name)
        {
			_baseStats = new BaseStats(150, 20, 80);
		}
		public override void SpecialAttack()
		{
			throw new NotImplementedException();
		}
	}
}
