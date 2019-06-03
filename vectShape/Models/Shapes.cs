using System.Collections.Generic;

namespace VectShape.Models
{
    public static class Constant
    {
        public const string add = "add";
        public const string del = "del";
        public const string rectangle = "rectangle";
        public const string ellipse = "ellipse";
    }
    public class Shapes
    {
        public List<Shape> Sh;
        public StateMems stateMems;

        public Shapes()
        {
            Sh = new List<Shape>();
            stateMems = new StateMems();
        }

        public void Add(Shape sh, bool flUndo)
        {
            if (Sh != null)
            {
                Sh.Add(sh);
                SelShapeAction(sh);
                if (!flUndo)
                {
                    stateMems.addState(sh, Constant.add);
                }
            }
        }
        public void Del(Shape sh, bool flUndo)
        {
            if (Sh.Count > 0)
            {
                Sh.Remove(sh);
                if (!flUndo)
                {
                    stateMems.addState(sh, Constant.del);
                }
            }
        }
        public void SelShapeAction(Shape sh)
        {
            if (sh != null)
            {
                foreach (var itemsh in Sh)
                {
                    itemsh.SelectShape = false;
                }
                sh.SelectShape = true;
            }
        }

        public void Clear()
        {
            Sh.Clear();
            stateMems.Clear();
        }
    }

    //класс фигура
    public class Shape
    {
        public int SizeX { get; set; }
        public int SizeY { get; set; }
        public int CoordX { get; set; }
        public int CoordY { get; set; }
        public string typeShape { get; set; }
        public bool SelectShape { get; set; }

        public Shape(int X, int Y, string typeshape)
        {
            SizeX = 40; //периметр фигуры
            SizeY = 30;
            CoordX = X;
            CoordY = Y;
            typeShape = typeshape;
            SelectShape = false;
        }
        // истина - если координаты находятся внутри фигуры и слева и сверху на размер фигуры
        public bool IsAboutAreaShape(int X, int Y)
        {
            if ((X >= CoordX - SizeX && X <= CoordX + SizeX) && (Y >= CoordY - SizeY && Y <= CoordY + SizeY))
            {
                return true;
            }
            return false;
        }

        // истина - если координаты находятся внутри фигуры
        public bool IsAreaShape(int X, int Y)
        {
            if ((X >= CoordX && X <= CoordX + SizeX) && (Y >= CoordY && Y <= CoordY + SizeY))
            {
                return true;
            }
            return false;
        }
    }
    public class StateMem
    {
        public Shape Sh;
        public string Action;
        public StateMem(Shape sh, string action)
        {
            Sh = sh;
            Action = action;
        }
    }
    //Хранитель состояний
    public class StateMems
    {
        Stack<StateMem> stUndo;
        Stack<StateMem> stRedo;
        public StateMems()
        {
            stUndo = new Stack<StateMem>();
            stRedo = new Stack<StateMem>();

        }
        public void addState(Shape sh, string action)
        {
            stUndo.Push(new StateMem(sh, action));
            stRedo.Clear();
        }
        public void Undo(Shapes sh_s)
        {
            if (stUndo.Count > 0)
            {
                StateMem state = stUndo.Pop();
                //удаленный объект восстанавливаем
                if (state.Action == Constant.del)
                {
                    sh_s.Add(state.Sh, true);
                }
                // добавленный объект удаляем
                if (state.Action == Constant.add)
                {
                    sh_s.Del(state.Sh, true);
                }
                //внести в стэк Redo отмененное действие
                stRedo.Push(state);
            }

        }
        public void Redo(Shapes sh_s)
        {
            if (stRedo.Count > 0)
            {
                StateMem state = stRedo.Pop();
                //повторяем удаление
                if (state.Action == Constant.del)
                {
                    sh_s.Del(state.Sh, true);
                }
                //повторяем добавление
                if (state.Action == Constant.add)
                {
                    sh_s.Add(state.Sh, true);
                }
                //заполнить стэк рэдо
                stUndo.Push(state);
            }
        }
        public void Clear()
        {
            stRedo.Clear();
            stUndo.Clear();
        }

    }
}
