using System;
using System.Collections.Generic;
using System.Text;

namespace Generator.GeneratorScript
{
	public class Wolf : Ennemy
	{
		public Wolf(string name, int level) : base(name, level)
		{
			_baseStats = new BaseStats(60 + _level * 10, 30 + _level * 5, 40 + _level * 5);

			_attackName = "GRAOUHGRAOUH";
			_attackDescription = "Graouh Graouh Miaou Grrrraouh";
		}
		
		public Wolf(string name) : base(name)
		{
			_baseStats = new BaseStats(60 + _level * 10, 30 + _level * 5, 40 + _level * 5);

			_attackName = "GRAOUHGRAOUH";
			_attackDescription = "Graouh Graouh Miaou Grrrraouh";
		}

		public override void SpecialAttack()
		{
			throw new NotImplementedException();
		}
	}
}
