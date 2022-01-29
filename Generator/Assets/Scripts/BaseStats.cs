using System;
using System.Collections.Generic;
using System.Text;

namespace Generator.GeneratorScript
{
	public struct BaseStats
	{
		public int _baseLife;
		public int _basePower;
		public int _baseDefense;

		public BaseStats(int newLife, int newPower, int newDefense)
		{
			this._baseLife = newLife;
			this._basePower = newPower;
			this._baseDefense = newDefense;
		}
	}
}
