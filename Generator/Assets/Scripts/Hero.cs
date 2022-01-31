using System;
using System.Collections.Generic;
using System.Text;

namespace Generator.GeneratorScript
{
	public class Hero : Character
	{
		public Hero(string name, int level) : base(name, level)
		{
			_characterType = CharacterType.HERO;
		}
	}
}
