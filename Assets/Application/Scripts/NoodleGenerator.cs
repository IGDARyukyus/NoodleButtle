﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoodleGenerator : MonoBehaviour {

	private int count = 10;
	public GameObject noodle;
	private float Times = 1f;
	// Use this for initialization
	IEnumerator Start () {
		int i = 0;
		while (i < count) {
			Instantiate (noodle, transform.position, noodle.transform.rotation);
			yield return new WaitForSeconds (Times);
			i++;
		}
	}
}