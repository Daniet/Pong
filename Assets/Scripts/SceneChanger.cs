using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class SceneChanger : MonoBehaviour {

	public void ChangesSceneTo(string sceneName){
		EditorSceneManager.LoadScene(sceneName);
	}
}
