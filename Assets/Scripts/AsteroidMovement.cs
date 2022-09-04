using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Scoring;

public class AsteroidMovement : MonoBehaviour
{
    public float speed;
    public bool stop = false;

    // Start is called before the first frame update
    void Start()
    {
        float h = 3;
        Vector3 d = Vector3.zero;
        d.x -= 1.0f;
        transform.Translate(d * speed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        if(stop == false)
        {
            Vector3 d = Vector3.zero;
            d.x -= 1.0f;
            transform.Translate(d * speed * Time.deltaTime);
        }
        else
        {
            Vector3 d = Vector3.zero;
            transform.Translate(d * speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch(collision.gameObject.tag)
        {
            case "Player":
                Destroy(collision.gameObject);
                //Scoring.Death();
                break;
            case "Asteroid":
                break;
            case "Laser":
                Destroy(collision.gameObject, .75f);
                stop = true;
                break;
            default:
                break;
        }
    }
}
