using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Generator.GeneratorScript
{
    public class Frame : MonoBehaviour
    {
        private Character _frameCharacter;

        public Character FrameCharacter
        {
            get { return _frameCharacter; }
            set { _frameCharacter = value; }
        }

        public void ApplyRightBackground()
        {
            if(_frameCharacter is Ennemy)
                this.GetComponent<Image>().sprite = Resources.Load<Sprite>("ennemyFrame");
            else if(_frameCharacter is Hero)
                this.GetComponent<Image>().sprite = Resources.Load<Sprite>("heroFrame");
        }

        public void DisplayCharacterInfos()
        {
            //Display character's name on frame
            this.transform.Find("NameText").GetComponent<Text>().text = _frameCharacter.GetName;

            //Display character's level on frame
            this.transform.Find("LevelText").GetComponent<Text>().text = _frameCharacter.GetLevel.ToString();
        }

        public void DisplayCharacterItems()
        {
            //Offensive Item name if exists
            if (_frameCharacter.GetOffensiveItem != null)
            {
                this.transform.Find("OffensiveItemNameText").GetComponent<Text>().text = _frameCharacter.GetOffensiveItem.GetName;
            }

            //Defensive Item name if exists
            if (_frameCharacter.GetDefensiveItem != null)
            {
                this.transform.Find("DefensiveItemNameText").GetComponent<Text>().text = _frameCharacter.GetDefensiveItem.GetName;
            }
        }

        public void DisplayCharacterStats()
        {
            BaseStats _finalStats = new BaseStats(0, 0, 0);
            _finalStats = _frameCharacter.GetBaseStats;

            //add Offensive Item stats if exists
            if (_frameCharacter.GetOffensiveItem != null)
            {
                _finalStats._baseLife += _frameCharacter.GetOffensiveItem.GetBaseStats._baseLife;
                _finalStats._basePower += _frameCharacter.GetOffensiveItem.GetBaseStats._basePower;
                _finalStats._baseDefense += _frameCharacter.GetOffensiveItem.GetBaseStats._baseDefense;
            }

            //add Defensive Item stats if exists
            if (_frameCharacter.GetDefensiveItem != null)
            {
                _finalStats._baseLife += _frameCharacter.GetDefensiveItem.GetBaseStats._baseLife;
                _finalStats._basePower += _frameCharacter.GetDefensiveItem.GetBaseStats._basePower;
                _finalStats._baseDefense += _frameCharacter.GetDefensiveItem.GetBaseStats._baseDefense;
            }

            //Display Final Stats on the frame
            this.transform.Find("LifeText").GetComponent<Text>().text = _finalStats._baseLife.ToString();
            this.transform.Find("PowerText").GetComponent<Text>().text = _finalStats._basePower.ToString();
            this.transform.Find("DefenseText").GetComponent<Text>().text = _finalStats._baseDefense.ToString();
        }

        public void GenerateOffensiveItem()
        {
            _frameCharacter.GetOffensiveItem = ItemGeneratorController.GetInstance.GenerateItem(ItemType.OFFENSIVE);
            DisplayCharacterItems();
            DisplayCharacterStats();
        }

        public void GenerateDefensiveItem()
        {
            _frameCharacter.GetDefensiveItem = ItemGeneratorController.GetInstance.GenerateItem(ItemType.DEFENSIVE);
            DisplayCharacterItems();
            DisplayCharacterStats();
        }
    }
}
