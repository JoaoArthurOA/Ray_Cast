using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class scr_spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject alvoPrefab;
    public int gerador;
    public float cooldown = 0.0f;
    

    // Update is called once per frame
    void Update()
    {
        cooldown += Time.deltaTime;
        if(cooldown>=1.5)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 10), 1, Random.Range(-5, 5));
            Instantiate(alvoPrefab,randomSpawnPosition,Quaternion.identity);
            cooldown = 0.0f;
           
        }
    }
}
