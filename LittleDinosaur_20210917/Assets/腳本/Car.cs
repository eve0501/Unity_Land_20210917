using UnityEngine;    //�ޥ�Unity�����R�W������
public class Car : MonoBehaviour
{
    #region 

    //�|�j�`�λy�k
    public int cc = 1000;
    [Range(1, 10)]
    public float weight = 3.5f;
    [Tooltip("�o�O���l���~�P")]
    public string brand = "BENZ";
    [Header("�O�_���ѵ�")]
    public bool hasSkywindows = true;
    #endregion
    #region Unity���������
    //�C��
    public Color color;
    public Color colorRed = Color.red;
    public Color colorCustom1 = new Color(0, 0, 1);
    public Color colorCustom2 = new Color(1, 0, 1, 0.5f);
    //�V�q
    public Vector2 v2 ;
    public Vector2 v2One = Vector2.right;
    public Vector2 v2Right = Vector2.right;
    public Vector2 v2Left = Vector2.left;
    public Vector2 v2Custom = new Vector2(1, 2);
    public Vector3 v3Custom = new Vector3(1, 2, 3);
    public Vector4 v4Custom = new Vector4(1, 2, 3, 4);
    //����
    public KeyCode keyCode;
    public KeyCode keycodeMouseLeft = KeyCode.Mouse0;
    public KeyCode keycodeJump = KeyCode.Space;
    //�C������
    public GameObject goCamera;
    public GameObject goCar;
    //����
    public Transform traCamera;
    public Camera cam;
    public SpriteRenderer spr; 

    #endregion
    
}