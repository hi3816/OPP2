using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExampleUI : MonoBehaviour
{
    public Text text;

    private void Start()
    {
        FindObjectOfType<PlayerLevel>().ui = this;
    }

    public void UpdateLevelUI(int level)
    {
        text.text = $"Level : {level}";
    }
}