using System;
using System.Collections.Generic;
using System.Text;

namespace Generator.GeneratorScript
{
	public class Orc : Ennemy
	{
		public Orc(string name, int level) : base(name, level)
        {
			_baseStats = new BaseStats(200 + _level * 50, 60 + _level * 20, 60 + _level * 10);
		}
		public override void SpecialAttack()
		{
			throw new NotImplementedException();
		}
	}
}
