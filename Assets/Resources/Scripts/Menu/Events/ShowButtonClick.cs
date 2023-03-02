using UnityEngine;

public class ShowButtonClick : MonoBehaviour
{
    //Передаем сюда кнопку, на которой расположен этот скрипт
    public void ToggleShowButton(GameObject showButton)
    {
        IToggleable itogglable = showButton.GetComponent<IToggleable>();
        itogglable.ToggleFigure();

    }
}
