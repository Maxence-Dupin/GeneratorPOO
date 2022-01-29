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
			_availableCharacters.Add(new Paladin("Michelle"));
			_availableCharacters.Add(new Mage("Jacques"));
			_availableCharacters.Add(new Rogue("Douglas"));
			_availableCharacters.Add(new Orc("Ougahougah"));
			_availableCharacters.Add(new Wolf("Graou"));
			_availableCharacters.Add(new Dragon("Frrrrrrrrrrr"));
		}
		
        public static CharacterGeneratorController GetInstance
		{
			get => _instanceCGC;
		}

		public void GenerateCharacter()
		{
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

			DisplayCharacters();
			
			
			/*foreach (Character a in _generatedCharacters)
            {
				if(a is Ennemy)
                {
					Debug.Log("je suis un ennemi, je m'appelle " + a.GetName);
				}
				else
                {
					Debug.Log("je suis un héros, je m'appelle " + a.GetName);
				}
				Debug.Log("life : " + a.GetBaseStats._baseLife + " power : " + a.GetBaseStats._basePower + " defense : " + a.GetBaseStats._baseDefense);
			}*/
		}

		public void DisplayCharacters()
		{
			int compteur = 0;
			if(_displayedFrames.Count != 0)
            {
				DeleteCharacters();
            }

			foreach (Character charac in _generatedCharacters)
            {
				spawnPoint.localPosition = new Vector3(spawnPoint.localPosition.x + 600, spawnPoint.localPosition.y, spawnPoint.localPosition.z);
				GameObject oneFrame = Instantiate(myPrefab, spawnPoint.position, spawnPoint.rotation, myCanvas.transform);
				oneFrame.transform.localScale = new Vector3(1, 1, 1);

				//Display character's name on frame
				oneFrame.transform.Find("NameText").GetComponent<Text>().text = charac.GetName;

				//Display character's level on frame
				oneFrame.transform.Find("LevelText").GetComponent<Text>().text = charac.GetLevel.ToString();

				//Display character's stats on frame
				oneFrame.transform.Find("LifeText").GetComponent<Text>().text = charac.GetBaseStats._baseLife.ToString();
				oneFrame.transform.Find("PowerText").GetComponent<Text>().text = charac.GetBaseStats._basePower.ToString();
				oneFrame.transform.Find("DefenseText").GetComponent<Text>().text = charac.GetBaseStats._baseDefense.ToString();

				_displayedFrames.Add(oneFrame);
				
				compteur++;
			}
			spawnPoint.localPosition = new Vector3(spawnPoint.localPosition.x - 600*compteur, spawnPoint.localPosition.y, spawnPoint.localPosition.z);
		}

		public void DeleteCharacters()
        {
			foreach (GameObject frame in _displayedFrames)
            {
				Destroy(frame);
			}
			_displayedFrames.Clear();
        }
	}
}
