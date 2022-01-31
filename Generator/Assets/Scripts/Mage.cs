using System;
using System.Collections.Generic;
using System.Text;

namespace Generator.GeneratorScript
{
	public class Mage : Hero
	{
		public Mage(string name, int level) : base(name, level)
        {
			_baseStats = new BaseStats(70 + _level * 25, 100 + _level * 50, 10 + _level * 1);

			_attackName = "THUUUUUUUNDER";
			_attackDescription = "Canalise son énergie arcanique pour générer un éclair foudroyant blessant et paralysant sa cible et les ennemis aux alentours";
		}
		
		public Mage(string name) : base(name)
        {
			_baseStats = new BaseStats(70 + _level * 25, 100 + _level * 50, 10 + _level * 1);

			_attackName = "THUUUUUUUNDER";
			_attackDescription = "Canalise son énergie arcanique pour générer un éclair foudroyant blessant et paralysant sa cible et les ennemis aux alentours";
		}

		public override void SpecialAttack()
		{
			throw new NotImplementedException();
		}
	}
}
