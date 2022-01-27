using System;
using System.Collections.Generic;
using System.Text;
using GeneratorScript;

namespace Generator.GeneratorScript
{
	public struct BaseStats
	{
		protected int _baseLife;
		protected int _basePower;
		protected int _baseDefense;

		public BaseStats(int newLife, int newPower, int newDefense)
		{
			throw new NotImplementedException();
		}
	}
}
