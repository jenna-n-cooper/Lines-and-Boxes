using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class CircleButton : Button
{
    // Constructor to set the initial properties of the button
    public CircleButton()
    {
        // Set default size for the button (circular)
        this.Size = new Size(200, 200);  
        this.FlatStyle = FlatStyle.Flat;  // Remove the default button style
        this.BackColor = Color.White;     // Default background color
        this.ForeColor = Color.Black;     // Default text color
        this.FlatAppearance.BorderSize = 0; // Remove border
    }

 
    protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
    {
        GraphicsPath grPath = new GraphicsPath();
        grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
        this.Region = new System.Drawing.Region(grPath);
        base.OnPaint(e);
    }

    // add event for click
    protected override void OnClick(EventArgs e)
    {
        this.BackColor = Color.Black;  // Change to black when clicked
        base.OnClick(e);
    }

   
}