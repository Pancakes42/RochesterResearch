using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject PlayerChar;
    SceneManager sceneManager;

    Ray ray;
    RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        sceneManager = new SceneManager();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public SceneManager GetSceneManager()
    {
        return sceneManager;
    }

}
