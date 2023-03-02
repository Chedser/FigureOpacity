using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpacityButton : MonoBehaviour, IOpacityable
{
    public bool IsOpacity { set { isOpacity = value; } }

    [SerializeField]
    public Opacity opacity = Opacity.NONE; //������� ��������������
    [SerializeField]
    bool isOpacity; //���� ��������� ��������������

    [SerializeField]
    public GameObject defaultImage;
    [SerializeField]
    public GameObject activeImage;

    void Awake() {
        if (opacity == Opacity.FIVE) { isOpacity = true; }
    
    }

    public void SetOpacity(GameObject go)
    {
        throw new System.NotImplementedException();
    }

    //��������� ������������
    public void SetOpacity(){
        //�������������� ��� �����������
        if (isOpacity) { return; } 
        
        defaultImage.SetActive(false);
        activeImage.SetActive(true);
        isOpacity = true;
        FiguresManager.currentOpacity = opacity;
        GameObject[] opacityButtons = GameObject.FindGameObjectsWithTag("OpacityButton");

        //������������ ������
        foreach (GameObject button in opacityButtons)
        {
             if (button == this.gameObject) { continue; }
             //��������� ���� ������������
             button.GetComponent<OpacityButton>().IsOpacity = false;
             button.GetComponent<OpacityButton>().defaultImage.SetActive(true);
             button.GetComponent<OpacityButton>().activeImage.SetActive(false);

         }

        FigureField[] figureFieldContainer = 
            GameObject.Find("FigureFields").GetComponentsInChildren<FigureField>();

        //��������� ������������ ��������
        foreach (FigureField figureField in figureFieldContainer)
        {
            figureField.ToggleFigure(opacity);
        } 

    }

}


