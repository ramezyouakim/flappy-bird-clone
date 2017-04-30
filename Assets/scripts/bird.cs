using UnityEngine;
using System.Collections;

public class bird : MonoBehaviour {

    public float upforce;
    private bool isDead = false;
    private Rigidbody2D rdBRID2d;
    private Animator animBride;

	// Use this for initialization
	void Start () {
        rdBRID2d = GetComponent<Rigidbody2D>();
        animBride = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        if(isDead == false)
        {

            if(Input.GetMouseButtonDown(0))
            {
                rdBRID2d.velocity = Vector2.zero;
                rdBRID2d.AddForce(new Vector2(0,upforce));
                animBride.SetTrigger("flap");

            }
        }
	
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
       
      
        
            isDead = true;
            animBride.SetTrigger("die");
            camecont.instance.Bridedead();
        
    }
}
