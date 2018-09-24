using System;

namespace Lab3
{
    abstract class Figure:IComparable
    {
        // Возвращает:
        //     Значение, указывающее, каков относительный порядок сравниваемых объектов.
        //     Возвращаемые значения представляют следующие результаты сравнения. Значение
        //     Значение Меньше нуля Данный экземпляр в порядке сортировки следует перед
        //     obj. Zero Данный экземпляр имеет ту же позицию в порядке сортировки, что
        //     и объект obj. Больше нуля. Данный экземпляр в порядке сортировки следует
        //     после obj.
        //
/// <summary>
/// Возвращает площадь фигуры
/// </summary>
/// <returns>Площадь</returns>
        abstract public double GetArea();
        public int CompareTo(object o)
        {
            Figure obj = (Figure)o;
            if (this.GetArea() > obj.GetArea()) return -1;
            else if (this.GetArea() < obj.GetArea()) return 1;
            else return 0;
        }
    }
}
