using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pokes.Interactable {
    public class Interactable : MonoBehaviour
    {
        [SerializeField] GameObject hintObject;
        // Start is called before the first frame update
        void Start()
        {
            hintObject.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        public void Interact(){
            Vector3 hintPosition = transform.position;
            hintPosition.y+=1f;

            hintObject.SetActive(true);
            hintObject.transform.position = hintPosition;
        }
    }
}
