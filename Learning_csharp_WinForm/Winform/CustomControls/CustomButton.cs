using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Learning_csharp_WinForm.Winform.CustomControls {
    public class CustomButton: Button {
        // Fields
        private int _borderSize;
        private int _borderRadius;
        private Color _borderColor;
        private Color _hoverForeColor;
        private Image _originalImage;
        private Image _normalImage;
        private Image _hoverImage;

        [Category("Custom Fields")]
        public int BorderSize {
            get => _borderSize;
            set {
                _borderSize = value;
                this.Invalidate();
            }
        }
        
        [Category("Custom Fields")]
        public int BorderRadius {
            get => _borderRadius;
            set {
                _borderRadius = value;
                this.Invalidate();
            }
        }
        
        [Category("Custom Fields")]
        public Color BorderColor {
            get => _borderColor;
            set {
                _borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Custom Fields")]
        public Color HoverForeColor {
            get => _hoverForeColor;
            set {
                _hoverForeColor = value;
                this.Invalidate();
            }
        }

        [Category("Custom Fields")]
        public Image NormalImage {
            get => _normalImage;
            set {
                _normalImage = value;
                this.Invalidate();
            }
        }

        [Category("Custom Fields")]
        public Image HoverImage {
            get => _hoverImage;
            set {
                _hoverImage = value;
                this.Invalidate();
            }
        }

        [Category("Custom Fields")]
        public Image OriginalImage {
            get => _originalImage;
            set => _originalImage = value;
        }

        // Constructor
        public CustomButton() {
            // Initialize fields with default value
            this.BorderSize = 0;
            this.BorderRadius = 5;
            this.BorderColor = Color.PaleVioletRed;

            // Some default value of other fields of Button
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.Margin = new Padding(0, 0, 0, 0);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
        }

        // Methods
        private GraphicsPath GetGraphicsPath(RectangleF rect, float radius) {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.StartFigure();
            graphicsPath.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            graphicsPath.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            graphicsPath.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            graphicsPath.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            graphicsPath.CloseFigure();
            return graphicsPath;
        }

        protected override void OnSizeChanged(EventArgs e) { 
            base.OnSizeChanged(e);
            int newSize = (int) (this.Height * 0.35);
            if (this.OriginalImage != null) {
                this.Image = new Bitmap(this.OriginalImage, new Size(newSize, newSize));
            }
            this.Width = this.Height;
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);

            if (BorderRadius > 0) { // Rrounded button
                using GraphicsPath pathSurface = GetGraphicsPath(rectSurface, BorderRadius);
                using GraphicsPath pathBorder = GetGraphicsPath(rectBorder, BorderRadius);
                using Pen penSurface = new Pen(this.Parent.BackColor, 2);
                using Pen penBorder = new Pen(this.BorderColor, this.BorderSize);
                penBorder.Alignment = PenAlignment.Inset;
                // Button surface
                this.Region = new Region(pathSurface);
                // Draw surface border for HD result
                e.Graphics.DrawPath(penSurface, pathSurface);

                // Button border 
                if (BorderSize > 0) {
                    // Draw control border
                    e.Graphics.DrawPath(penBorder, pathBorder);
                }
            } else { // Normal button
                // Button surface
                this.Region = new Region(rectSurface);

                // Button border 
                if (BorderSize > 0) {
                    using Pen penBorder = new Pen(this.BorderColor, this.BorderSize);
                    penBorder.Alignment = PenAlignment.Inset;
                    e.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e) {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += (sender, eventArgs) => {
                if (this.DesignMode) {
                    this.Invalidate();
                }    
            };
        }
    }
}
