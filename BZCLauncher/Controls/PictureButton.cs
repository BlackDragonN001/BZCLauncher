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
        private Image mUpImage = null;
        private Image mDownImage = null;

        private bool mIsPressed = false;

        // Set and get the up image
        public Image UpImage
        {
            get
            {
                return mUpImage;
            }
            set
            {
                mUpImage = value;

                this.Size = new System.Drawing.Size(mUpImage.Width, mUpImage.Height);
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
            }
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

        protected override void OnPaint(PaintEventArgs e)
        {
            if (mIsPressed && mDownImage != null)
                e.Graphics.DrawImage(mDownImage, 0, 0);
            else if (mUpImage != null)
                e.Graphics.DrawImage(mUpImage, 0, 0);

            if (this.Text.Length > 0)
            {
                SizeF size = e.Graphics.MeasureString(this.Text, this.Font);

                e.Graphics.DrawString(this.Text,
                    this.Font,
                    new SolidBrush(this.ForeColor),
                    (this.ClientSize.Width - size.Width) / 2,
                    (this.ClientSize.Height - size.Height) / 2);
            }

            base.OnPaint(e);
        }
    }
}
