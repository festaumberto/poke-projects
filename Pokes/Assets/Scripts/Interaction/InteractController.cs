using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pokes.Interactable {
    public class InteractController : MonoBehaviour
    {
        [SerializeField] float rayLength = 4f;
        private RaycastHit targetHit;
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            Debug.DrawRay(transform.position, transform.forward * rayLength, Color.red,0.5f);

            if(Physics.Raycast(transform.position, transform.forward, out targetHit, rayLength)){
                print("something in range");
                if(targetHit.collider.GetComponent<Interactable>() != null){
                    print("interactable in range");
                    targetHit.collider.GetComponent<Interactable>().Interact();
                }
            }
        }
    }
}