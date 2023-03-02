using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FiguresManager : MonoBehaviour
{

    const int MAX_FIGURES_COUNT = 7; //������������ ���������� ����� � �����

    public static Opacity currentOpacity; // ������� ��������������

    //��������� � ���� �����
    [SerializeField]
    GameObject figureFieldContainer;
    //��������� �����-��������
    [SerializeField]
    GameObject figuresContainer;

    // Start is called before the first frame update
    void Awake()
    {
        //���������� � Awake ��� ���������� ������������ �������� � ������ �������� ����� �������
        currentOpacity = Opacity.FIVE;
        //������� �������� ����
        CreateMenuFields();
    }

    // �������� ��������� ���� �����
    void CreateMenuFields() {

        Figure[] figures = GetFiguresInScene();

        if (figures.Length == 0 || figures.Length > MAX_FIGURES_COUNT) { return; }

        for (int i = 0; i < figures.Length; i++) {
            Figure figure = figures[i].GetComponent<Figure>();
            string russianNaming = figures[i].GetRussianNaming(); //������� �������� ������

            //���� ������ � ����
            Transform figureFieldTransform = figureFieldContainer.transform.GetChild(i);
            //������������� ������� ����� � ����
            figureFieldTransform.GetComponentInChildren<Text>().text = russianNaming;
            figureFieldTransform.gameObject.SetActive(true);

            //������ ������ ������ ���� ���� ��� ������
            FigureField figureFieldScript = figureFieldTransform.gameObject.GetComponent<FigureField>();
            figureFieldScript.AttachFigure(figure.gameObject);

        }

    }

    //�������� ��� ������ � �����
    Figure[] GetFiguresInScene() {

        return figuresContainer.GetComponentsInChildren<Figure>();

    }

}
