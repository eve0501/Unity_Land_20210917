using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 敵人行為
/// 檢測目標物件是否再追蹤區域
/// 追蹤與攻擊目標
/// </summary>

public class Enemy : MonoBehaviour
{
    #region 欄位
    [Header("檢查追蹤區域大小與位移")]
    public Vector3 v3TrackSize = Vector3.one;
    public Vector3 v3TrackOffset;
    [Header("移動速度")]
    public float speed = 1.5f;
    [Header("目標圖層")]
    public LayerMask layerTarget;
    [Header("動畫參數")]
    public string parameterWalk = "走路開關";
    public string parameterAttack = "攻擊觸發";
    [Header("面相目標物件")]
    public Transform target;
    [Header("攻擊距離"), Range(0, 5)]
    public float attacDistance = 1.3f;
    [Header("攻擊冷卻時間"), Range(0, 10)]
    public float attackCD = 2.8f;
    [Header("檢查攻擊區域大小與位移")]
    public Vector3 v3AttackSize = Vector3.one;
    public Vector3 v3AttackOffset;

    private float angle = 0;
    private Rigidbody2D rig;
    private Animator ani;
    private float timerAttack;
    #endregion

    #region
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }
    private void OneDrawGizmos()
    {
        Gizmos.color = new Color(1, 0, 0, 0.3f);
        Gizmos.DrawCube(transform.position + transform.TransformDirection(v3TrackOffset), v3TrackSize);

        Gizmos.color = new Color(0, 1, 0, 0.3f);
        Gizmos.DrawCube(transform.position + transform.TransformDirection(v3AttackOffset), v3AttackSize);
    }

    private void Update()
    {
        CheckTargetInArea();
    }
    #endregion

    #region
    ///<summary>
    ///檢查是否在區域內
    ///</summary>
    private void CheckTargetInArea()
    {
        Collider2D hit = Physics2D.OverlapBox(transform.position + transform.TransformDirection(v3TrackOffset), v3TrackSize, 0, layerTarget);

        if (hit) rig.velocity = new Vector2(- speed, rig.velocity.y); Move();
    }

    ///<summary>
    ///移動
    ///</summary>
    private void Move()
    {
        //三原運算子語法 : 布林值 ? 當布林值 為 ture : 當布林值 為 false ;
        //如果 目標的 x 小於 敵人的 x 就代表在左邊 角度 0
        //如果 目標的 x 大於 敵人的 x 就代表在右邊 角度 180

        if (target.position.x > transform.position.x)
        {
            //右邊 angle = 180
        }
        else if (target.position.x < transform.position.x)
        {
            //左邊 angle = 0
        }

        angle = target.position.x > transform.position.x ? 180 : 0;
        transform.eulerAngles = Vector3.up * angle;

        rig.velocity = transform.TransformDirection(new Vector2(-speed, rig.velocity.y));
        ani.SetBool(parameterWalk, true);

        //距離 = 三維向量.距離(A點，B點)
        float distance = Vector3.Distance(target.position, transform.position);
        print("與目標的距離:" + distance);

        //if (distance <= attackDistance)
        {
            rig.velocity = Vector3.zero;
            //Attack();
        }
    }
}
    #endregion
