using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class camecont : MonoBehaviour {

    public static camecont instance;
    public GameObject gameovertext;
    public bool gameover = false;
    public Text scoreText;
    public float scrollingSpeed;
    private int score;

    // Use this for initialization
    void Awake () {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }
	
	}
	
	// Update is called once per frame
	void Update () {
        if (gameover == true && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
	
	}

    public void Score()
    {
        if(gameover)
        {
            return;
        }
        score++;
        scoreText.text = "score: " + score.ToString();
    }

    public void Bridedead()
    {
        gameovertext.SetActive(true);
        gameover = true;
    }

}
