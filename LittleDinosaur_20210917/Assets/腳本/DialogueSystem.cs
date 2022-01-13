using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class DialogueSystem : MonoBehaviour
{
    [Header("��ܶ���"), Range(0, 1)]
    public float interval = 0.3f;
    [Header("�e����ܨt��")]
    public GameObject goDialogue;
    [Header("��ܤ��e")]
    public Text textContent;
    [Header("��ܧ����ϥ�")]
    public GameObject goTip;
    [Header("��ܫ���")]
    public KeyCode keyDialogue = KeyCode.E;

    private void Start()
    {
        //StartCoroutine(TypeEffect());
    }

    private IEnumerator TypeEffect(string[] contents)
    {
       // string test1 = "���o�A�A�n~";
        //string test2 = "��ܲĤG�q~";
        //string[] contents = { test1, test2 };


        goDialogue.SetActive(true);                            //��ܹ�ܪ���

        for (int j = 0; j < contents.Length; j++)               //�M�M�Ҧ����
        {
            textContent.text = "";                        //�M���W����ܤ��e
            goTip.SetActive(false);                      //���� ���ܹϥ� �T����

            for (int i = 0; i < contents[j].Length; i++)   //�M�M��ܪ��C�@�Ӧr
            {
                textContent.text += contents[j][i];        //�|�[��ܤ��e��r����
                yield return new WaitForSeconds(interval);
            }

            goTip.SetActive(true);                           //��ܹ�ܧ����ϥ� �T����

            while (!Input.GetKeyDown(keyDialogue))           //���a�S���������ɫ���
            {
                yield return null;                         //���� null �@�Ӽv�檺�ɶ�
            }
        }

        goDialogue.SetActive(false);                           //���ù�ܪ���
    }

    ///<summary>
    ///�}�l���
    /// </summary>
    /// <param name="contents">�n��ܥ��r�ĪG����ܤ��e</param>
    public void StartDialogue(string[] contents)
    {
        StartCoroutine(TypeEffect(contents));
    }
    ///<summary>
    ///������
    /// </summary>
    public void StopDialogue()
    {
        StopAllCoroutines();              //�����{
        goDialogue.SetActive(false);      //���ù�ܤ���
    }


}
