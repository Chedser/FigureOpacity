using System;
using UnityEngine;
using UnityEngine.UI;

//������� �� �������� ���� FigureField, ��� �������� ������������
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

    //��������� ������������ �������
    public void ToggleFigure(Toggle toggle){
        attachedFigure = toggle.gameObject.GetComponentInParent<FigureField>().GetAttachedFigure();
        
        //�����, ���� ������ ���������
        if (!attachedFigure.activeInHierarchy) { return; }
        Material mat = attachedFigure.GetComponent<Renderer>().material;
        Color color = mat.color;
        
        //������ ������������
        if (toggle.isOn)
        {
            color.a = Normalize(FiguresManager.currentOpacity);
        }
        else {color.a = 1;}
        mat.color = color; 

    }

    //�������������� �������� �������������� � �������� 0-1
    float Normalize(Opacity opacity)
    {
        string val = ((opacity - Opacity.ONE) / ((float)(Opacity.FIVE - Opacity.ONE))).ToString();

        double d = Double.Parse(val);
        int decimals = 2;
        float result = (float)(Math.Floor(d * Math.Pow(10, decimals)) / Math.Pow(10, decimals));
        return result;
    }

    //���������� ����� OpacityTopToggle
    public void ToggleFigure(bool enable)
    {
 
    }
}
