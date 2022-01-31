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

		public GameObject _frame;
		public GameObject GetFrame
        {
			get { return _frame; }
			set { _frame = value; }
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

		private void Start()
        {
			
		}

		public void DisplayFrame()
        {
			//Change frame's sprite
			if (this is Ennemy)
			{
				_frame.GetComponent<Image>().sprite = Resources.Load<Sprite>("ennemyFrame");
			}

			//Display character's stats on frame
			DisplayStats();
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
			BaseStats _finalStats = new BaseStats(0, 0, 0);
			_finalStats = GetBaseStats;

			//Display character's name on frame
			_frame.transform.Find("NameText").GetComponent<Text>().text = this.GetName;

			//Display character's level on frame
			_frame.transform.Find("LevelText").GetComponent<Text>().text = this.GetLevel.ToString();

			if (_offensiveItem != null)
            {
				_finalStats._baseLife += _offensiveItem.GetBaseStats._baseLife;
				_finalStats._basePower += _offensiveItem.GetBaseStats._basePower;
				_finalStats._baseDefense += _offensiveItem.GetBaseStats._baseDefense;
				Debug.Log(_offensiveItem.GetName);
			}
			else
			{
				Debug.Log("no off item");
			}

			if (_defensiveItem != null)
			{
				_finalStats._baseLife += _defensiveItem.GetBaseStats._baseLife;
				_finalStats._basePower += _defensiveItem.GetBaseStats._basePower;
				_finalStats._baseDefense += _defensiveItem.GetBaseStats._baseDefense;
				Debug.Log(_defensiveItem.GetName);
			}
			else
            {
				Debug.Log("no def item");
            }

			if(_frame != null)
            {
				Debug.Log("frame");
            }
            else { Debug.Log("no frame"); }

			_frame.transform.Find("LifeText").GetComponent<Text>().text = _finalStats._baseLife.ToString();
			_frame.transform.Find("PowerText").GetComponent<Text>().text = _finalStats._basePower.ToString();
			_frame.transform.Find("DefenseText").GetComponent<Text>().text = _finalStats._baseDefense.ToString();
		}
	}
}
