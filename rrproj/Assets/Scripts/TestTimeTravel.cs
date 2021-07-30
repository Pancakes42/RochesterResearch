using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TestTimeTravel : MonoBehaviour
{
    // Start is called before the first frame update


    GameController GameController;
    public GameObject RuinedArcade;
   public  GameObject AwsomeArcade;
   public GameObject TeleDest;

    void Start()
    {
        GameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);
    }
}
