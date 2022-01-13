using UnityEngine;
using UnityEngine.UI;  //�ޥΤ���API
using UnityEngine.Events; //�ިƥ� API

/// <summary>
/// ���˨t��
/// </summary>
public class HurtSystem : MonoBehaviour
{
    [Header("���")]
    public Image imgHpBar;
    [Header("��q")]
    public float hp = 100;
    [Header("�ʵe�Ѽ�")]
    public string parameterDead = "���`Ĳ�o";
    [Header("���`�ƥ�")]
    public UnityEvent onDead;
  
    private float hpMax;
    private Animator ani;

    private AudioSource audioSource;
    public AudioClip PlayerHurt;

    public void PlaySound(AudioClip audioClip)
    {
        audioSource.PlayOneShot(audioClip);
    }

    //����ƥ� : �b Start���e����@��
    private void Awake()
    {
        ani = GetComponent<Animator>();
        hpMax = hp;
    }

    ///<summary>
    ///����
    ///</summary>
    ///<param name="damage">�������ˮ`</param>
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
