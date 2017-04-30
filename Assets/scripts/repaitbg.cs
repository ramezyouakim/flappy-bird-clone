using UnityEngine;
using System.Collections;

public class repaitbg : MonoBehaviour {

    private BoxCollider2D groundclo;
    private float lengthofgroundx;

	// Use this for initialization
	void Start ()
    {
        groundclo = GetComponent<BoxCollider2D>();
        lengthofgroundx = groundclo.size.x -0.2f;
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(transform.position.x < -lengthofgroundx)
        {
            repatingbg();
        }

	}

    private void repatingbg()
    {
        Vector2 groundoffset = new Vector2(lengthofgroundx *2f,0);
        transform.position = (Vector2)transform.position + groundoffset;
    }
}
