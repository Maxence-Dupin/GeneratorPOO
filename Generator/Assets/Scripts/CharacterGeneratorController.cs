using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Generator.GeneratorScript
{
	[Serializable]
	public class CharacterGeneratorController : MonoBehaviour
	{
		public static CharacterGeneratorController _instanceCGC = null;
		protected List<Character> _generatedCharacters;

		public List<Character> GeneratedCharacters
		{
            get { return _generatedCharacters; }
			private set { _generatedCharacters = value; }
		}

		protected List<GameObject> _displayedFrames;
		[SerializeField] public List<Character> _availableCharacters;
		[SerializeField] private GameObject myPrefab;
		[SerializeField] private GameObject myCanvas;
		[SerializeField] private Transform spawnPoint;

		private void Awake()
        {
			_instanceCGC = this;
        }

        private void Start()
        {
			_generatedCharacters = new List<Character>();
			_displayedFrames = new List<GameObject>();
			_availableCharacters = new List<Character>();
		}
		
        public static CharacterGeneratorController GetInstance
		{
			get => _instanceCGC;
		}

		public void GenerateCharacter()
		{
			_generatedCharacters.Clear();
			_availableCharacters.Clear();
			InventoryController.GetInstance.DeleteFrames();

			_availableCharacters.Add(new Paladin("Michelle"));
			_availableCharacters.Add(new Mage("Jacques"));
			_availableCharacters.Add(new Rogue("Douglas", -10));
			_availableCharacters.Add(new Orc("Ougahougah", 47));
			_availableCharacters.Add(new Wolf("Graou", 12));
			_availableCharacters.Add(new Dragon("Frrrrrrrrrrr", 10000));

			List<int> indexTable = new List<int>();
			int indexToPick = UnityEngine.Random.Range(0, _availableCharacters.Count);
			
			_generatedCharacters.Clear();

			for (int i = 0 ; i < 3; i++)
            {
				while (indexTable.Contains(indexToPick))
                {
					indexToPick = UnityEngine.Random.Range(0, _availableCharacters.Count);
				}
				_generatedCharacters.Add(_availableCharacters[indexToPick]);
				indexTable.Add(indexToPick);
			}

			//display characters in inventory;
			InventoryController.GetInstance.DisplayFrames();
		}

	}
}
