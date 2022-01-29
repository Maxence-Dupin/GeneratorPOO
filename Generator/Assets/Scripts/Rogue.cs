using System;
using System.Collections.Generic;
using System.Text;

namespace Generator.GeneratorScript
{
	public class Rogue : Hero
	{
		public Rogue(string name) : base(name)
		{
			_baseStats = new BaseStats(50, 70, 20);
		}
		public override void SpecialAttack()
		{
			throw new NotImplementedException();
		}
	}
}
