using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour {


	public void NextScene(int cena){
	
		SceneManager.LoadScene (cena);
	
	}

	public void sair(){
	
		Application.Quit ();
		Debug.Log ("funfa");
	
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
