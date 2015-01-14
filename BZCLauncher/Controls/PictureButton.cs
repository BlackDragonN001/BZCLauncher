using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace BZCLauncher.Controls
{
    public delegate void ButtonClickedDelegate();

    class PictureButton : Control
    {
        private Image mIdleImage = null;
        private Image mMousedOverImage = null;
        private Image mDownImage = null;

        private bool mIsPressed = false;
        private bool mIsHovered = false;

        private Point mTextOffset;

        // Set and get the up image
        public Image IdleImage
        {
            get
            {
                return mIdleImage;
            }
            set
            {
                mIdleImage = value;

                if (mIdleImage != null)
                    this.Size = new System.Drawing.Size(mIdleImage.Size.Width, mIdleImage.Size.Height);
            }
        }

        public Image DownImage
        {
            get
            {
                return mDownImage;
            }
            set
            {
                mDownImage = value;

                if (mDownImage != null)
                    this.Size = new System.Drawing.Size(mDownImage.Size.Width, mDownImage.Size.Height);
            }
        }

        public Image MousedOverImage
        {
            get
            {
                return mMousedOverImage;
            }
            set
            {
                mMousedOverImage = value;

                if (mMousedOverImage != null)
                    this.Size = new System.Drawing.Size(mMousedOverImage.Size.Width, mMousedOverImage.Size.Height);
            }
        }

        public Point TextOffset
        {
            get
            {
                return mTextOffset;
            }
            set
            {
                mTextOffset = value;
            }
        }

		protected override CreateParams CreateParams
		{
			get
			{
				const int WS_EX_TRANSPARENT = 0x20;
				CreateParams cp = base.CreateParams;
				cp.ExStyle |= WS_EX_TRANSPARENT;
				return cp;
			}
		}


	    public PictureButton()
	    {
			this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			this.SetStyle(ControlStyles.Opaque, true);
			this.SetStyle(ControlStyles.ResizeRedraw, true);
			this.BackColor = Color.Transparent;
	    }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            mIsPressed = true;
            this.Invalidate();
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            mIsPressed = false;
            this.Invalidate();
            base.OnMouseUp(e);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            mIsHovered = true;
            if (mMousedOverImage != null)
                this.Invalidate();
            base.OnMouseHover(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            mIsHovered = false;
            if (mMousedOverImage != null)
                this.Invalidate();
            base.OnMouseLeave(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Draw the down image if we're clicked
            if (mIsPressed && mDownImage != null)
                e.Graphics.DrawImage(mDownImage, 0, 0, mDownImage.Size.Width, mDownImage.Size.Height);
            // Draw the idle image if we're not hovered or clicked
            else if (mIdleImage != null && !mIsPressed && !mIsHovered)
                e.Graphics.DrawImage(mIdleImage, 0, 0, mIdleImage.Size.Width, mIdleImage.Size.Height);
            // Draw the hovered image otherwise
            else if (mMousedOverImage != null)
                 e.Graphics.DrawImage(mMousedOverImage, 0, 0, mMousedOverImage.Size.Width, mMousedOverImage.Size.Height);
            // If all else fails, draw the idle image
            else if (mIdleImage != null)
                e.Graphics.DrawImage(mIdleImage, 0, 0, mIdleImage.Size.Width, mIdleImage.Size.Height);

            if (this.Text.Length > 0)
            {
                SizeF size = e.Graphics.MeasureString(this.Text, this.Font);

                e.Graphics.DrawString(this.Text,
                    this.Font,
                    new SolidBrush(this.ForeColor),
                    ((this.ClientSize.Width - size.Width) / 2) + mTextOffset.X,
                    ((this.ClientSize.Height - size.Height) / 2) + mTextOffset.Y);
            }

            base.OnPaint(e);
        }
    }
}
