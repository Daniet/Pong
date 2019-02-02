using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeadZone : MonoBehaviour {

    public Text scorePlayerText;
    public Text scoreEnemyText;
	public SceneChanger sceneChanger;

    int scorePlayerQuantity;
    int scoreEnemyQuantity;

    private void OnTriggerEnter2D(Collider2D ball){
        if(gameObject.tag == "Left"){
            scoreEnemyQuantity++;
            UpdateScoreLabel(scoreEnemyText, scoreEnemyQuantity);
        }else if (gameObject.CompareTag("Rigth")){
            scorePlayerQuantity++;
            UpdateScoreLabel(scorePlayerText, scorePlayerQuantity);
        }
		ball.GetComponent<BallBehaviour>().gamesStarted = false;
		CheckSocore();
    }

    void UpdateScoreLabel(Text label, int score){
        label.text = score.ToString();
    }

	void CheckSocore(){
		if(scorePlayerQuantity >= 3){
			sceneChanger.ChangesSceneTo("WinScene");
		}else if(scoreEnemyQuantity >= 3){
			sceneChanger.ChangesSceneTo("LoseScene");
		}
	}
}
