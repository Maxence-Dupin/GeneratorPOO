using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Generator.GeneratorScript 
{
    public class ShowSpecialAttack : MonoBehaviour
    {
        private void OnMouseEnter()
        {
            this.transform.parent.parent.GetComponent<Frame>().DisplaySpeAttack();
        }

        private void OnMouseExit()
        {
            this.transform.parent.parent.GetComponent<Frame>().UnDisplayLastPrefab();
        }
    }
}

