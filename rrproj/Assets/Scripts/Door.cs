using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    GameController gamecontroller;
    GameObject player;

    bool opening = false;
    float timer = 0f;
    Vector3 objScale;
    Vector3 origin;
    

    // Start is called before the first frame update
    void Start()
    {
        gamecontroller = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        player = gamecontroller.PlayerChar;
        objScale = gameObject.GetComponent<BoxCollider>().size;
    }

    // Update is called once per frame
    void Update()
    {
        if (opening)
        {
            
            transform.position = new Vector3(transform.position.x - .004f , transform.position.y, transform.position.z);
            if(Vector3.Distance(origin,transform.position) >= 5)
            {
                opening = false;
            }
        }
    }

    private void OnMouseDown()
    {
        if(Vector3.Distance(transform.position,player.transform.position) <= 2f)
        {
            opening = true;
            origin = gameObject.transform.position;
        }
    }
}
