﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

	public void OnClick(){
		SceneManager.LoadScene("wormScene");
	}
}
