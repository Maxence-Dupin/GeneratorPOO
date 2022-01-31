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

        [SerializeField] private GameObject Prefab_CharacterFrame
            ;
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

            int compteur = 0;
            foreach(Character character in _generatedCharacters)
            {
                //frame prefab instantiation
                spawnPoint.localPosition = new Vector3(spawnPoint.localPosition.x + 600, spawnPoint.localPosition.y, spawnPoint.localPosition.z);
                GameObject oneFrame = Instantiate(Prefab_CharacterFrame, spawnPoint.position, spawnPoint.rotation, myCanvas.transform);
                oneFrame.transform.localScale = new Vector3(1, 1, 1);

                //assign character to the Frame 
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

        public void DeleteFrames()
        {
            //destroy prefabs frame
            foreach (GameObject frame in _frames)
            {
                Destroy(frame);
            }
            _frames.Clear();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

