using System.Windows.Forms;

namespace StoreInventoryPos
{
    public class ThemedForm : Form
    {
        protected override void OnLoad(EventArgs e)
        {
            AppTheme.Apply(this);
            base.OnLoad(e);
        }
    }
}
