using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lines_and_Boxes
{
    public partial class Form1
    {
        private void InitializeCircleButtonArray()
        {
            int x = 5;
            int y = 5;
            int spacing = 5;
            string buttonName = "circleButton";
            CircleButton[,] CircleButtonArray = new CircleButton[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    buttonName = "CircleButton" + i.ToString() + j.ToString();
                    CircleButtonArray[i, j] = new CircleButton();
                    CircleButtonArray[i, j].BackColor = Color.Black;
                    CircleButtonArray[i, j].Location = new Point(10 * i + spacing, 10 * j + spacing);
                    circleButton1.Name = "circleButton" + i.ToString() + j.ToString();
                    circleButton1.Size = new Size(40, 40);
                    circleButton1.TabIndex = 1;
                }
            }
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 450);
            Controls.Add(circleButton1);
            Name = "Form1";
            Text = "Lines and Boxes";
            ResumeLayout(false);
        }
    }
}
