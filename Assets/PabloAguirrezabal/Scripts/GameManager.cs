using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.XR.ARFoundation.Samples;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public TMPro.TMP_Text textoSuperior;
    public GameObject prefabGris;
    public GameObject prefabRojo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Trackables")!=null && textoSuperior!=null)
        {
            textoSuperior.text=GameObject.Find("Trackables").transform.childCount.ToString();
        }
    }

    public void cleanScene()
    {
        Destroy(GameObject.FindGameObjectWithTag("ObjetoAR"));
    }

    public void changePrefab(TMPro.TMP_Dropdown ddvalue)
    {
        Debug.Log(ddvalue.value);
        GameObject go = null;
        if (ddvalue.value==0)
        {
            go=prefabGris;
        }
        else
        {
            go=prefabRojo;
        }
        GameObject.Find("XR Origin").GetComponent<PlaceOnPlaneOriginal>().changePrefab(go);
    }

    public void changeScene()
    {
        SceneManager.LoadScene(0);
    }
}
