using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwapObject : MonoBehaviour
{
    public GameObject parentObject;
    public Text textName;

    public int indexActiveObject;

    public GameObject parentButton, panelNama;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActiveFirstObject()
    {
        parentObject.transform.GetChild(indexActiveObject).gameObject.SetActive(true); //mengaktifkan object

        parentButton.SetActive(true); //mengaktifkan ui
        panelNama.SetActive(true); //mengaktifkan ui
        textName.text = parentObject.transform.GetChild(indexActiveObject).name; //update ui text name
    }

    public void ButtonChangeObjectActive(int indexObject)
    {
        if (indexActiveObject != indexObject)
        {
            parentObject.transform.GetChild(indexActiveObject).gameObject.SetActive(false);
            indexActiveObject = indexObject;

            parentObject.transform.GetChild(indexActiveObject).gameObject.SetActive(true);
            textName.text = parentObject.transform.GetChild(indexActiveObject).name;
        }
    }
}
