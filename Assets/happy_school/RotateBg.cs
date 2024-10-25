using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBg : MonoBehaviour
{
    public GameObject DateButton;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("TurnOff", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, -0.1f);
    }
    public void TurnOff()
    {
        DateButton.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
