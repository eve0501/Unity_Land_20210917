using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [Header("��ܸ��")]
    public DataDialogue dataDialogue;
    [Header("��ܨt��")]
    public DialogueSystem dialogueSystem;
    [Header("Ĳ�o��ܪ���H")]
    public string target = "�p�k��";


    //Ĳ�o�}�l�ƥ�
    //1.��Ӫ��󳣭n�� collider 2D
    //2.��ӭn�� rigidbody 2D
    //3.��ӭn���@�Ӥ� is Trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == target)
        {
            print(collision.name);
            print("���F��i�JĲ�o�ϰ�");
        }
    }

}
