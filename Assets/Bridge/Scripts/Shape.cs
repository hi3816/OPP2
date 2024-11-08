using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EColor
{
    Red,
    Blue
}

public enum EShape
{
    Circle,
    Square
}

public class Shape : MonoBehaviour
{
    public EColor color;
    public EShape shape;

    private string name;

    private MeshRenderer meshR;

    private void Awake()
    {
        meshR = GetComponent<MeshRenderer>();
    }

    void Start()
    {
        switch (color)
        {
            case EColor.Red:
                meshR.material.color = Color.red;
                name += "[R]";
                break;
            case EColor.Blue:
                meshR.material.color = Color.blue;
                name += "[B]";
                break;
        }

        switch (shape)
        {
            case EShape.Square:
                name += " SpongeBob";
                break;
            case EShape.Circle:
                name += " Stone";
                break;
        }

        gameObject.name = this.name;
    }
}
