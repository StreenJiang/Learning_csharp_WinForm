namespace Learning_csharp_WinForm {
    internal static class Basic_2 {
        static void Main() {
            //// 1. �¼�ӵ���ߣ�event source��
            //Form form = new Form();
            //// 3. �¼���Ӧ�ߣ������ߣ�event subscriber��
            //Controller controller = new Controller(form);
            //form.ShowDialog();

            //// 1. �¼�ӵ���� and 3. �¼���Ӧ��
            //MyForm myForm = new MyForm();
            //// 2. �¼���Click
            //// 5. �¼��󶨣�+=
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
                // 2. �¼���event����Click
                // 5. �¼����ģ�subscribe����+=
                this.form.Click += this.FormClicked;
            }
        }

        // 4. �¼���������event handler��
        private void FormClicked(object? sender, EventArgs e) {
            this.form.Text = DateTime.Now.ToString();
        }
    }

    class MyForm: Form {
        // 4. �¼�������
        internal void Action(object? sender, EventArgs e) {
            this.Text = DateTime.Now.ToString();
        }
    }

    class MyForm2: Form { // �¼���Ӧ��
        private TextBox textBox;
        // �¼�ӵ����
        private Button button;

        public MyForm2() {
            this.textBox = new TextBox();
            this.button = new Button();
            this.button.Text = "say hello";
            this.button.Top = 30;

            this.Controls.Add(this.textBox);
            this.Controls.Add(this.button);

            // �¼����¼��󶨣����ģ�
            this.button.Click += this.ButtonClicked;
        }

        // �¼�������
        private void ButtonClicked(object? sender, EventArgs e) {
            this.textBox.Text = "Hello world!";
        }
    }



}