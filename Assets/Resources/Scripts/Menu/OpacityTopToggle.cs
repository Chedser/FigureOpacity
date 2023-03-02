using UnityEngine;
using UnityEngine.UI;

//������� �������, ������� ����������� ������������ � ���� 3D-��������
public class OpacityTopToggle : MonoBehaviour, IToggleable
{
    //��������� ��� ��������� 3D-�������
    [SerializeField]
    GameObject figureFields;
    public void ToggleFigure()
    {
        throw new System.NotImplementedException();
    }

    public void ToggleFigure(Opacity opacity)
    {
        throw new System.NotImplementedException();
    }

    public void ToggleFigure(Toggle toggle)
    {
        //����������/�������� ��� �������
        foreach (FigureField figureField in figureFields.GetComponentsInChildren<FigureField>())
        {
            figureField.ToggleFigure(toggle.isOn);
        } 

    }

    public void ToggleFigure(bool opacityTopToggle)
    {
        /* if ((opacityTopToggle && isClicked) || (!opacityTopToggle && !isClicked)) { return; }

        isClicked = !isClicked; */
    }
}
