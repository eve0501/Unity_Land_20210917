using UnityEngine;    //引用Unity引擎命名單行註解
public class Car : MonoBehaviour
{
    #region 

    //四大常用語法
    public int cc = 1000;
    [Range(1, 10)]
    public float weight = 3.5f;
    [Tooltip("這是車子的品牌")]
    public string brand = "BENZ";
    [Header("是否有天窗")]
    public bool hasSkywindows = true;
    #endregion
    #region Unity內資料類型
    //顏色
    public Color color;
    public Color colorRed = Color.red;
    public Color colorCustom1 = new Color(0, 0, 1);
    public Color colorCustom2 = new Color(1, 0, 1, 0.5f);
    //向量
    public Vector2 v2 ;
    public Vector2 v2One = Vector2.right;
    public Vector2 v2Right = Vector2.right;
    public Vector2 v2Left = Vector2.left;
    public Vector2 v2Custom = new Vector2(1, 2);
    public Vector3 v3Custom = new Vector3(1, 2, 3);
    public Vector4 v4Custom = new Vector4(1, 2, 3, 4);
    //按鍵
    public KeyCode keyCode;
    public KeyCode keycodeMouseLeft = KeyCode.Mouse0;
    public KeyCode keycodeJump = KeyCode.Space;
    //遊戲物件
    public GameObject goCamera;
    public GameObject goCar;
    //元件
    public Transform traCamera;
    public Camera cam;
    public SpriteRenderer spr; 

    #endregion
    
}