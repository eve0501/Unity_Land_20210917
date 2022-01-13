using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PassSystem : MonoBehaviour
{
    public string nameTarget = "¤p¤k«Ä";
    public UnityEvent onPass;

    private AudioSource audioSource;
    public AudioClip PassSound;

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == nameTarget) onPass.Invoke();

        Controller2D move = collision.GetComponent<Controller2D>();
        move.PlaySound(PassSound);
       
    }

   
}
