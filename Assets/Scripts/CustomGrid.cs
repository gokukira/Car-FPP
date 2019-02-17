using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomGrid : MonoBehaviour
{

    //public GameObject Wall;
    public GameObject brick;
    public GameObject brickclone;
    public Rigidbody car;
    bool r;
    
 
    void Awake()
    {
        r = false; 
        CreateWall();
    }
    
     
    void Update()
    {
        //r = triggerCheck.triggered;
        r = triggerCheck.instance.triggered;
        //r = brick.GetComponent<triggerCheck>().triggered;

        if (r)
        {
            Debug.Log("Create");
            CreateWall();
        }
    }
    

    void CreateWall()
    { 
        float m = Random.Range(car.position.x + 20, car.position.x + 40);
        float n = Random.Range(car.position.z + 10, car.position.z + 50);

        for (int y = 0; y< 4; y++)
        {
            for (int x = 0; x< 4; x++)
            {

                //Instantiate(brick, new Vector3(m+x, 0.5f+y, n), Quaternion.identity);

                brickclone=Instantiate(brick, new Vector3(8+x, 0.5f+y, n), Quaternion.identity);
            }
        }

        //brick.GetComponent<triggerCheck>().triggered = false;
        //triggerCheck.triggered = false;
        r = false;
    }


 
}
