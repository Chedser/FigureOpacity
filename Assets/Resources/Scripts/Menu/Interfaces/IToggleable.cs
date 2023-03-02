

using UnityEngine;
using UnityEngine.UI;

//Интерфейс для переключения прозрачности объектов
public interface IToggleable
{
    public void ToggleFigure();
    public void ToggleFigure(Opacity opacity);
    public void ToggleFigure(Toggle go);
    public void ToggleFigure(bool enable);
}
