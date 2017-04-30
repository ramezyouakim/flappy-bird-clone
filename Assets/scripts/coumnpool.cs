using UnityEngine;
using System.Collections;

public class coumnpool : MonoBehaviour {

    public int colarrysize = 5;
    public GameObject prefap;
    public float spwnrate = -2f;
    public float colmin = -1f;
    public float colmax = 3.5f;
    
    

    GameObject [] colarray;
    private Vector2 objectpostision = new Vector2(-15f,-15f);
    private float timesincelastcol;
    private float spwnxpost = 5f;
    private int currentcol = 0;


    // Use this for initialization
    void Start () {

        colarray = new GameObject[colarrysize];
        for (int i = 0; i < colarrysize; i++)
        {
            colarray[i] = (GameObject)Instantiate(prefap, objectpostision, Quaternion.identity);
        }

	}
	
	// Update is called once per frame
	void Update () {
        timesincelastcol +=Time.deltaTime;

	if(camecont.instance.gameover == false && timesincelastcol >=spwnrate)
        {
            timesincelastcol = 0;
            float spwnypost = Random.Range(colmin, colmax);
            colarray[currentcol].transform.position = new Vector2(spwnxpost, spwnypost);
            currentcol++;
            if(currentcol>= colarrysize)
            {
                currentcol = 0;
            }
        }

	}
}
