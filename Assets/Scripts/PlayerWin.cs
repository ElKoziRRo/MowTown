using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerWin : MonoBehaviour {

	public Text winMessage;
	public string p1YardName = "Grass1";
	public string p2YardName = "Grass2";

	private bool gameEnd = false;
	private GameObject[] p1Yard;
	private GameObject[] p2Yard;

	// Use this for initialization
	void Start () {
		winMessage.gameObject.SetActive(false);
		winMessage.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		p1Yard = GameObject.FindGameObjectsWithTag (p1YardName);
		p2Yard = GameObject.FindGameObjectsWithTag (p2YardName);

		// Dev Build Only!
		QuickClear ();
		// ------------------------------------

		if (p1Yard.Length == 0) {
			//Debug.Log("P1 Wins!");
			EndGame("P1");
		} else if (p2Yard.Length == 0) {
			//Debug.Log("P2 Wins!");
			EndGame("P2");
		}
	}

	// Use to quickly test win states.
	void QuickClear(){
		if (Input.GetKeyDown(KeyCode.Alpha1)) {
			foreach(GameObject grass in p1Yard)
				grass.GetComponent<CutTrigger>().Cut ();
		}
		else if (Input.GetKeyDown(KeyCode.Alpha2)) {
			foreach(GameObject grass in p2Yard)
				grass.GetComponent<CutTrigger>().Cut ();
		}
	}
	
	void EndGame( string winner ){
		gameEnd = true;
		//Time.timeScale = 0;
		if (winner == "P1") {
			winMessage.rectTransform.anchoredPosition = new Vector2(-200, -175);
			winMessage.text = "Player 1 Wins!";
			winMessage.color = new Color(255, 0, 0);
			winMessage.gameObject.SetActive(true);
		} else if (winner == "P2") {
			winMessage.rectTransform.anchoredPosition = new Vector2(200,-175);
			winMessage.text = "Player 2 Wins!";
			winMessage.color = new Color(0, 0, 255);
			winMessage.gameObject.SetActive(true);
		}
	}

	void EndGame() {
		EndGame ("");
	}

	public bool GameOver(){
		return gameEnd;
	}

}
