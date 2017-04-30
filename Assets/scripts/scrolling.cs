using UnityEngine;
using System.Collections;

public class scrolling : MonoBehaviour {

    private Rigidbody2D bgScroll;

	// Use this for initialization
	void Start () {
        bgScroll = GetComponent<Rigidbody2D>();
        bgScroll.velocity = new Vector2(camecont.instance.scrollingSpeed,0);
	}
	
	// Update is called once per frame
	void Update () {
        if (camecont.instance.gameover == true)
        {
            bgScroll.velocity = Vector2.zero;
        }

	
	}
}
