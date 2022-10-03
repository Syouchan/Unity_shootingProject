using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class status : MonoBehaviour
{
    //プレイヤーのステータスの数値
    public int Lv = 1;
    public int power = 0;
    //現在のライフ値
    public int lifeCount = 3;
    public int LifePeace = 0;
    //現在のスキル回数
    public int skill = 2;
    //現在のULTゲージ
    //public int ULT = 0;
    //現在のスコア
    public int score = 0;

    ////////////////////////////////////////////
    //ダメージを受けた時の点滅間隔と点滅カウント
    [SerializeField] float flashInterval;
    [SerializeField] float tenmetucount;
    //点滅させるためのSpriteRenderer
    SpriteRenderer sp;
    //サークルコライダーコンポーネントを付与
    //※被弾時の当たり判定処理の為（無敵）
    CircleCollider2D CCD2D;
    /// ///////////////////////////////////////

    //2D物理のコンポーネントを付与
    Rigidbody2D rbody;

    //ステータステキストUI
    public Text LvText;
    public Text powerText;
    public Text LifePeaceText;
    public Text ULTText;
    public Text ULTPText;
    public Text PointText;

    //ライフのUIを表すオブジェクト配列
    public GameObject[] LifeImage = new GameObject[8];

    //ライフピース版
    //public GameObject[] LifePeaceImage = new GameObject[5];

    //skillのUIを表す配列
    public GameObject[] SkillImage = new GameObject[8];

    //ultのゲージ（スライダー）
    public Slider ultslider;

    void start()
    {
        //各種コンポーネントを格納
        sp = GetComponent<SpriteRenderer>();
        CCD2D = GetComponent<CircleCollider2D>();
        rbody = GetComponent<Rigidbody2D>();
        ultSliderCTR();
    }

    private void Update()
    {
        rbody = this.GetComponent<Rigidbody2D>();
        
        if(Lv == 4){
            LvText.text = Lv.ToString("Lv:MAX");
        }else{
            LvText.text = Lv.ToString("Lv:" + Lv);
        }
        powerText.text = power.ToString("Power:" + power);
        //LifeText.text = Life.ToString("Life:" + Life);
        LifePeaceText.text = LifePeace.ToString(LifePeace + "/5 LifePeace");
        PointText.text = score.ToString("Score:" + score);
        //LifeUI();
        //SkillUI();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //アイテムの取得に合わせてステータスの更新
        if (collision.tag == "Poweritem")
        {
            if (Lv == 4)
            {
                power = 0;
                //ULTP = ULTP + 1;
                Destroy(collision.gameObject);
            }
            else
            {
                power++;
                Destroy(collision.gameObject);
            }
        }

        else if (collision.tag == "MAXpoweritem")
        {
            if (Lv == 4)
            {
                power = 0;
                Destroy(collision.gameObject);
            }
            else
            {
                power = power + 99;
                Destroy(collision.gameObject);
            }
        }

        if (power >= 99)
        {
            power = power - 99;
            Lv++;
            AddBulletSpeed(Lv);
        }
        else if(Lv == 4 && power >= 0){
            power = 0;
        }

        if(collision.tag == "lifePeace"){
            if(lifeCount == 8){
                Destroy(collision.gameObject);
            }
            else{
                LifePeace++;
                Destroy(collision.gameObject);
                if(LifePeace >= 5){
                    LifeImage[lifeCount].SetActive(true);
                    lifeCount++;
                    LifePeace = 0;
                }
            }
        }
    }

    //ULTポイントをスライダーに反映させるメソッド
    void ultSliderCTR()
    {
        //ultslider.value = 0;
        //ultslider = GetComponent<Slider>();
        //ultpslider.maxValue = MAXULTP;
        //ultpslider.value = ULTP;
    }


    //レベルに応じて弾の発射速度の上昇
    void AddBulletSpeed(int Lv)
    {
        //弾の発射間隔
        //LV1:0.3  LV2:0.25  LV3:0.2  LV4:0.15
        //LV1:0.2  LV2:0.15  LV3:0.1  LV4:0.05
        if (Lv != 1)
        {
            PlayerController1.syurikencooldowntime = 0.3f - ((Lv - 1) * 0.05f);
            PlayerController1.kunaicooldowntime = 0.2f - ((Lv - 1) * 0.05f);
        }
    }

    //レベルに応じて弾の発射速度低下
    void FallSpeed()
    {
        PlayerController1.syurikencooldowntime = PlayerController1.syurikencooldowntime + 0.05f;
        PlayerController1.kunaicooldowntime = PlayerController1.kunaicooldowntime + 0.05f;
    }
}
