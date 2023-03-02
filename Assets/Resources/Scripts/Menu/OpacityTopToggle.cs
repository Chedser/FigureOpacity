using UnityEngine;
using UnityEngine.UI;

//Верхний чекбокс, который переключает прозрачность у всех 3D-объектов
public class OpacityTopToggle : MonoBehaviour, IToggleable
{
    //Контейнер где находятся 3D-объекты
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
        //Показываем/скрываем все объекты
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
