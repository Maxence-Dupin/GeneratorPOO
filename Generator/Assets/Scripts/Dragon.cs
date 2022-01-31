using System;
using System.Collections.Generic;
using System.Text;

namespace Generator.GeneratorScript
{
	public class Dragon : Ennemy
	{
		public Dragon(string name, int level) : base(name, level)
		{
			_baseStats = new BaseStats(1000 + _level * 100, 80 + _level * 110, 70 + _level * 110);
		}
		public override void SpecialAttack()
		{
			throw new NotImplementedException();
		}
	}
}
