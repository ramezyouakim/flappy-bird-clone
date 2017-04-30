using UnityEngine;
using System.Collections;

public class column : MonoBehaviour {

	private void OnTriggerEnter2D(Collider2D cl)
    {
        if(cl.GetComponent<bird>() !=null)
        {
            camecont.instance.Score();
        }

    }
}
