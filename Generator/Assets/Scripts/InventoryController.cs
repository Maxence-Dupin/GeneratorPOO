using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Generator.GeneratorScript
{
    public class InventoryController : MonoBehaviour
    {

        public static InventoryController _instanceIC = null;

        private List<GameObject> _frames;
        private List<Character> _generatedCharacters;

        [SerializeField] private GameObject myPrefab;
        [SerializeField] private GameObject myCanvas;
        [SerializeField] private Transform spawnPoint;

        private void Awake()
        {
            _instanceIC = this;
        }

        // Start is called before the first frame update
        void Start()
        {
            _frames = new List<GameObject>();
        }

        public static InventoryController GetInstance
        {
            get => _instanceIC;
        }

        public void DisplayFrames()
        {
            //get generated characters from CharacterGeneratorController instance
            _generatedCharacters = CharacterGeneratorController.GetInstance.GeneratedCharacters;

            if( _frames.Count != 0)
            {
                DeleteCharacters();
            }

            int compteur = 0;
            foreach(Character character in _generatedCharacters)
            {
                Debug.Log("display one frame: " + character.GetName);
                spawnPoint.localPosition = new Vector3(spawnPoint.localPosition.x + 600, spawnPoint.localPosition.y, spawnPoint.localPosition.z);
                GameObject oneFrame = Instantiate(myPrefab, spawnPoint.position, spawnPoint.rotation, myCanvas.transform);
                oneFrame.transform.localScale = new Vector3(1, 1, 1);

                oneFrame.GetComponent<Frame>().FrameCharacter = character;

                _frames.Add(oneFrame);

                //display informations on Frames
                Frame oneFrameScript = oneFrame.GetComponent<Frame>();
                oneFrameScript.ApplyRightBackground();
                oneFrameScript.DisplayCharacterInfos();
                oneFrameScript.DisplayCharacterItems();
                oneFrameScript.DisplayCharacterStats();

                compteur++;
            }

            //replace spawnPoint at its begin position
            spawnPoint.localPosition = new Vector3(spawnPoint.localPosition.x - 600 * compteur, spawnPoint.localPosition.y, spawnPoint.localPosition.z);
        }

        public void DeleteCharacters()
        {
            //destroy prefabs frame
            foreach (GameObject frame in _frames)
            {
                Destroy(frame);
            }
            _frames.Clear();

            //reset Characters
            foreach (Character character in _generatedCharacters)
            {
                if (character.GetDefensiveItem != null)
                {
                    character.GetDefensiveItem = null;
                }
                if (character.GetOffensiveItem != null)
                {
                    character.GetOffensiveItem = null;
                }
            }

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

