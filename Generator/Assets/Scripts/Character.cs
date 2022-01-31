using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Generator.GeneratorScript
{
	[Serializable]
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
			private set 
			{ 
				_level = Mathf.Clamp(value, 1, 99); ;
			}
		}

		protected int _XP;
		public int GetXP
		{
			get { return _XP; }
			private set { _XP = value; }
		}

		[SerializeField] protected BaseStats _baseStats;
		public BaseStats GetBaseStats
		{
			get { return _baseStats; }
			private set { _baseStats = value; }
		}

		protected CharacterType _characterType;
		protected Sprite _characterSprite;

		protected Item _defensiveItem = null;
		public Item GetDefensiveItem
        {
			get { return _defensiveItem; }
			set { _defensiveItem = value; }
        }

		protected Item _offensiveItem = null;
		public Item GetOffensiveItem
		{
			get { return _offensiveItem; }
			set { _offensiveItem = value; }
		}

		protected State _characterState;

		public Character(string name, int level) 
		{
			_name = name;
			GetLevel = level;
			_characterState = State.ALIVE;
			_XP = 1;
		}
		
		public Character(string name) 
		{
			_name = name;
			GetLevel = UnityEngine.Random.Range(1, 100);
			_characterState = State.ALIVE;
			_XP = 1;
		}

		protected string _attackName;
		public string AttackName
        {
			get { return _attackName; }
			private set { _attackName = value; }
        }

		protected string _attackDescription;
		public string AttackDescription
        {
			get { return _attackDescription; }
			private set { _attackDescription = value; }
        }

		private void Start()
        {
			
		}

		public void Attack()
		{
			throw new NotImplementedException();
		}

		public virtual void SpecialAttack()
		{
			throw new NotImplementedException();
		}

		
	}
}
