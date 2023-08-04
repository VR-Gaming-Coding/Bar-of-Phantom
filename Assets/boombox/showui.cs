using UnityEngine;

public class ShowUIOnTouch : MonoBehaviour
{
    public Canvas uiElement; 
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("GameController")) 
        {
            uiElement.gameObject.SetActive(true); 
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("GameController"))
        {
            uiElement.gameObject.SetActive(false); 
        }
    }
}
