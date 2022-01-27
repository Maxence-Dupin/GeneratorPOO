using System;
using System.Collections.Generic;
using System.Text;

namespace Generator.GeneratorScript
{
	public class Character
	{
		protected string _name;
		protected int level;
		protected int XP;
		protected BaseStats _baseStats;
		protected CharacterType _characterType;
		protected Item _defensiveItem;
		protected Item _offensiveItem;
		protected State _characterState;

		public Character() 
		{
			throw new NotImplementedException();
		}

		public void Attack()
		{
			throw new NotImplementedException();
		}

		public virtual void SpecialAttack()
		{
			throw new NotImplementedException();
		}

		public void DisplayStats()
		{
			throw new NotImplementedException();
		}
	}
}
