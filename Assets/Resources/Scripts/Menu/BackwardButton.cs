using UnityEngine;

//Кнопка отображения меню
public class BackwardButton : MonoBehaviour
{
    bool isClicked;
    [SerializeField]
    GameObject menu;

    public void TriggerMenu() {
        menu.SetActive(isClicked);
        isClicked = !isClicked;
    }

}
