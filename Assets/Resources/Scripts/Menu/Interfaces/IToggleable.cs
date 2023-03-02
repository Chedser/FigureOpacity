
//Интерфейс для переключения прозрачности объектов
using UnityEngine;
using UnityEngine.UI;

public interface IToggleable
{
    public void ToggleFigure();
    public void ToggleFigure(Opacity opacity);
    public void ToggleFigure(Toggle go);
    public void ToggleFigure(bool enable);
}
