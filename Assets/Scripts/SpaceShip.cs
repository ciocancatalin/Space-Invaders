using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceShip : MonoBehaviour {

    public float speed = 30;
    public bool alive;
    public GameObject theBullet;
    public string loseScene;
    public string winScene;
    public int secTillSceneLoad;
    public int alienNumber = 16;

    private void FixedUpdate()
    {
        float horzMove = Input.GetAxisRaw("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(horzMove, 0) * speed;
    }

    // Use this for initialization
    void Start () {
        alive = true;
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Jump"))
        {
            Instantiate(theBullet, transform.position, Quaternion.identity);
            SoundManager.Instance.PlayOneShot(SoundManager.Instance.bulletFire);
        }
        if (!alive)
        {
            Invoke("OpenNextScene1", 0.5f);
            Destroy(GameObject.FindWithTag("SoundMan"));

        }
        if(alive && alienNumber == 0)
        {
            Invoke("OpenNextScene2", 0.5f);
        }

    }

    private void OpenNextScene1()
    {
        SceneManager.LoadScene(loseScene);
    }
    private void OpenNextScene2()
    {
        SceneManager.LoadScene(winScene);
    }
}
