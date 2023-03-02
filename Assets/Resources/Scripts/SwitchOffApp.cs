using UnityEngine;

//Выключение приложения при нажатии на Esc
public class SwitchOffApp : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) { Application.Quit(); }
    }
}
