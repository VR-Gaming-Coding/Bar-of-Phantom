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
        // ͨ��ĳ�������ж�������Canvas�Ŀɼ���
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
        // ������ʵ����������ж��߼�
        // ����trueʱ��ʾCanvas������falseʱ����Canvas
        return true;
    }*/
}
