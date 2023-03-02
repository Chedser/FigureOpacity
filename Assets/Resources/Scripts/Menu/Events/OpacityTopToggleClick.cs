using UnityEngine;
using UnityEngine.UI;

public class OpacityTopToggleClick : MonoBehaviour
{
    /Передаем сюда чекбокс, на котором расположен этот скрипт
    public void ToggleOpacityClick(Toggle toggle)
    {
        IToggleable itogglable = toggle.gameObject.GetComponent<IToggleable>();
        itogglable.ToggleFigure(toggle);

    }
}
