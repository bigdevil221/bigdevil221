using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Text;

namespace day15
{
    public class TemperatureGauge : Control
    {
        private float actualTemperature = 45;
        private float setTemperature = 60;

        [Category("温度")]
        public float ActualTemperature
        {
            get => actualTemperature;
            set { actualTemperature = value; Invalidate(); }
        }

        [Category("温度")]
        public float SetTemperature
        {
            get => setTemperature;
            set { setTemperature = value; Invalidate(); }
        }

        [Category("温度")]
        public float MaxTemperature { get; set; } = 60;

        public TemperatureGauge()
        {
            DoubleBuffered = true;
            Size = new Size(230, 220);
            BackColor = Color.White;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            float radius = Math.Min(Width - 28, Height - 78) / 2f;
            PointF center = new PointF(Width / 2f, radius + 14);

            // 仪表为 270° 半圆：左下 -> 顶部 -> 右下
            const float startAngle = 140f;
            const float sweepAngle = 270f;

            // 外侧密集刻度
            for (int i = 0; i <= 50; i++)
            {
                float angle = startAngle + sweepAngle * i / 50f;
                bool mainTick = i % 10 == 0;

                float outer = radius;
                float inner = radius - (mainTick ? 13 : 7);

                using (Pen pen = new Pen(
                    Color.FromArgb(70, 70, 70),
                    mainTick ? 2.2f : 1.2f))
                {
                    g.DrawLine(pen,
                        PointAt(center, inner, angle),
                        PointAt(center, outer, angle));
                }
            }

            // 主刻度文字：按参考图固定为 0、1、5、2、3
            DrawScaleText(g, center, radius - 27, 140, "0");
            DrawScaleText(g, center, radius - 27, 200, "1");
            DrawScaleText(g, center, radius - 27, 270, "5");
            DrawScaleText(g, center, radius - 27, 330, "2");
            DrawScaleText(g, center, radius - 27, 400, "3");

            // 实际温度：深灰色长针
            float actualAngle = ValueToAngle(ActualTemperature);
            PointF actualEnd = PointAt(center, radius - 38, actualAngle);

            using (Pen pen = new Pen(Color.DimGray, 4.5f))
            {
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                g.DrawLine(pen, center, actualEnd);
            }

            // 设定温度：红色短针，和截图中的红色指示相近
            float setAngle = ValueToAngle(SetTemperature);
            PointF setEnd = PointAt(center, radius * 0.42f, setAngle);

            using (Pen pen = new Pen(Color.Red, 3f))
            {
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                g.DrawLine(pen, center, setEnd);
            }

            // 中心圆点
            g.FillEllipse(Brushes.DimGray, center.X - 8, center.Y - 8, 16, 16);
            g.DrawEllipse(Pens.White, center.X - 8, center.Y - 8, 16, 16);

            // 底部文字
            using (Font font = new Font("Microsoft YaHei", 10f))
            using (StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center
            })
            {
                float y = center.Y + radius * 0.58f;

                g.DrawString($"实际温度：{ActualTemperature:0}℃",
                    font, Brushes.Black, new RectangleF(0, y, Width, 25), sf);

                g.DrawString($"设定温度：{SetTemperature:0}℃",
                    font, Brushes.Black, new RectangleF(0, y + 24, Width, 25), sf);
            }
        }

        private float ValueToAngle(float value)
        {
            float max = MaxTemperature <= 0 ? 60 : MaxTemperature;
            float percent = Math.Max(0, Math.Min(1, value / max));

            return 140f + 270f * percent;
        }

        private static PointF PointAt(PointF center, float radius, float angle)
        {
            double rad = angle * Math.PI / 180.0;

            return new PointF(
                center.X + radius * (float)Math.Cos(rad),
                center.Y + radius * (float)Math.Sin(rad));
        }

        private static void DrawScaleText(
            Graphics g, PointF center, float radius, float angle, string text)
        {
            PointF p = PointAt(center, radius, angle);

            using (Font font = new Font("Arial", 10f, FontStyle.Bold))
            using (StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            })
            {
                g.DrawString(text, font, Brushes.Black, p, sf);
            }
        }
    }
    
}

