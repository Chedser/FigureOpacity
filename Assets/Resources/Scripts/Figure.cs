using UnityEngine;



//Фигура
public class Figure : MonoBehaviour
{
    public FigureType Type{get{return type;}}

    [SerializeField]
    FigureType type = FigureType.None;

    //Получить русское название фигуры
    public string GetRussianNaming() {

        string figureType = "";

        switch (type){
            case FigureType.Cube: figureType = "Куб"; break;
            case FigureType.Cylinder: figureType = "Цилиндр"; break;
            case FigureType.Capsule: figureType = "Капсула"; break;
            case FigureType.Sphere: figureType = "Сфера"; break;
        }

        return figureType;

    }

}
