using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class scr_ray : MonoBehaviour
{
    public Text score;
    private int scoreValue = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            Debug.DrawRay(ray.origin, ray.direction * 10, Color.green);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "Alvo")
                {
                    Debug.Log("Acertou");
                    Destroy(hit.transform.gameObject);
               
                    scoreValue++;
                    score.text = scoreValue.ToString();
                }
            }
            
        }   
    }

    
}   
