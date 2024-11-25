namespace Lines_and_Boxes
{
    public partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        
      /* private void InitializeComponent()
        {
            circleButton1 = new CircleButton();
            SuspendLayout();
            // 
            // circleButton1
            // 
            circleButton1.BackColor = Color.Black;
            circleButton1.Location = new Point(12, 12);
            circleButton1.Name = "circleButton1";
            circleButton1.Size = new Size(40, 40);
            circleButton1.TabIndex = 1;
            circleButton1.Text = "circleButton1";
            circleButton1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 450);
            Controls.Add(circleButton1);
            Name = "Form1";
            Text = "Lines and Boxes";
            ResumeLayout(false);
        }
        */
        #endregion
        private CircleButton[,] CircleButtonArray;
        private CircleButton circleButton1;

        public Form1()
        {//change this so that we replace our new function with Initialize Component, keeping the same things
           // InitializeComponent();//figure out how to initialize CircleButtonArray in the implementation
            InitializeCircleButtonArray();
        }
    }
}
