using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{
    //Bossの最大HP
    [SerializeField] int MaxBossHP = 100;
    //BossのHP
    [SerializeField] int BossHP;
    //BossのHPSlider
    [SerializeField] GameObject BossHPSlider;//表示、非表示用
    public Slider BossHpslider;//現在のHP反映用
    //判定したいオブジェクトのrendererへの参照
    Renderer targetRenderer; 
    void Start()
    {
        targetRenderer = GetComponent<Renderer>();
        BossHpslider.value = 1;
        BossHP = MaxBossHP;
    }

    void Update()
    {
        if(targetRenderer.isVisible) BossHPSlider.SetActive(true);
        else BossHPSlider.SetActive(false);
        if (BossHP <= 0)
        {
            Debug.Log("撃破");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "syuriken")
        {
            BossHP = BossHP - 1;
            //最大HPにおける現在のHPをSliderに反映。
            //int同士の割り算は小数点以下は0になるので、
            //(float)をつけてfloatの変数として振舞わせる。
            BossHpslider.value = (float)BossHP / (float)MaxBossHP; ;
            Destroy(collision.gameObject);
        }
        else if (collision.tag == "kunai")
        {
            BossHP = BossHP - 2;
            BossHpslider.value = (float)BossHP / (float)MaxBossHP; ;
            Destroy(collision.gameObject);
        }
        else if (collision.tag == "Skill")
        {
            BossHP = BossHP - 20;
            BossHpslider.value = (float)BossHP / (float)MaxBossHP; ;
            Destroy(collision.gameObject);
        }
    }
}
