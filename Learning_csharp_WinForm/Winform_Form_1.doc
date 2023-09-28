namespace Learning_csharp_WinForm {
    public partial class Winform_Form_1: Form {
        private Size main_panel_cache_size;
        private List<Button> main_menu_buttons = new List<Button>();

        public Winform_Form_1() {
            InitializeComponent();
            main_panel_cache_size = this.Size;
            main_menu_buttons.Add(this.ProductManagement);
            main_menu_buttons.Add(this.WorkPlace);
            main_menu_buttons.Add(this.DataQuery);
            main_menu_buttons.Add(this.EventLog);
            main_menu_buttons.Add(this.Configuration);
            main_menu_buttons.Add(this.UserInfo);
            main_menu_buttons.Add(this.Exit);
        }

        private void Winform_Form_1_Resize(object sender, EventArgs e) {
            this.mainPanel.Size += this.Size - main_panel_cache_size;
            main_panel_cache_size = this.mainPanel.Parent.Size;
        }

        private void mainPanel_Resize(object sender, EventArgs e) {
            this.mainMenuPanel.Width = this.mainPanel.Width;
            this.mainMenuPanel.Height = (int) (this.mainPanel.Height * 0.13);
            this.mainContentPanel.Height = this.mainPanel.Height - this.mainMenuPanel.Height;
            this.mainContentPanel.Width = this.mainPanel.Width;
        }

        private void mainMenuPanel_Resize(object sender, EventArgs e) {
            foreach (var menu_button in main_menu_buttons) {
                menu_button.Width = menu_button.Height = this.mainMenuPanel.Height - 2;
            }
        }

        private void mainContentPanel_Paint(object sender, PaintEventArgs e) {
            FlowLayoutPanel obj = sender as FlowLayoutPanel;
            e.Graphics.Clear(obj.BackColor);
            e.Graphics.DrawRectangle(new Pen(ColorTranslator.FromHtml("#3F3F3F"), 10), new Rectangle(110, 110, (int) (obj.Width * 0.3), (int) (obj.Height * 0.3)));
        }
    }
}
