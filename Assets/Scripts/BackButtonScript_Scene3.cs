using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BackButtonScript_Scene3 : MonoBehaviour {

	// Use this for initialization
	public void Start () {
	
	}
	
	// Update is called once per frame
	public void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(2);

            return;
        }
    }
}
