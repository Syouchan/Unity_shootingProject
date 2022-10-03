using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class syurikencenter : MonoBehaviour
{
    [SerializeField] float bulletspeed1 = 0.1f;
    public float Velocity_0, theta;
    public GameObject Hitanim;
    Rigidbody2D rid2d;
    
    private void Start()
    {
        //Rigidbodys
        rid2d = GetComponent<Rigidbody2D>();
        //
        Vector2 bulletV = rid2d.velocity;
        bulletV.x = Velocity_0 * Mathf.Cos(theta);
        bulletV.y = Velocity_0 * Mathf.Sin(theta);
        rid2d.velocity = bulletV;
    }
    private void Update()
    {
        transform.Translate(bulletspeed1 * Time.deltaTime ,0 , 0);

        if (transform.position.x > 100.0f)
        {
            Destroy(gameObject);
            //this.gameObject.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.tag == "enemy" || collision.gameObject.tag == "Boss"){
            Instantiate(Hitanim,this.transform.position, this.transform.rotation);
            Destroy(gameObject);
        }
    }
}
