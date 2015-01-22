using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIController : MonoBehaviour
{
    Text textUI;

    void Start()
    {
        textUI = GetComponent<Text>();
    }

    void Update()
    {

        textUI.text = "Health: " + GameController.controller.Health;
    }
}
