namespace Tyuiu.PiskulinIY.Sprint7.Task0.V13
{
    partial class FormMain
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonStart = new Button();
            buttonVopros = new Button();
            buttonCreate = new Button();
            textBoxVvod = new TextBox();
            textBoxResult = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            pictureBoxWorld = new PictureBox();
            labelStrana = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWorld).BeginInit();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.Red;
            buttonStart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonStart.Location = new Point(325, 544);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(186, 65);
            buttonStart.TabIndex = 2;
            buttonStart.Text = "Узнать информацию";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonVopros
            // 
            buttonVopros.BackColor = Color.Red;
            buttonVopros.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonVopros.Location = new Point(99, 544);
            buttonVopros.Name = "buttonVopros";
            buttonVopros.Size = new Size(178, 65);
            buttonVopros.TabIndex = 3;
            buttonVopros.Text = "Правила ввода";
            buttonVopros.UseVisualStyleBackColor = false;
            buttonVopros.Click += buttonVopros_Click;
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = SystemColors.MenuHighlight;
            buttonCreate.FlatStyle = FlatStyle.Flat;
            buttonCreate.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCreate.Location = new Point(12, 544);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(63, 65);
            buttonCreate.TabIndex = 4;
            buttonCreate.Text = "?";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += button3_Click;
            // 
            // textBoxVvod
            // 
            textBoxVvod.Location = new Point(12, 82);
            textBoxVvod.Multiline = true;
            textBoxVvod.Name = "textBoxVvod";
            textBoxVvod.Size = new Size(220, 52);
            textBoxVvod.TabIndex = 6;
            textBoxVvod.TextChanged += textBoxVvod_TextChanged;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(534, 12);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(523, 597);
            textBoxResult.TabIndex = 8;
            textBoxResult.TextChanged += textBoxResult_TextChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialogInfo";
            // 
            // pictureBoxWorld
            // 
            pictureBoxWorld.Image = (Image)resources.GetObject("pictureBoxWorld.Image");
            pictureBoxWorld.Location = new Point(12, 140);
            pictureBoxWorld.Name = "pictureBoxWorld";
            pictureBoxWorld.Size = new Size(516, 332);
            pictureBoxWorld.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxWorld.TabIndex = 10;
            pictureBoxWorld.TabStop = false;
            // 
            // labelStrana
            // 
            labelStrana.AutoSize = true;
            labelStrana.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelStrana.Location = new Point(12, 12);
            labelStrana.Name = "labelStrana";
            labelStrana.Size = new Size(220, 40);
            labelStrana.TabIndex = 11;
            labelStrana.Text = "Введите страну";
            labelStrana.Click += labelStrana_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(343, 12);
            label1.Name = "label1";
            label1.Size = new Size(185, 74);
            label1.TabIndex = 12;
            label1.Text = "Небольшая\r\nинформация:";
            // 
            // FormMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1069, 621);
            Controls.Add(label1);
            Controls.Add(labelStrana);
            Controls.Add(pictureBoxWorld);
            Controls.Add(textBoxResult);
            Controls.Add(textBoxVvod);
            Controls.Add(buttonCreate);
            Controls.Add(buttonVopros);
            Controls.Add(buttonStart);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            Text = "PiskulinIY";
            ((System.ComponentModel.ISupportInitialize)pictureBoxWorld).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxda;
        private Button buttonStart;
        private Button buttonVopros;
        private Button buttonCreate;
        private TextBox textBoxdada;
        private TextBox textBoxVvod;
        private TextBox textBoxResult;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBoxWorld;
        private Label labelStrana;
        private Label label1;
    }
}
