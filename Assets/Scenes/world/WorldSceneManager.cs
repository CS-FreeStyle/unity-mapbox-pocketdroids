﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WorldSceneManager : PocketDroidsSceneManager {
	public override void droidTapped(GameObject droid)
	{
		SceneManager.LoadScene(PocketDroidConstants.SCENE_CAPTURE, LoadSceneMode.Additive);
	}

	public override void playerTapped(GameObject player)
	{
		throw new System.NotImplementedException();
	}

}
