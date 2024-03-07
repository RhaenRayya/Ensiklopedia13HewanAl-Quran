using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ArabicSupport;
using UnityEngine.UI;

public class FixArabic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text = ArabicFixer.Fix(GetComponent<Text>().text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
