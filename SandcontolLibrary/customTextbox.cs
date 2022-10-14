using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SandControlLibrary1
{
    public partial class customTextbox : UserControl
    {
        private Color bordercolor = Color.MediumSlateBlue;
        private int bordersize = 2;
        private bool underlinedStyle = false;
        public customTextbox()
        {
            InitializeComponent();
        }
        public Color Bordercolor
        {
            get
            {
                return bordercolor;
            }
            set
            {
                bordercolor = value;
                this.Invalidate();
            }
        }

        public int Bordersize
        {
            get
            {
                return bordersize;
            }
            set
            {
                bordersize = value;
                this.Invalidate();
            }
        }
        public bool UnderlinedStyle
        {
            get
            {
                return underlinedStyle;
            }
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }
        [Category("sand code advance")]
        public bool PasswordChar
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; }
        }
      
        public bool Enabled
        {
            get { return textBox1.Enabled; }
            set { textBox1.Enabled = value; }
        }
        public bool ShortcutsEnabled
        {
            get { return textBox1.ShortcutsEnabled; }
            set { textBox1.ShortcutsEnabled = value; }
        }
        public bool AcceptsReturn
        {
            get { return textBox1.AcceptsReturn; }
            set { textBox1.AcceptsReturn = value; }
        }
        public bool AcceptsTab
        {
            get { return textBox1.AcceptsTab; }
            set { textBox1.AcceptsTab = value; }
        }
        public bool HideSelection
        {
            get { return textBox1.HideSelection; }
            set { textBox1.HideSelection = value; }
        }
        public string PlaceholderText
            {
            get { return textBox1.PlaceholderText; }
            set { textBox1.PlaceholderText = value; }
            }
        public bool WordWrap
        {
            get { return textBox1.WordWrap; }
            set { textBox1.WordWrap = value; }
        }
        public int Maxlenth
        {
            get { return textBox1.MaxLength; }
            set { textBox1.MaxLength = value; }
        }
        [Category("sand code advance")]
        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }
        [Category("sand code advance")]
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }
        [Category("sand code advance")]
        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }
        [Category("sand code advance")]
        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();

            }
        }
        [Category("sand code advance")]
        public string texts
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            using (Pen penborder = new Pen(bordercolor, bordersize))
            {
                penborder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if (underlinedStyle)
                    graph.DrawLine(penborder, 0, this.Height - 1, this.Width, this.Height - 1);
                else
                    graph.DrawRectangle(penborder, 0, 0, this.Width - 0.5f, this.Height - 0.5f);
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtheight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtheight);
                textBox1.Multiline = false;
                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

      
    }
}
