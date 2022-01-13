using UnityEngine;
using UnityEngine.UI;  //引用介面API
using UnityEngine.Events; //引事件 API

/// <summary>
/// 受傷系統
/// </summary>
public class HurtSystem : MonoBehaviour
{
    [Header("血條")]
    public Image imgHpBar;
    [Header("血量")]
    public float hp = 100;
    [Header("動畫參數")]
    public string parameterDead = "死亡觸發";
    [Header("死亡事件")]
    public UnityEvent onDead;
  
    private float hpMax;
    private Animator ani;

    private AudioSource audioSource;
    public AudioClip PlayerHurt;

    public void PlaySound(AudioClip audioClip)
    {
        audioSource.PlayOneShot(audioClip);
    }

    //喚醒事件 : 在 Start之前執行一次
    private void Awake()
    {
        ani = GetComponent<Animator>();
        hpMax = hp;
    }

    ///<summary>
    ///受傷
    ///</summary>
    ///<param name="damage">接受的傷害</param>
    public void Hurt(float damage)
    {
        hp -= damage;
        imgHpBar.fillAmount = hp / hpMax;
        if (hp <= 0) Dead();

        audioSource = GetComponent<AudioSource>();
       
        PlaySound(PlayerHurt);

       
       
    }

    private void Dead()
    {
        ani.SetTrigger(parameterDead);
        onDead.Invoke();
    }
}
