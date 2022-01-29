using System;
using System.Collections.Generic;
using System.Text;

namespace Generator.GeneratorScript
{
	public class Dragon : Ennemy
	{
		public Dragon(string name) : base(name)
		{
			_baseStats = new BaseStats(1000, 80, 70);
		}
		public override void SpecialAttack()
		{
			throw new NotImplementedException();
		}
	}
}
