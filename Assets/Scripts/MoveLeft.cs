using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour {

	public void Harambe () {
        float translation = Time.deltaTime * 1;
        transform.Translate(-50, 0, translation);
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            StopAllCoroutines();
            transform.Translate(50, 0, 0);
            StopAllCoroutines();
        }
    }
}
