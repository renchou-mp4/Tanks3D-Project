using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour {

	public float speed = 5;
	public float angularSpeed = 5;
	public float number = 1;
	private Rigidbody rig;
	public AudioClip idleAudio;
	public AudioClip drivingAudio;
	private AudioSource audio;

	// Use this for initialization
	void Start () {
		rig = this.GetComponent<Rigidbody>();
		audio = this.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float v = Input.GetAxis("VerticalPlayer" + number);
		rig.velocity = transform.forward * v * speed;

		float h = Input.GetAxis("HorizontalPlayer" + number);
		rig.angularVelocity = transform.up * h * angularSpeed;

		if(Mathf.Abs(h)>0.1||Mathf.Abs(v)>0.1)
        {
			audio.clip = drivingAudio;
			if(audio.isPlaying==false)
				audio.Play();
        }
        else
        {
			audio.clip = idleAudio;
			if (audio.isPlaying == false)
				audio.Play();
        }
	}
}
