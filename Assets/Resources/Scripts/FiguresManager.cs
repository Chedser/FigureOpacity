using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FiguresManager : MonoBehaviour
{

    const int MAX_FIGURES_COUNT = 7; //Максимальное количество фигур в сцене

    public static Opacity currentOpacity; // Текущая непрозрачность

    //Контейнер в меню фигур
    [SerializeField]
    GameObject figureFieldContainer;
    //Контейнер фигур-объектов
    [SerializeField]
    GameObject figuresContainer;

    // Start is called before the first frame update
    void Awake()
    {
        //Вызывается в Awake для обновления статического значения в случае перехода между сценами
        currentOpacity = Opacity.FIVE;
        //Создать элементы меню
        CreateMenuFields();
    }

    // Создание элементов меню фигур
    void CreateMenuFields() {

        Figure[] figures = GetFiguresInScene();

        if (figures.Length == 0 || figures.Length > MAX_FIGURES_COUNT) { return; }

        for (int i = 0; i < figures.Length; i++) {
            Figure figure = figures[i].GetComponent<Figure>();
            string russianNaming = figures[i].GetRussianNaming(); //Русское название фигуры

            //Поле фигуры в меню
            Transform figureFieldTransform = figureFieldContainer.transform.GetChild(i);
            //Устанавливаем русский текст в поле
            figureFieldTransform.GetComponentInChildren<Text>().text = russianNaming;
            figureFieldTransform.gameObject.SetActive(true);

            //Скрипт логики работы поля меню для фигуры
            FigureField figureFieldScript = figureFieldTransform.gameObject.GetComponent<FigureField>();
            figureFieldScript.AttachFigure(figure.gameObject);

        }

    }

    //Получить все фигуры в сцене
    Figure[] GetFiguresInScene() {

        return figuresContainer.GetComponentsInChildren<Figure>();

    }

}
