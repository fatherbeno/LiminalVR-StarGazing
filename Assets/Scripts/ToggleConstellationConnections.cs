using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleConstellationConnections : MonoBehaviour
{
    public GameObject constellation;
    public GameObject connections;
    public GameObject buttonPanel;
    public GameObject textPanel;
    
    private float addScale = 0.025f;
    private float starSize = 0;

    private bool increaseSize = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (increaseSize == true)
        {
            buttonPanel.SetActive(false);

            constellation.gameObject.transform.localScale += new Vector3(addScale, addScale, addScale);
            starSize = starSize + addScale;

            if (starSize >= 2.5)
            {
                increaseSize = false;
                textPanel.SetActive(true);
            }
        }
    }

    public void constellationSelected()
    {
        increaseSize = true;
        connections.SetActive(true);
    }
}
