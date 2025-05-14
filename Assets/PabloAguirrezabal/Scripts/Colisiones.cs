using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colisiones : MonoBehaviour
{

    public GameObject menuUI;
    private int sceneIndex=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ColisionEn " + other.gameObject.name);
        menuUI.SetActive(true);
        if (other.gameObject.name.Equals("Zona1"))
        {
            sceneIndex=1;
        }
        else
            sceneIndex=2;
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("ColisionEx " + other.gameObject.name);
        menuUI.SetActive(false);
    }

    public void changeScene()
    {
        SceneManager.LoadScene(sceneIndex);
    }


}
