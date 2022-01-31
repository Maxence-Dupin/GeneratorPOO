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

			_attackName = "INFERNAL FIRE BREATH";
			_attackDescription = "Prend son envol et brûle ses ennemis par un souffle d'une chaleur dévastatrice";
		}
		
		public Dragon(string name) : base(name)
		{
			_baseStats = new BaseStats(1000 + _level * 100, 80 + _level * 110, 70 + _level * 110);

			_attackName = "INFERNAL FIRE BREATH";
			_attackDescription = "Prend son envol et brûle ses ennemis par un souffle d'une chaleur dévastatrice";
		}

		public override void SpecialAttack()
		{
			throw new NotImplementedException();
		}
	}
}
