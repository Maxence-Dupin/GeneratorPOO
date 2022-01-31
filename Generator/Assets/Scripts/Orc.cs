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

			_attackName = "BIM HEADBUTT";
			_attackDescription = "Gneuh Boum tu prends ton coup de boule";
		}
		
		public Orc(string name) : base(name)
        {
			_baseStats = new BaseStats(200 + _level * 50, 60 + _level * 20, 60 + _level * 10);

			_attackName = "BIM HEADBUTT";
			_attackDescription = "Gneuh Boum tu prends ton coup de boule";
		}

		public override void SpecialAttack()
		{
			throw new NotImplementedException();
		}
	}
}
