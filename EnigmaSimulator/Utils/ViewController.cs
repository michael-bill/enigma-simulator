using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnigmaSimulator.Utils
{
    class ViewController
    {
        public static void ViewStylizer(Form form)
        {
            form.BackColor = Color.White;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MaximizeBox = false;
            form.Icon = (Icon)Properties.Resources.ResourceManager.GetObject("enigmaico");
            form.StartPosition = FormStartPosition.CenterScreen;
            foreach (Control control in form.Controls)
            {
                if (control is Button)
                {
                    ((Button)control).FlatStyle = FlatStyle.Flat;
                    ((Button)control).Cursor = Cursors.Hand;
                    ((Button)control).BackColor = Color.White;
                }
                control.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            }
        }
    }
}
