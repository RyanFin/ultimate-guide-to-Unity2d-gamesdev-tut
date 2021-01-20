using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectCollision : MonoBehaviour
{
    private int score, numCoinsCollectedPerLevel;
    // Start is called before the first frame update
    void Start(){
      numCoinsCollectedPerLevel = 0;
    }

    // Update is called once per frame
    void Update(){

    }

    void OnCollisionEnter2D(Collision2D col){
      string tagName = col.collider.gameObject.tag;
      if(tagName == "pick_me"){
        Destroy(col.collider.gameObject);
        score++;
        numCoinsCollectedPerLevel++;
        if(SceneManager.GetActiveScene().name == "level1" && numCoinsCollectedPerLevel >= 5 ){
          SceneManager.LoadScene("level2");
        }
        print("Score: " + score );
      }
      if(tagName == "avoid_me"){
        Destroy(col.collider.gameObject);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
      }
      if(tagName == "reStarter"){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
      }
    }
}
