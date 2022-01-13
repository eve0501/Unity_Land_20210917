using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class DialogueSystem : MonoBehaviour
{
    [Header("對話間格"), Range(0, 1)]
    public float interval = 0.3f;
    [Header("畫布對話系統")]
    public GameObject goDialogue;
    [Header("對話內容")]
    public Text textContent;
    [Header("對話完成圖示")]
    public GameObject goTip;
    [Header("對話按鍵")]
    public KeyCode keyDialogue = KeyCode.E;

    private void Start()
    {
        //StartCoroutine(TypeEffect());
    }

    private IEnumerator TypeEffect(string[] contents)
    {
       // string test1 = "哈囉，你好~";
        //string test2 = "對話第二段~";
        //string[] contents = { test1, test2 };


        goDialogue.SetActive(true);                            //顯示對話物件

        for (int j = 0; j < contents.Length; j++)               //遍尋所有對話
        {
            textContent.text = "";                        //清除上次對話內容
            goTip.SetActive(false);                      //隱藏 提示圖示 三角形

            for (int i = 0; i < contents[j].Length; i++)   //遍尋對話的每一個字
            {
                textContent.text += contents[j][i];        //疊加對話內容文字介面
                yield return new WaitForSeconds(interval);
            }

            goTip.SetActive(true);                           //顯示對話完成圖示 三角形

            while (!Input.GetKeyDown(keyDialogue))           //當玩家沒有按對話鍵時持續
            {
                yield return null;                         //等待 null 一個影格的時間
            }
        }

        goDialogue.SetActive(false);                           //隱藏對話物件
    }

    ///<summary>
    ///開始對話
    /// </summary>
    /// <param name="contents">要顯示打字效果的對話內容</param>
    public void StartDialogue(string[] contents)
    {
        StartCoroutine(TypeEffect(contents));
    }
    ///<summary>
    ///停止對話
    /// </summary>
    public void StopDialogue()
    {
        StopAllCoroutines();              //停止協程
        goDialogue.SetActive(false);      //隱藏對話介面
    }


}
