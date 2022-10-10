using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class mazetilt : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {
     
     
    
    }

    // Update is called once per frame
    void Update()
    {
        float Vertical = Input.GetAxis("Mouse X");
        float Horizontal = Input.GetAxis("Mouse Y");
       // Debug.Log(Vertical);
          transform.Rotate(-Vertical, Horizontal, 0);

    }
   // void OnCollisionEnter(Collision Ball){
      //SceneManager.LoadScene(0);

   // }
    }


