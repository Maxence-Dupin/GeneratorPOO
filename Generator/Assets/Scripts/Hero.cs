using System;
using System.Collections.Generic;
using System.Text;

namespace Generator.GeneratorScript
{
	public class Hero : Character
	{
		public Hero(string name) : base(name)
		{
			_characterType = CharacterType.HERO;
		}
	}
}
