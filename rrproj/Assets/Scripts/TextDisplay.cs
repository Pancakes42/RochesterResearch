using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextDisplay : MonoBehaviour
{
    GameObject GameController;
    GameObject PlayerObject;
    Camera playerCamera;
    MeshRenderer planeRenderer;
    Canvas textCanvas;

    // Start is called before the first frame update
    void Start()
    {
        GameController = GameObject.FindGameObjectWithTag("GameController");
        PlayerObject = GameController.GetComponent<GameController>().PlayerChar;
        playerCamera = PlayerObject.GetComponentInChildren<Camera>();
        planeRenderer = gameObject.GetComponentInChildren<MeshRenderer>();
        textCanvas = gameObject.GetComponentInChildren<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(PlayerObject.gameObject.transform.position, gameObject.transform.position);
        if (PlayerObject != null && dist <= 7)
        {
            planeRenderer.enabled = true;
            textCanvas.enabled = true;

            //5->3 dist the box will expand
            float specdist = dist - 3;
            if(specdist > 1)
            {
                gameObject.transform.localScale = new Vector3(1 / specdist, 1 / specdist, 1/specdist);
            }


            transform.LookAt(transform.position + playerCamera.transform.rotation * Vector3.forward, playerCamera.transform.rotation * Vector3.up);
        }
        else
        {
            planeRenderer.enabled = false;
            textCanvas.enabled = false;
        }
        
    }
}
