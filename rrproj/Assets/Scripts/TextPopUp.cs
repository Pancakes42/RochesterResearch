using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextPopUp : MonoBehaviour
{

    public GameObject PopBox;
    public string Text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnMouseDown()
    {
        GameObject pbox = Instantiate(PopBox, transform, true);
        pbox.GetComponent<TextDisplay>().SetText(Text);
    }
}
