using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenClosePanel : MonoBehaviour
{
    public GameObject gameObj;
    bool active = false;

    public void openAndClose()
    {
        if (active == true)
        {
            gameObject.SetActive(false);
            active = false;
        }
        else
        {
            gameObject.SetActive(true);
            active = true;
        }
    }
}
