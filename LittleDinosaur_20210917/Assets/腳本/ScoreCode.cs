using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCode : MonoBehaviour
{

    //�ŧi���ưѼ�

    public static int Score;

    //�ŧi��rUI

    public Text ShowScore;

    void Update()

    {

        //��UI��r�P���ƦP�B

        ShowScore.text = Score.ToString();

    }

}
