using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class triggerCheck : MonoBehaviour
{
    public GameObject brick;
    GameObject brickclone;
    Rigidbody car;
    public bool triggered;
    float count;
    public static triggerCheck instance;
    GameObject[] bclone;
    int len;
    float s, r;

    float damage = 0;

    void Awake()
    {
        car = gameObject.GetComponent<Rigidbody>();
        
        triggered = false;
        bclone = GameObject.FindGameObjectsWithTag("ball");

        instance = this;
        
    }

    void Start()
    {
        len = bclone.Length;
        r = Random.Range(6, 8);
        s = Random.Range(4, 5);
    }

    void OnCollisionEnter(Collision col)
    {
        if (!triggered)
        {
            if (col.gameObject.name == "Car")
            {

                triggered = true;
                Destroy(brick, 2f);
                count = count + 1;
                //Debug.Log("Destroy"+ count);
                if(col.relativeVelocity.z >= 0)
                    damage = damage + count + col.relativeVelocity.z;
                Debug.Log(damage);
                //brick.AddExplosionForce(car.velocity.z,transform.position,5);

                foreach (GameObject target in bclone)
                {
                    //for (int i=0;i<len;i++) 
                    GameObject.Destroy(target, r);
                    triggered = true;

                }

                StartCoroutine(CreateWall());

                //Invoke("RespawnWall", 4);
            }
        }
    }

    void Update()
    {
        //bclone = GameObject.FindGameObjectsWithTag("ball");

     
    }


    IEnumerator CreateWall()
    {
        yield return new WaitForSeconds(s);

        if (triggered)
        {
            float m = Random.Range(car.position.x + 20, car.position.x + 40);
            float n = Random.Range(car.position.z + 10, car.position.z + 50);

            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 4; x++)
                {

                    //Instantiate(brick, new Vector3(m+x, 0.5f+y, n), Quaternion.identity);

                    brickclone = Instantiate(brick, new Vector3(8 + x, 0.5f + y, n), Quaternion.identity);
                }
            }

            triggered = false;
            //triggerCheck.triggered = false;
        }
    }





    /*
    IEnumerator RespawnWall()
    {
        yield return new WaitForSecondsRealtime(0.001f);

        Debug.Log("Coroutine");
            foreach (GameObject target in bclone)
        {
            //for (int i=0;i<len;i++) 
            GameObject.Destroy(target, 4f);
                

        }

    }   
*/
}