using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Collisions : MonoBehaviour {

	public Text score;
	public int cena;
	public GameObject nave;
	public int pontos;
	public GameObject painel;

	void OnCollisionEnter2D(Collision2D col){

		if (col.gameObject.tag == "chao") {
			SceneManager.LoadScene (cena);
		
		}

	
	}

	void OnCollisionStay2D(Collision2D col){
		if (col.gameObject.tag == "pouso2" && nave.transform.eulerAngles.y>-10 && nave.transform.eulerAngles.y<10) {
			pontos = 100;
			painel.SetActive(true);
			score.text = "Score: " + pontos;

		}
		if (col.gameObject.tag == "pousoUm"&& nave.transform.eulerAngles.y>-10 && nave.transform.eulerAngles.y<10) {
			pontos = 300;
			painel.SetActive(true);
			score.text = "Score: " + pontos;

		}
		if (col.gameObject.tag == "pouso3"&& nave.transform.eulerAngles.y>-10 && nave.transform.eulerAngles.y<10) {
			pontos = 200;
			painel.SetActive(true);
			score.text = "Score: " + pontos;

		}
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
