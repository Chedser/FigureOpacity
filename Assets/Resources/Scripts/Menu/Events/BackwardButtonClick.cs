using UnityEngine;

public class BackwardButtonClick : MonoBehaviour
{
   //Передаем сюда объект, на котором скрипт
    public void Click(GameObject btn) {
        btn.GetComponent<BackwardButton>().TriggerMenu();
    }
}
