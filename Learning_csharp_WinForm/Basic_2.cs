namespace Learning_csharp_WinForm {
    internal static class Basic_2 {
        static void Main() {
            //// 1. 事件拥有者（event source）
            //Form form = new Form();
            //// 3. 事件响应者（订阅者：event subscriber）
            //Controller controller = new Controller(form);
            //form.ShowDialog();

            //// 1. 事件拥有者 and 3. 事件响应者
            //MyForm myForm = new MyForm();
            //// 2. 事件：Click
            //// 5. 事件绑定：+=
            //myForm.Click += myForm.Action;
            //myForm.ShowDialog();

            //MyForm2 myForm2 = new MyForm2();
            //myForm2.ShowDialog();

        }
    }

    class Controller {
        private Form form;
        public Controller(Form form) {
            if (form != null) {
                this.form = form;
                // 2. 事件（event）：Click
                // 5. 事件订阅（subscribe）：+=
                this.form.Click += this.FormClicked;
            }
        }

        // 4. 事件处理器（event handler）
        private void FormClicked(object? sender, EventArgs e) {
            this.form.Text = DateTime.Now.ToString();
        }
    }

    class MyForm: Form {
        // 4. 事件处理器
        internal void Action(object? sender, EventArgs e) {
            this.Text = DateTime.Now.ToString();
        }
    }

    class MyForm2: Form { // 事件响应者
        private TextBox textBox;
        // 事件拥有者
        private Button button;

        public MyForm2() {
            this.textBox = new TextBox();
            this.button = new Button();
            this.button.Text = "say hello";
            this.button.Top = 30;

            this.Controls.Add(this.textBox);
            this.Controls.Add(this.button);

            // 事件、事件绑定（订阅）
            this.button.Click += this.ButtonClicked;
        }

        // 事件处理器
        private void ButtonClicked(object? sender, EventArgs e) {
            this.textBox.Text = "Hello world!";
        }
    }



}