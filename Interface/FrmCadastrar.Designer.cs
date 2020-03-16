namespace Interface
{
    partial class FrmCadastrar
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
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.buttonSalvarTarefa = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Font = new System.Drawing.Font("Tekton Pro Ext", 9.749999F, System.Drawing.FontStyle.Bold);
            this.textBoxTitulo.Location = new System.Drawing.Point(153, 53);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(338, 23);
            this.textBoxTitulo.TabIndex = 0;
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Font = new System.Drawing.Font("Tekton Pro Ext", 9.749999F, System.Drawing.FontStyle.Bold);
            this.textBoxDescricao.Location = new System.Drawing.Point(153, 116);
            this.textBoxDescricao.Multiline = true;
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(338, 94);
            this.textBoxDescricao.TabIndex = 2;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Tekton Pro Ext", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(93, 55);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(53, 18);
            this.labelTitulo.TabIndex = 3;
            this.labelTitulo.Text = "Título";
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Font = new System.Drawing.Font("Tekton Pro Ext", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescricao.Location = new System.Drawing.Point(62, 118);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(88, 18);
            this.labelDescricao.TabIndex = 4;
            this.labelDescricao.Text = "Descrição";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Tekton Pro Ext", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(96, 88);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(49, 18);
            this.labelData.TabIndex = 8;
            this.labelData.Text = "Data";
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Font = new System.Drawing.Font("Tekton Pro Ext", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerData.Location = new System.Drawing.Point(153, 84);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(133, 22);
            this.dateTimePickerData.TabIndex = 10;
            // 
            // buttonSalvarTarefa
            // 
            this.buttonSalvarTarefa.BackColor = System.Drawing.Color.Transparent;
            this.buttonSalvarTarefa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSalvarTarefa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSalvarTarefa.FlatAppearance.BorderSize = 0;
            this.buttonSalvarTarefa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonSalvarTarefa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSalvarTarefa.Font = new System.Drawing.Font("Tekton Pro Ext", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarTarefa.ForeColor = System.Drawing.Color.Black;
            this.buttonSalvarTarefa.Location = new System.Drawing.Point(206, 236);
            this.buttonSalvarTarefa.Name = "buttonSalvarTarefa";
            this.buttonSalvarTarefa.Size = new System.Drawing.Size(94, 32);
            this.buttonSalvarTarefa.TabIndex = 11;
            this.buttonSalvarTarefa.Text = "Salvar";
            this.buttonSalvarTarefa.UseVisualStyleBackColor = false;
            this.buttonSalvarTarefa.Click += new System.EventHandler(this.buttonSalvarTarefa_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonCancelar.Font = new System.Drawing.Font("Tekton Pro Ext", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.ForeColor = System.Drawing.Color.Black;
            this.buttonCancelar.Location = new System.Drawing.Point(327, 236);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(107, 32);
            this.buttonCancelar.TabIndex = 12;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Tekton Pro Ext", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(123, 24);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(22, 18);
            this.labelId.TabIndex = 14;
            this.labelId.Text = "Id";
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Tekton Pro Ext", 9.749999F, System.Drawing.FontStyle.Bold);
            this.textBoxId.Location = new System.Drawing.Point(153, 22);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(50, 23);
            this.textBoxId.TabIndex = 13;
            // 
            // FrmCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(612, 318);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvarTarefa);
            this.Controls.Add(this.dateTimePickerData);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.textBoxTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Incluir Nova Tarefa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.DateTimePicker dateTimePickerData;
        private System.Windows.Forms.Button buttonSalvarTarefa;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxId;
    }
}