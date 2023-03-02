using System;
using UnityEngine;
using UnityEngine.UI;

//Чекбокс на элементе меню FigureField, где меняется прозрачность
public class FigureFieldToggle : MonoBehaviour, IToggleable
{

    //GameObject figureFieldsContainer;
    GameObject attachedFigure;
    public void ToggleFigure(Opacity opacity)
    {
        throw new System.NotImplementedException();
    }

    public void ToggleFigure()
    {
        throw new System.NotImplementedException();
    }

    //Изменение прозрачности объекта
    public void ToggleFigure(Toggle toggle){
        attachedFigure = toggle.gameObject.GetComponentInParent<FigureField>().GetAttachedFigure();
        
        //Выход, если фигура неактивна
        if (!attachedFigure.activeInHierarchy) { return; }
        Material mat = attachedFigure.GetComponent<Renderer>().material;
        Color color = mat.color;
        
        //Меняем прозрачность
        if (toggle.isOn)
        {
            color.a = Normalize(FiguresManager.currentOpacity);
        }
        else {color.a = 1;}
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

    public void ToggleFigure(bool enable)
    {
        throw new System.NotImplementedException();
    }
}
