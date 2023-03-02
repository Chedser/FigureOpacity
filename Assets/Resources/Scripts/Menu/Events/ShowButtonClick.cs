using UnityEngine;

public class ShowButtonClick : MonoBehaviour
{
    //�������� ���� ������, �� ������� ���������� ���� ������
    public void ToggleShowButton(GameObject showButton)
    {
        IToggleable itogglable = showButton.GetComponent<IToggleable>();
        itogglable.ToggleFigure();

    }
}
