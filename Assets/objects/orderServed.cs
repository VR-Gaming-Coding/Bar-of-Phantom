using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class orderServed : MonoBehaviour
{
    public Transform order;
    public Transform done;
    public Transform TextIndicator;

    // Start is called before the first frame update

    public void finish()
    {
        TextIndicator.GetComponent<TextMeshProUGUI>().text = "Love it !";
        order.GetComponent<Image>().enabled = false;
        done.GetComponent<Image>().enabled = true;
    }
}
