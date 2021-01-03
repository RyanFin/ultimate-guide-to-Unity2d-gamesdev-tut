using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectCollision : MonoBehaviour
{
    private int score;
    // Start is called before the first frame update
    void Start(){

    }

    // Update is called once per frame
    void Update(){

    }

    void OnCollisionEnter2D(Collision2D col){
      string tagName = col.collider.gameObject.tag;
      if(tagName == "pick_me"){
        Destroy(col.collider.gameObject);
        score++;
        print("Score: " + score );
      }
      if(tagName == "avoid_me"){
        Destroy(col.collider.gameObject);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
      }
    }
}
