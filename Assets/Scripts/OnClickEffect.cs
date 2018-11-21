using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class OnClickEffect : MonoBehaviour {

	public string SceneToNavTo;

	public void Navigate ()
	{
		SceneManager.LoadScene(SceneToNavTo);
	}
}
