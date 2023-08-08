using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class radialProcessBar : MonoBehaviour
{
    public Transform LoadingBar; 
    public Transform TextIndicator;
    public GameObject levelFailed;
    public Transform order;
    public Transform fail;
    [SerializeField] private float currentAmount;
    [SerializeField] private float speed;

    // Update is called once per frame
    void Update()
    {
        if (currentAmount < 100)
        {
            currentAmount += speed * Time.deltaTime;
        }
        else
        {
            TextIndicator.GetComponent<TextMeshProUGUI>().text = "You are wasting my time !";
            order.GetComponent<Image>().enabled = false;
            fail.GetComponent<Image>().enabled = true;
            levelFailed.SetActive(true);
        }
        LoadingBar.GetComponent<Image>().fillAmount = currentAmount / 100;
    }
}
