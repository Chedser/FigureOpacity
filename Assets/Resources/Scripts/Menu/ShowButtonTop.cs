using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowButtonTop : MonoBehaviour, IToggleable
{
    //��������� ��� ��������� 3D-�������
    [SerializeField]
    GameObject figureFields;
    //������ ������
    Figure[] figures;
    [SerializeField]
    GameObject showButton;
    [SerializeField]
    GameObject hideButton;

    bool isClicked;
    public void ToggleFigure()
    {
        hideButton.SetActive(isClicked);
        showButton.SetActive(!isClicked);
        isClicked = !isClicked;

        //����������/�������� ��� �������
        foreach (FigureField figureField in figureFields.GetComponentsInChildren<FigureField>()) 
        {
            figureField.GetAttachedFigure().SetActive(!isClicked);
            figureField.GetComponentInChildren<ShowButton>().ToggleFigure(isClicked);
        }

    }
    public void ToggleFigure(Opacity opacity)
    {
        throw new System.NotImplementedException();
    }

    public void ToggleFigure(Toggle go)
    {
        throw new System.NotImplementedException();
    }

    public void ToggleFigure(bool enable)
    {

        //������ EyeTop ������ � ������ �������� FigureField ������
        /*   if (isClicked && enable)
           {
               hideButton.SetActive(enable);
               showButton.SetActive(!enable);
           } 

        hideButton.SetActive(enable);
        showButton.SetActive(!enable);

        isClicked = !isClicked; */
    }
}
