using UnityEngine;

public class CanvasController : MonoBehaviour
{
    private Canvas canvas;

    private void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
    }

/*    private void Update()
    {
        // 通过某种条件判断来控制Canvas的可见性
        if (ShouldShowCanvas())
        {
            canvas.enabled = true;
        }
        else
        {
            canvas.enabled = false;
        }
    }

    private bool ShouldShowCanvas()
    {
        // 在这里实现你的条件判断逻辑
        // 返回true时显示Canvas，返回false时隐藏Canvas
        return true;
    }*/
}
