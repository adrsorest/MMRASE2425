namespace ejercicioTelegrama
{
    partial class Form1
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
            txtTelegrama = new TextBox();
            label1 = new Label();
            txtPrecio = new TextBox();
            label2 = new Label();
            btnCalcularPrecio = new Button();
            radioButtonOrd = new RadioButton();
            radioButtonUrg = new RadioButton();
            SuspendLayout();
            // 
            // txtTelegrama
            // 
            txtTelegrama.Location = new Point(58, 66);
            txtTelegrama.Multiline = true;
            txtTelegrama.Name = "txtTelegrama";
            txtTelegrama.Size = new Size(679, 200);
            txtTelegrama.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 37);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Texto";
            label1.Click += label1_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(104, 353);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(151, 23);
            txtPrecio.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 356);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 5;
            label2.Text = "Coste:";
            // 
            // btnCalcularPrecio
            // 
            btnCalcularPrecio.Location = new Point(571, 317);
            btnCalcularPrecio.Name = "btnCalcularPrecio";
            btnCalcularPrecio.Size = new Size(166, 59);
            btnCalcularPrecio.TabIndex = 6;
            btnCalcularPrecio.Text = "Calcular";
            btnCalcularPrecio.UseVisualStyleBackColor = true;
            btnCalcularPrecio.Click += btnCalcularPrecio_Click;
            // 
            // radioButtonOrd
            // 
            radioButtonOrd.AutoSize = true;
            radioButtonOrd.Checked = true;
            radioButtonOrd.Location = new Point(58, 302);
            radioButtonOrd.Name = "radioButtonOrd";
            radioButtonOrd.Size = new Size(75, 19);
            radioButtonOrd.TabIndex = 7;
            radioButtonOrd.TabStop = true;
            radioButtonOrd.Text = "Ordinario";
            radioButtonOrd.UseVisualStyleBackColor = true;
            radioButtonOrd.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButtonUrg
            // 
            radioButtonUrg.AutoSize = true;
            radioButtonUrg.Location = new Point(139, 302);
            radioButtonUrg.Name = "radioButtonUrg";
            radioButtonUrg.Size = new Size(67, 19);
            radioButtonUrg.TabIndex = 8;
            radioButtonUrg.Text = "Urgente";
            radioButtonUrg.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButtonUrg);
            Controls.Add(radioButtonOrd);
            Controls.Add(btnCalcularPrecio);
            Controls.Add(label2);
            Controls.Add(txtPrecio);
            Controls.Add(label1);
            Controls.Add(txtTelegrama);
            Name = "Form1";
            Text = "Telegrama";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTelegrama;
        private Label label1;
        private TextBox txtPrecio;
        private Label label2;
        private Button btnCalcularPrecio;
        private RadioButton radioButtonOrd;
        private RadioButton radioButtonUrg;
    }
}
