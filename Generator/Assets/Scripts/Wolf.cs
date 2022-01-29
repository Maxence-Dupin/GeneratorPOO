using System;
using System.Collections.Generic;
using System.Text;

namespace Generator.GeneratorScript
{
	public class Wolf : Ennemy
	{
		public Wolf(string name) : base(name)
		{
			_baseStats = new BaseStats(60, 30, 40);
		}
		public override void SpecialAttack()
		{
			throw new NotImplementedException();
		}
	}
}
