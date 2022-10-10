using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelReset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          
    }
    void OnCollisionEnter(Collision Ball){
      SceneManager.LoadScene("Maze");
      //Debug.Log("y");
    }
}
