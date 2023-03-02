using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowButton : MonoBehaviour, IToggleable
{
    [SerializeField]
    GameObject showButton;
    [SerializeField]
    GameObject hideButton;
    [SerializeField]
    GameObject figureField;
    [SerializeField]
    GameObject showButtonTop;

    bool isClicked;

    void Awake() {
        showButtonTop = GameObject.Find("EyeButtonTop");
    }

    //Показываем/скрываем фигуру
    public void ToggleFigure()
    {
        hideButton.SetActive(isClicked);
        showButton.SetActive(!isClicked);
        figureField.GetComponentInParent<FigureField>().GetAttachedFigure().SetActive(isClicked);
        //showButtonTop.GetComponent<IToggleable>().ToggleFigure(isClicked);
        isClicked = !isClicked;

    }

    public void ToggleFigure(Opacity opacity)
    {
        throw new System.NotImplementedException();
    }

    public void ToggleFigure(Toggle go)
    {
        throw new System.NotImplementedException();
    }

    //Вызывается через EyeButtonTop
    public void ToggleFigure(bool eyeBtnTopIsClicked)
    {
        if ((eyeBtnTopIsClicked && isClicked) || (!eyeBtnTopIsClicked && !isClicked)){return;} 
        hideButton.SetActive(!eyeBtnTopIsClicked);
        showButton.SetActive(eyeBtnTopIsClicked);

        isClicked = !isClicked;
    }
}
