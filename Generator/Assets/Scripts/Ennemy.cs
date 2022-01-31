using System;
using System.Collections.Generic;
using System.Text;

namespace Generator.GeneratorScript
{
	public class Ennemy : Character
	{
		public Ennemy(string name, int level) : base(name, level)
		{
			_characterType = CharacterType.ENNEMY;
		}
	}
}
