using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityStandardAssets.Characters.ThirdPerson;

public class AnimationPlayer : MonoBehaviour
{
    [SerializeField] PlayableDirector director;

    private void Start() {
        director.played += DisableInput;
        director.stopped += EnableInput;
    }

    private void OnTriggerEnter(Collider other) {
        director.Play();
    }

    void DisableInput(PlayableDirector p){
        GameObject player  = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<ThirdPersonCharacter>().Move(this.transform.position, false,false);
        player.GetComponent<ThirdPersonUserControl>().enabled = false;

    }
    void EnableInput(PlayableDirector p){
        GameObject player  = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<ThirdPersonUserControl>().enabled = true;
    }
}
