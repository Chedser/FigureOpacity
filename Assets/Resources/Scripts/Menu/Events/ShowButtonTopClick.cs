using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowButtonTopClick : MonoBehaviour
{
    
    //Передаем сюда кнопку, на которой расположен этот скрипт
    public void ToggleShowButtonTop(GameObject showButtonTop)
    {
        IToggleable itogglable = showButtonTop.GetComponent<IToggleable>();
        itogglable.ToggleFigure();

    }

}
