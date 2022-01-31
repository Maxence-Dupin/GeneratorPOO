using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Generator.GeneratorScript
{
    public class Frame : MonoBehaviour
    {

        public Character frameCharac;

        public void DisplayStats()
        {
            frameCharac.DisplayStats();
        }

        public void GenerateOffensiveItem()
        {
            Debug.Log("generate off");
            frameCharac.GetOffensiveItem = ItemGeneratorController.GetInstance.GenerateItem(ItemType.OFFENSIVE);
            DisplayStats();
        }

        public void GenerateDefensiveItem()
        {
            Debug.Log("generate def");
            frameCharac.GetDefensiveItem = ItemGeneratorController.GetInstance.GenerateItem(ItemType.DEFENSIVE);
            DisplayStats();
        }
    }
}
