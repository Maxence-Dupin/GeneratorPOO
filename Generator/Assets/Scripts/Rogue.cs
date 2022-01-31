using System;
using System.Collections.Generic;
using System.Text;

namespace Generator.GeneratorScript
{
	public class Rogue : Hero
	{
		public Rogue(string name, int level) : base(name, level)
		{
			_baseStats = new BaseStats(50 + _level * 10, 70 + _level * 20, 20 + _level * 2);

			_attackName = "PERLINPINPIN POWDER";
			_attackDescription = "Jette un petit sachet de poudre de perlinpinpin dans les yeux de son ennemis, réduisant ainsi sa vision";
		}
		
		public Rogue(string name) : base(name)
		{
			_baseStats = new BaseStats(50 + _level * 10, 70 + _level * 20, 20 + _level * 2);

			_attackName = "PERLINPINPIN POWDER";
			_attackDescription = "Jette un petit sachet de poudre de perlinpinpin dans les yeux de son ennemis, réduisant ainsi sa vision";
		}

		public override void SpecialAttack()
		{
			throw new NotImplementedException();
		}
	}
}
