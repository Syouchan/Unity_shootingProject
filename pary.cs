using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pary : MonoBehaviour
{
    public GameObject ParyArea;
    bool parycooldown = false;
    void Start()
    {
        //rbody = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        paryCtr();
    }
    	void paryCtr(){
		if(Input.GetKeyDown(KeyCode.Space) && parycooldown == false){
			StartCoroutine("Pary");
		}
	}
    	IEnumerator Pary(){
		ParyArea.SetActive(true);
		yield return new WaitForSeconds(0.1f);
		ParyArea.SetActive(false);
		parycooldown = true;
		yield return new WaitForSeconds(0.5f);
		parycooldown = false;
	}
}
