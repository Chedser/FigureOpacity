using System;
using UnityEngine;
using UnityEngine.UI;

public class FigureField : MonoBehaviour,IToggleable
{   
    //Присоединенная фигура к полю меню
    [SerializeField]
    GameObject attachedFigure;
    Toggle toggle; //Чекбокс

    public void AttachFigure(GameObject figure) {
        toggle = GetComponentInChildren<Toggle>();
        attachedFigure = figure;
    }

    
    public void ToggleFigure(Opacity opacity) {

        Material mat = attachedFigure.GetComponent<Renderer>().material;
        Color color = mat.color;

        if (toggle.isOn)
        {

            color.a = Normalize(opacity);


        }
        else {
            color.a = 1;
        }

        mat.color = color;

    }

    //Преобразование значения непрозрачности в диапазон 0-1
    float Normalize(Opacity opacity) 
    {
        string val = ((opacity - Opacity.ONE) / ((float)(Opacity.FIVE - Opacity.ONE))).ToString();

        double d = Double.Parse(val);
        int decimals = 2;
        float result = (float)(Math.Floor(d * Math.Pow(10, decimals)) / Math.Pow(10, decimals));
        return result;
    }

    public GameObject GetAttachedFigure() {
        return attachedFigure;
    }

    public void ToggleFigure()
    {
        throw new NotImplementedException();
    }

    public void ToggleFigure(Toggle go)
    {
        throw new NotImplementedException();
    }

    //Вызывается через кнопку переключения прозрачности наверху сцены
    public void ToggleFigure(bool toggleEnabled)
    {

        //Если кнопка ToggleOpacityTop нажата и текущая кнопка не нажата
        if (!toggle.isOn && toggleEnabled)
        {
            toggle.isOn = toggleEnabled;
            ToggleFigure(FiguresManager.currentOpacity);
        }
        
        else if (toggle.isOn && !toggleEnabled)
        {
            toggle.isOn = false;
            ToggleFigure(FiguresManager.currentOpacity);

        }

    }

}
