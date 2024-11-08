using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLevel : MonoBehaviour
{
    float time = 0f;

    public ExampleUI ui;

    void Update()
    {
        if (ui == null) return;
        time += Time.deltaTime;
        ui.UpdateLevelUI((int)time / 2);
    }
}
