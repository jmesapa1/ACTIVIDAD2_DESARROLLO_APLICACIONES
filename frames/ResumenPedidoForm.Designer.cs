namespace actividad_2_plataformas_de_desarrollo.frames
{
    partial class ResumenPedidoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            distribuidorLbl = new Label();
            detalleLbl = new Label();
            resumenLbl = new Label();
            enviarBtn = new Button();
            cancelarBtn = new Button();
            SuspendLayout();
            // 
            // distribuidorLbl
            // 
            distribuidorLbl.AccessibleName = "distribuidorLbl";
            distribuidorLbl.AutoSize = true;
            distribuidorLbl.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            distribuidorLbl.Location = new Point(134, 27);
            distribuidorLbl.Name = "distribuidorLbl";
            distribuidorLbl.Size = new Size(166, 32);
            distribuidorLbl.TabIndex = 0;
            distribuidorLbl.Text = "Distriubuidor";
            distribuidorLbl.Click += label1_Click;
            // 
            // detalleLbl
            // 
            detalleLbl.AccessibleName = "detalleLbl";
            detalleLbl.AutoSize = true;
            detalleLbl.Location = new Point(60, 70);
            detalleLbl.Name = "detalleLbl";
            detalleLbl.Size = new Size(162, 15);
            detalleLbl.TabIndex = 1;
            detalleLbl.Text = "X unidades del tipo y nombre";
            detalleLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // resumenLbl
            // 
            resumenLbl.AccessibleName = "resumenLbl";
            resumenLbl.AutoSize = true;
            resumenLbl.Location = new Point(60, 110);
            resumenLbl.Name = "resumenLbl";
            resumenLbl.Size = new Size(162, 15);
            resumenLbl.TabIndex = 2;
            resumenLbl.Text = "X unidades del tipo y nombre";
            resumenLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // enviarBtn
            // 
            enviarBtn.Location = new Point(228, 159);
            enviarBtn.Name = "enviarBtn";
            enviarBtn.Size = new Size(98, 38);
            enviarBtn.TabIndex = 3;
            enviarBtn.Text = "Enviar";
            enviarBtn.UseVisualStyleBackColor = true;
            enviarBtn.Click += enviarBtn_Click;
            // 
            // cancelarBtn
            // 
            cancelarBtn.Location = new Point(107, 159);
            cancelarBtn.Name = "cancelarBtn";
            cancelarBtn.Size = new Size(95, 38);
            cancelarBtn.TabIndex = 4;
            cancelarBtn.Text = "Cancelar";
            cancelarBtn.UseVisualStyleBackColor = true;
            // 
            // ResumenPedidoForm
            // 
            AccessibleName = "formWindow";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 222);
            Controls.Add(cancelarBtn);
            Controls.Add(enviarBtn);
            Controls.Add(resumenLbl);
            Controls.Add(detalleLbl);
            Controls.Add(distribuidorLbl);
            Name = "ResumenPedidoForm";
            Text = "Resumen";
            Load += ResumenPedidoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label distribuidorLbl;
        private Label detalleLbl;
        private Label resumenLbl;
        private Button enviarBtn;
        private Button cancelarBtn;
    }
}