using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassLock.Kontrole
{
    class FlatButtonYes : Control
    {
        private SolidBrush borderBrush, textBrush;
        private Rectangle borderRectangle;
        private bool active = false;
        private StringFormat stringFormat = new StringFormat();

        public override Cursor Cursor { get; set; } = Cursors.Hand;
        public float BorderThickness { get; set; } = 4;

        public FlatButtonYes()
        {
            borderBrush = new SolidBrush(ColorTranslator.FromHtml("#31302b"));
            textBrush = new SolidBrush(ColorTranslator.FromHtml("#FFF"));

            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            this.Paint += FlatButton_Paint;
        }

        private void FlatButton_Paint(object sender, PaintEventArgs e)
        {
            borderRectangle = new Rectangle(0, 0, Width, Height);
            e.Graphics.DrawRectangle(new Pen(borderBrush, BorderThickness), borderRectangle);
            e.Graphics.DrawString(this.Text, this.Font, (active) ? textBrush : borderBrush, borderRectangle, stringFormat);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            base.BackColor = ColorTranslator.FromHtml("#5a5955");
            active = true;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            base.BackColor = ColorTranslator.FromHtml("#FFF");
            active = false;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            base.BackColor = ColorTranslator.FromHtml("#47BA26");
            active = true;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            base.BackColor = ColorTranslator.FromHtml("#FFF");
            active = false;
        }
    }
}


