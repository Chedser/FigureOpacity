using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowButtonTopClick : MonoBehaviour
{
    
    //�������� ���� ������, �� ������� ���������� ���� ������
    public void ToggleShowButtonTop(GameObject showButtonTop)
    {
        IToggleable itogglable = showButtonTop.GetComponent<IToggleable>();
        itogglable.ToggleFigure();

    }

}
