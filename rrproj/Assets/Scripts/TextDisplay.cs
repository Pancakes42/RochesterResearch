using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextDisplay : MonoBehaviour
{
    GameObject GameController;
    GameObject PlayerObject;
    Camera playerCamera;

    // Start is called before the first frame update
    void Start()
    {
        GameController = GameObject.FindGameObjectWithTag("GameController");
        PlayerObject = GameController.GetComponent<GameController>().PlayerChar;
        playerCamera = PlayerObject.GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
       transform.LookAt(transform.position + playerCamera.transform.rotation * Vector3.forward, playerCamera.transform.rotation * Vector3.up);

    }
}
