using System;

using System.Drawing;

using System.Windows.Forms;
using VectShape.Models;

namespace VectShape
{
    public partial class Form1 : Form
    {
        Shapes Sh = new Shapes();

        private bool flAddShape;
        Cursor panelCursor;
        private string typeshape;

        public Form1()
        {
            InitializeComponent();
        }
        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            if (flAddShape)
            {
                bool foolarea = false;
                foreach (var sh in Sh.Sh)
                {
                    if (sh.IsAboutAreaShape(e.X, e.Y))
                    {
                        foolarea = true;
                    }
                    sh.SelectShape = false;
                }
                if (!foolarea)
                {
                    Sh.Add(new Shape(e.X, e.Y, typeshape), false);
                    flAddShape = false;
                    panelCursor = Cursors.Default;
                    Cursor = panelCursor;
                }
            }
            else
            {
                foreach (var sh in Sh.Sh)
                {
                    if (sh.IsAreaShape(e.X, e.Y))
                    {
                        sh.SelectShape = true;
                    }
                    else
                    {
                        sh.SelectShape = false;
                    }
                }
            }
            //сбрасываем кнопки на ненажатое состояние
            toolStripButtonShape1.Checked = false;
            toolStripButtonShape2.Checked = false;
            panel2.Invalidate();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = panelCursor;
            // если установлен признак добавления фигуры на форму
            //    меняем курсор  показывая, что тыцкать мышкой непосредственно в область
            //    и вокруг (слева и сверху) уже добавленной фигуры нельзя
            if (flAddShape)
            {
                foreach (var item in Sh.Sh)
                {
                    if (item.IsAboutAreaShape(e.X, e.Y))
                    {
                        Cursor = Cursors.No;
                    }
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (var sh in Sh.Sh)
            {
                if (sh.typeShape == Constant.rectangle)
                {
                    g.DrawRectangle(new Pen(Color.Black), sh.CoordX, sh.CoordY, sh.SizeX, sh.SizeY);
                }
                else if (sh.typeShape == Constant.ellipse)
                {
                    g.DrawEllipse(new Pen(Color.Black), sh.CoordX, sh.CoordY, sh.SizeX, sh.SizeY);

                }
                if (sh.SelectShape)
                {
                    g.DrawRectangle(new Pen(Color.Blue), sh.CoordX - 2, sh.CoordY - 2, sh.SizeX + 4, sh.SizeY + 4);
                }
            }
        }

        private void toolStripButtonShape1_Click(object sender, EventArgs e)
        {
            AddStateShapetoForm(Constant.rectangle);
        }

        private void toolStripButtonShape2_Click(object sender, EventArgs e)
        {
            AddStateShapetoForm(Constant.ellipse);
        }

        private void AddStateShapetoForm(string typesh)
        {
            flAddShape = true;
            typeshape = typesh;
            panelCursor = Cursors.Cross;
        }

        private void toolStripButtonShapeDel_Click(object sender, EventArgs e)
        {
            foreach (var sh in Sh.Sh)
            {
                if (sh.SelectShape)
                {
                    Sh.Del(sh, false);
                    panel2.Invalidate();
                    break;
                }
            }
        }

        //создаем новый документ
        //очищаем список объектов на форме 
        //очищаем стэки Undo и Redo
        private void toolStripButtonNewdoc_Click(object sender, EventArgs e)
        {
            Sh.Clear();
            panel2.Invalidate();
        }

        private void toolStripButtonUndo_Click(object sender, EventArgs e)
        {
            Sh.stateMems.Undo(Sh);
            panel2.Invalidate();
        }

        private void toolStripButtonRedo_Click(object sender, EventArgs e)
        {
            Sh.stateMems.Redo(Sh);
            panel2.Invalidate();
        }
    }
}
