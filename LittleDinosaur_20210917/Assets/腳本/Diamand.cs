using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamand : MonoBehaviour
{
    public GameObject pickE;

    public AudioClip audioClip;

    private void OnTriggerEnter2D(Collider2D collision)

    {
        Instantiate(pickE, gameObject.transform.position, Quaternion.identity);

        Controller2D move = collision.GetComponent<Controller2D>();
        move.PlaySound(audioClip);

        Destroy(gameObject);
    }

   
}
