using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankHealth : MonoBehaviour {

	public int hp = 100;
	public GameObject TankExplosionPrefab;
	public AudioClip TankExplosionAudio;
	public Slider hpslider;
	private int hpTotal;

	// Use this for initialization
	void Start () {
		hpTotal = hp;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void TakeDamage()
    {
		hp -= Random.Range(10, 20);
		hpslider.value = (float)hp / hpTotal;
		if(hp<=0)
        {
			AudioSource.PlayClipAtPoint(TankExplosionAudio, transform.position);
			GameObject.Instantiate(TankExplosionPrefab, transform.position + Vector3.up, transform.rotation);
			GameObject.Destroy(this.gameObject);
		}
    }
}
