﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeOption : MonoBehaviour {

	//Refetence to Audio Source Component
	private AudioSource audioSrc;

	//Music volume variable that will be modified
	//by dragging slider knob
	private float musicVolume = 1f;

	// Use this for initialization
	void Start () {
		//Assign Audio Source component to control it
		audioSrc = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

		//Setting volume option of Audio Source to be equal to musicVolume
		audioSrc.volume = musicVolume;
	}

	public void SetVolume(float vol){
		musicVolume = vol;
	}
}
