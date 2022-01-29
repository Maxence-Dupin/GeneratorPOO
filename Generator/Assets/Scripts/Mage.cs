using System;
using System.Collections.Generic;
using System.Text;

namespace Generator.GeneratorScript
{
	public class Mage : Hero
	{
		public Mage(string name) : base(name)
        {
			_baseStats = new BaseStats(70, 100, 10);
		}
		public override void SpecialAttack()
		{
			throw new NotImplementedException();
		}
	}
}
