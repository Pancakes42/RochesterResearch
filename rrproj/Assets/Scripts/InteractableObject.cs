using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{

    GameObject gameController;
    GameObject playerController;

    

    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController");
        playerController = gameController.GetComponent<GameController>().PlayerChar;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public virtual void Activate() 
    {
        Debug.Log("Baseline Activate");
    }

    private void OnMouseDown()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
    }

}
