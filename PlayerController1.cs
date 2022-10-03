using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
	public float normalspeed = 7;
	public float slowspeed = 4;
	private float speed = 7;
	
	public static float syurikencooldowntime = 0.3f;
	public static float kunaicooldowntime = 0.2f;

	Rigidbody2D rbody;
    
	public GameObject BulletPosition;
	public GameObject syuriken;
	public GameObject kunai;
	public GameObject skillObj;
	public GameObject Status;

	public float _Velocity_0, Degree, Angle_Split;
	float _theta;
	float PI = Mathf.PI;
    
	bool Lshift = false;

	void Start()
	{
		rbody = this.GetComponent<Rigidbody2D>();
	}
	void Update()
	{
		playercontroll();
		shotcontroll();
		UseSkill();
	}
	void playercontroll()
	{
		
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
			speed = slowspeed;
			Lshift = true;
        }
		
        else if(Input.GetKeyUp(KeyCode.LeftShift))
		{
			speed = normalspeed;
			Lshift = false;
		}
		
		//X houkou no idou seigyo
		float x = Input.GetAxisRaw("Horizontal");
		//Y houkou no idou seigyo
		float y = Input.GetAxisRaw("Vertical");
		
		Vector2 direction = new Vector2(x, y).normalized;
		
		rbody.velocity = direction * speed;
	}

	//shot kanren
	void shotcontroll()
	{
		
		if (Input.GetKeyDown(KeyCode.Z))
		{
            StartCoroutine("Shot");
        }
		else if (Input.GetKeyUp(KeyCode.Z))
		{
            StopCoroutine("Shot");
        }
	}
    
	//skill
    void UseSkill()
	{
		if(Input.GetKeyDown(KeyCode.X))
		{
			if (Status.GetComponent<status>().skill > 0)
			{
				Status.GetComponent<status>().skill -= 1;
                Status.GetComponent<status>().SkillImage[Status.GetComponent<status>().skill].SetActive(false);
				Instantiate(skillObj, BulletPosition.transform.position, transform.rotation);
			}
			else
			{
				Debug.Log("スキルが足りぬ");
			}
		}
	}
	
    IEnumerator Shot()
    {
        while (true)
        {
            
            if (Lshift == false)
            {
                for (int i = 0; i <= (Angle_Split - 1); i++)
                {
                    //kakudowomotomeru
                    float AngleRange = PI * (Degree / 180);

					//tate shooting you
                    //if (Angle_Split > 1) _theta = (AngleRange / (Angle_Split - 1)) * i + 0.5f * (PI - AngleRange);
                    //else _theta = 0.5f * PI;

					//yoko shooting you
					if (Angle_Split > 1) _theta = (AngleRange / (Angle_Split - 1)) * i - 0.5f * AngleRange;
					else _theta = 0;

					//syuriken no seisei
					GameObject Bullet_obj = (GameObject)Instantiate(syuriken, BulletPosition.transform.position, transform.rotation);
                    syurikencenter bullet_cs = Bullet_obj.GetComponent<syurikencenter>();
                    bullet_cs.theta = _theta;
                    bullet_cs.Velocity_0 = _Velocity_0;
                }
                yield return new WaitForSeconds(syurikencooldowntime);
            }
            
            else if (Lshift == true)
            {
				//kunai no seisei
                Instantiate(kunai, BulletPosition.transform.position, transform.rotation);
                yield return new WaitForSeconds(kunaicooldowntime);
            }
        }
    }


}