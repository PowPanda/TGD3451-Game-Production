using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeView : MonoBehaviour {

    public Transform rightView;
    public Transform leftView;

    bool isRightView;
    bool isLeftView;

	// Use this for initialization
	void Start () {
        isRightView = true;
        isLeftView = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isRightView)
            {
                transform.position = leftView.position;
                isRightView = false;
                isLeftView = true;
            }

            else if (isLeftView)
            {
                transform.position = rightView.position;
                isLeftView = false;
                isRightView = true;
            }
        }
            

	}
}
