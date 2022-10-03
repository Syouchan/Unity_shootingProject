using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kunai : MonoBehaviour
{
    [SerializeField] float bulletspeed1 = 0.01f;
    public GameObject Hitanim;
    Rigidbody2D rid2d;

    public string bullet1 ="bullet";

    void Start()
    {
        rid2d = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        transform.Translate(bulletspeed1 * Time.deltaTime,0 , 0);

        if (transform.position.x > 100.0f)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.tag == "enemy" || collision.gameObject.tag == "Boss"){
            Instantiate(Hitanim,this.transform.position, this.transform.rotation);
            Destroy(gameObject);
        }
    }
}
