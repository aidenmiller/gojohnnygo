﻿using System;
using UnityEngine;

public class HealthContainer : MonoBehaviour {

	public GameObject player;
	private float distx,disty;

	// Update is called once per frame
	void FixedUpdate () {
		// Rotation
		transform.Rotate(Vector3.up * Time.deltaTime * 300);

		// Award player the coin when making contact
		distx = player.transform.position.x - transform.position.x;
		disty = player.transform.position.y - transform.position.y;

		if (Math.Abs (distx) < 1 && Math.Abs (disty) < 1) {
			// play sound when coin obtained?
			Destroy (this.gameObject);
			RewardPlayer (1);
		}
	}

	private void RewardPlayer (int amount){
		PlayerControl playerScript = FindObjectOfType<PlayerControl>();
		playerScript.healthCollect (1);
	}
}
