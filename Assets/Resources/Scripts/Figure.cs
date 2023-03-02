using UnityEngine;



//������
public class Figure : MonoBehaviour
{
    public FigureType Type{get{return type;}}

    [SerializeField]
    FigureType type = FigureType.None;

    //�������� ������� �������� ������
    public string GetRussianNaming() {

        string figureType = "";

        switch (type){
            case FigureType.Cube: figureType = "���"; break;
            case FigureType.Cylinder: figureType = "�������"; break;
            case FigureType.Capsule: figureType = "�������"; break;
            case FigureType.Sphere: figureType = "�����"; break;
        }

        return figureType;

    }

}
