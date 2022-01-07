using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [Header("對話資料")]
    public DataDialogue dataDialogue;
    [Header("對話系統")]
    public DialogueSystem dialogueSystem;
    [Header("觸發對話的對象")]
    public string target = "小女孩";


    //觸發開始事件
    //1.兩個物件都要有 collider 2D
    //2.兩個要有 rigidbody 2D
    //3.兩個要有一個勾 is Trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == target)
        {
            print(collision.name);
            print("有東西進入觸發區域");
        }
    }

}
