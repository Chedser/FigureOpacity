using UnityEngine;

//Кнопка прозрачности
public class OpacityButtonClick : MonoBehaviour, IOpacityable
{
    public void SetOpacity(GameObject button)
    {
        button.GetComponent<IOpacityable>().SetOpacity();
    }

    public void SetOpacity()
    {
        throw new System.NotImplementedException();
    }

}
