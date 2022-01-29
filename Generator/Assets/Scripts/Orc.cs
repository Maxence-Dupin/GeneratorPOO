using System;
using System.Collections.Generic;
using System.Text;

namespace Generator.GeneratorScript
{
	public class Orc : Ennemy
	{
		public Orc(string name) : base(name)
        {
			_baseStats = new BaseStats(200, 60, 60);
		}
		public override void SpecialAttack()
		{
			throw new NotImplementedException();
		}
	}
}
