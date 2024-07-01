namespace actividad_2_plataformas_de_desarrollo;

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
        label1 = new Label();
        nombreTxt = new TextBox();
        NombreLbl = new Label();
        label2 = new Label();
        cantidadTxt = new TextBox();
        tipoLbl = new Label();
        tipoSelect = new ComboBox();
        provedorSelect = new ComboBox();
        label3 = new Label();
        sucursalSelect = new ComboBox();
        label4 = new Label();
        confirmarBtn = new Button();
        limpiarBtn = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(137, 38);
        label1.Name = "label1";
        label1.Size = new Size(158, 15);
        label1.TabIndex = 0;
        label1.Text = "GESTOR DE MEDICAMENTOS";
        label1.Click += label1_Click;
        // 
        // nombreTxt
        // 
        nombreTxt.Location = new Point(137, 85);
        nombreTxt.Name = "nombreTxt";
        nombreTxt.Size = new Size(160, 23);
        nombreTxt.TabIndex = 1;
        // 
        // NombreLbl
        // 
        NombreLbl.AutoSize = true;
        NombreLbl.Location = new Point(80, 88);
        NombreLbl.Name = "NombreLbl";
        NombreLbl.Size = new Size(51, 15);
        NombreLbl.TabIndex = 2;
        NombreLbl.Text = "Nombre";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(80, 117);
        label2.Name = "label2";
        label2.Size = new Size(55, 15);
        label2.TabIndex = 4;
        label2.Text = "Cantidad";
        label2.Click += label2_Click;
        // 
        // cantidadTxt
        // 
        cantidadTxt.Location = new Point(137, 114);
        cantidadTxt.Name = "cantidadTxt";
        cantidadTxt.Size = new Size(160, 23);
        cantidadTxt.TabIndex = 3;
        // 
        // tipoLbl
        // 
        tipoLbl.AutoSize = true;
        tipoLbl.Location = new Point(101, 153);
        tipoLbl.Name = "tipoLbl";
        tipoLbl.Size = new Size(30, 15);
        tipoLbl.TabIndex = 5;
        tipoLbl.Text = "Tipo";
        // 
        // tipoSelect
        // 
        tipoSelect.AccessibleName = "tipoSelect";
        tipoSelect.FormattingEnabled = true;
        tipoSelect.Items.AddRange(new object[] { "Analgesico", "Analeptico", "Anestesico", "Antiacido", "Antidepresivo", "Antibiotico" });
        tipoSelect.Location = new Point(137, 150);
        tipoSelect.Name = "tipoSelect";
        tipoSelect.Size = new Size(160, 23);
        tipoSelect.TabIndex = 6;
        // 
        // provedorSelect
        // 
        provedorSelect.AccessibleName = "provedorSelect";
        provedorSelect.FormattingEnabled = true;
        provedorSelect.Items.AddRange(new object[] { "Cofarma", "Empsephar", "Cemefar" });
        provedorSelect.Location = new Point(137, 182);
        provedorSelect.Name = "provedorSelect";
        provedorSelect.Size = new Size(160, 23);
        provedorSelect.TabIndex = 8;
        provedorSelect.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(76, 185);
        label3.Name = "label3";
        label3.Size = new Size(55, 15);
        label3.TabIndex = 7;
        label3.Text = "Provedor";
        // 
        // sucursalSelect
        // 
        sucursalSelect.AccessibleName = "sucursalSelect";
        sucursalSelect.FormattingEnabled = true;
        sucursalSelect.Items.AddRange(new object[] { "Primaria", "Secundaria", "" });
        sucursalSelect.Location = new Point(137, 211);
        sucursalSelect.Name = "sucursalSelect";
        sucursalSelect.Size = new Size(160, 23);
        sucursalSelect.TabIndex = 10;
        sucursalSelect.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(76, 214);
        label4.Name = "label4";
        label4.Size = new Size(51, 15);
        label4.TabIndex = 9;
        label4.Text = "Sucursal";
        // 
        // confirmarBtn
        // 
        confirmarBtn.Location = new Point(242, 270);
        confirmarBtn.Name = "confirmarBtn";
        confirmarBtn.Size = new Size(87, 33);
        confirmarBtn.TabIndex = 11;
        confirmarBtn.Text = "Confirmar";
        confirmarBtn.UseVisualStyleBackColor = true;
        confirmarBtn.Click += confirmarPedido;
        // 
        // limpiarBtn
        // 
        limpiarBtn.Location = new Point(101, 269);
        limpiarBtn.Name = "limpiarBtn";
        limpiarBtn.Size = new Size(95, 34);
        limpiarBtn.TabIndex = 12;
        limpiarBtn.Text = "Limpiar";
        limpiarBtn.UseVisualStyleBackColor = true;
        limpiarBtn.Click += limpiarFormulario;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(443, 450);
        Controls.Add(limpiarBtn);
        Controls.Add(confirmarBtn);
        Controls.Add(sucursalSelect);
        Controls.Add(label4);
        Controls.Add(provedorSelect);
        Controls.Add(label3);
        Controls.Add(tipoSelect);
        Controls.Add(tipoLbl);
        Controls.Add(label2);
        Controls.Add(cantidadTxt);
        Controls.Add(NombreLbl);
        Controls.Add(nombreTxt);
        Controls.Add(label1);
        Name = "Form1";
        Text = "GESTION DE MEDICAMENTOS";
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox nombreTxt;
    private Label NombreLbl;
    private Label label2;
    private TextBox cantidadTxt;
    private Label tipoLbl;
    private ComboBox tipoSelect;
    private ComboBox provedorSelect;
    private Label label3;
    private ComboBox sucursalSelect;
    private Label label4;
    private Button confirmarBtn;
    private Button limpiarBtn;
}
