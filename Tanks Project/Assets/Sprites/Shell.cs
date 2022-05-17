using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour {

	public GameObject shellExplotionPrefab;
	public AudioClip shellExplotionAudio;

	public void OnTriggerEnter(Collider collider)
	{
		AudioSource.PlayClipAtPoint(shellExplotionAudio, transform.position);
		GameObject.Instantiate(shellExplotionPrefab, transform.position, transform.rotation);
		GameObject.Destroy(this.gameObject);

		if(collider.tag=="Tank")
        {
			collider.SendMessage("TakeDamage");
        }
	}
}
