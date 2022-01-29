using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Generator.GeneratorScript
{
	public class Character
	{
		protected string _name;
		public string GetName 
		{ 
			get { return _name; } 
			private set { _name = value; } 
		}

		protected int _level;
		public int GetLevel
		{
			get { return _level; }
			private set { _level = value; }
		}

		protected int _XP;
		public int GetXP
		{
			get { return _XP; }
			private set { _XP = value; }
		}

		protected BaseStats _baseStats;
		public BaseStats GetBaseStats
		{
			get { return _baseStats; }
			private set { _baseStats = value; }
		}

		protected CharacterType _characterType;
		protected Sprite _characterSprite;
		protected Item _defensiveItem;
		protected Item _offensiveItem;
		protected State _characterState;

		public Character(string name) 
		{
			_name = name;
			_characterState = State.ALIVE;
			_level = 1;
			_XP = 1;
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
