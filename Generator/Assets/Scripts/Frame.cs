using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Generator.GeneratorScript
{
    public class Frame : MonoBehaviour
    {
        private Character _frameCharacter;

        [SerializeField] private GameObject Prefab_ItemStats;
        [SerializeField] private GameObject Prefab_SpeAttack;
        [SerializeField] private Transform itemStatSpawnPoint;
        [SerializeField] private Canvas myCanvas;

        private GameObject _lastPrefabDisplayed = null;

        public void Start()
        {
            //this.transform.Find("OffensiveItemNameText").gameObject.PointerOverEvent.AddListener(DisplayItemStats);
            myCanvas = (Canvas)FindObjectOfType(typeof(Canvas));
        }

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
                this.transform.Find("OffensiveItemNameText").GetComponent<Text>().text = _frameCharacter.GetOffensiveItem.GetName;
            else
                this.transform.Find("OffensiveItemNameText").GetComponent<Text>().text = "NONE";

            //Defensive Item name if exists
            if (_frameCharacter.GetDefensiveItem != null)
                this.transform.Find("DefensiveItemNameText").GetComponent<Text>().text = _frameCharacter.GetDefensiveItem.GetName;
            else
                this.transform.Find("DefensiveItemNameText").GetComponent<Text>().text = "NONE";
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
            this.transform.Find("LifeValueText").GetComponent<Text>().text = _finalStats._baseLife.ToString();
            this.transform.Find("PowerValueText").GetComponent<Text>().text = _finalStats._basePower.ToString();
            this.transform.Find("DefenseValueText").GetComponent<Text>().text = _finalStats._baseDefense.ToString();
        }

        public void GenerateOffensiveItem()
        {
            Item newItem = ItemGeneratorController.GetInstance.GenerateItem(ItemType.OFFENSIVE);
            _frameCharacter.GetOffensiveItem = newItem;
            this.transform.Find("Colliders").Find("OffItemCollider").GetComponent<ShowItemStats>().SetItem = newItem;

            DisplayCharacterItems();
            DisplayCharacterStats();
        }

        public void DeleteOffensiveItem()
        {
            _frameCharacter.GetOffensiveItem = null;

            this.transform.Find("Colliders").Find("OffItemCollider").GetComponent<ShowItemStats>().SetItem = null;

            DisplayCharacterItems();
            DisplayCharacterStats();
        }
        
        public void DeleteDefensiveItem()
        {
            _frameCharacter.GetDefensiveItem = null;

            this.transform.Find("Colliders").Find("DefItemCollider").GetComponent<ShowItemStats>().SetItem = null;

            DisplayCharacterItems();
            DisplayCharacterStats();
        }

        public void GenerateDefensiveItem()
        {
            Item newItem = ItemGeneratorController.GetInstance.GenerateItem(ItemType.DEFENSIVE);
            _frameCharacter.GetDefensiveItem = newItem;
            this.transform.Find("Colliders").Find("DefItemCollider").GetComponent<ShowItemStats>().SetItem = newItem;

            DisplayCharacterItems();
            DisplayCharacterStats();
        }

        public void DisplayItemStats(Item item)
        {
                //frame prefab instantiation
                GameObject oneFrame = Instantiate(Prefab_ItemStats, itemStatSpawnPoint.position, itemStatSpawnPoint.rotation, myCanvas.transform);
                oneFrame.transform.localScale = new Vector3(1, 1, 1);

                switch (item.GetItemType)
                {
                    case ItemType.OFFENSIVE:
                        //Item name
                        oneFrame.transform.Find("ItemNameText").GetComponent<Text>().text = _frameCharacter.GetOffensiveItem.GetName;

                        //Item level
                        oneFrame.transform.Find("ItemLevelText").GetComponent<Text>().text = _frameCharacter.GetOffensiveItem.GetLevel.ToString();

                        //Item stats
                        oneFrame.transform.Find("LifeValueText").GetComponent<Text>().text = _frameCharacter.GetOffensiveItem.GetBaseStats._baseLife.ToString();
                        oneFrame.transform.Find("PowerValueText").GetComponent<Text>().text = _frameCharacter.GetOffensiveItem.GetBaseStats._basePower.ToString();
                        oneFrame.transform.Find("DefenseValueText").GetComponent<Text>().text = _frameCharacter.GetOffensiveItem.GetBaseStats._baseDefense.ToString();
                        break;
                    case ItemType.DEFENSIVE:
                        //Item name
                        oneFrame.transform.Find("ItemNameText").GetComponent<Text>().text = _frameCharacter.GetDefensiveItem.GetName;

                        //Item level
                        oneFrame.transform.Find("ItemLevelText").GetComponent<Text>().text = _frameCharacter.GetDefensiveItem.GetLevel.ToString();

                        //Item stats
                        oneFrame.transform.Find("LifeValueText").GetComponent<Text>().text = _frameCharacter.GetDefensiveItem.GetBaseStats._baseLife.ToString();
                        oneFrame.transform.Find("PowerValueText").GetComponent<Text>().text = _frameCharacter.GetDefensiveItem.GetBaseStats._basePower.ToString();
                        oneFrame.transform.Find("DefenseValueText").GetComponent<Text>().text = _frameCharacter.GetDefensiveItem.GetBaseStats._baseDefense.ToString();
                        break;
                    default:
                        break;
                }

                _lastPrefabDisplayed = oneFrame;
        }

        public void UnDisplayLastPrefab()
        {
            if(_lastPrefabDisplayed != null)
            {
                Destroy(_lastPrefabDisplayed);
            }
        }

        public void DisplaySpeAttack()
        {
            //frame prefab instantiation
            GameObject oneFrame = Instantiate(Prefab_SpeAttack, itemStatSpawnPoint.position, itemStatSpawnPoint.rotation, myCanvas.transform);
            oneFrame.transform.localScale = new Vector3(1, 1, 1);

            //change frame sprite
            if(_frameCharacter is Ennemy)
                oneFrame.GetComponent<Image>().sprite = Resources.Load<Sprite>("ennemyAttackSpe");
            else if(_frameCharacter is Hero)
                oneFrame.GetComponent<Image>().sprite = Resources.Load<Sprite>("heroAttackSpe");

            //attack name 
            oneFrame.transform.Find("AttackNameText").GetComponent<Text>().text = _frameCharacter.AttackName;

            //attack description
            oneFrame.transform.Find("AttackDescriptionText").GetComponent<Text>().text = _frameCharacter.AttackDescription;

            _lastPrefabDisplayed = oneFrame;
        }
    }
}
