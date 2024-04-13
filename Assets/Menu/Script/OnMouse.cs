using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouse : MonoBehaviour
{

    public void PointerEnter()
    {
        transform.localScale = new Vector2(1.4f, 1.4f);
    }

    public void PointerExit()
    {
        transform.localScale = new Vector2(1.0f, 1.0f);
    }
}
