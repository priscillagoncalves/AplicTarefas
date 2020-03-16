namespace Interface
{
    partial class FrmMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.buttonNovaTarefa = new System.Windows.Forms.Button();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonVisualizar = new System.Windows.Forms.Button();
            this.buttonExcluirTarefa = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAlterarTarefa = new System.Windows.Forms.Button();
            this.labelTituloPesquisar = new System.Windows.Forms.Label();
            this.dataGridViewPesq = new System.Windows.Forms.DataGridView();
            this.textBoxTituloPesq = new System.Windows.Forms.TextBox();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesq)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNovaTarefa
            // 
            this.buttonNovaTarefa.BackColor = System.Drawing.Color.Black;
            this.buttonNovaTarefa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNovaTarefa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonNovaTarefa.FlatAppearance.BorderSize = 0;
            this.buttonNovaTarefa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonNovaTarefa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonNovaTarefa.Font = new System.Drawing.Font("Tekton Pro Ext", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNovaTarefa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonNovaTarefa.Location = new System.Drawing.Point(56, 68);
            this.buttonNovaTarefa.Name = "buttonNovaTarefa";
            this.buttonNovaTarefa.Size = new System.Drawing.Size(107, 40);
            this.buttonNovaTarefa.TabIndex = 0;
            this.buttonNovaTarefa.Text = "Nova";
            this.buttonNovaTarefa.UseVisualStyleBackColor = false;
            this.buttonNovaTarefa.Click += new System.EventHandler(this.buttonNovaTarefa_Click);
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.BackColor = System.Drawing.Color.Black;
            this.buttonPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonPesquisar.FlatAppearance.BorderSize = 0;
            this.buttonPesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonPesquisar.Font = new System.Drawing.Font("Tekton Pro Ext", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesquisar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPesquisar.Location = new System.Drawing.Point(684, 30);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(127, 40);
            this.buttonPesquisar.TabIndex = 1;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = false;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tekton Pro Ext", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "TAREFAS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(865, 90);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(704, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 454);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.labelTituloPesquisar);
            this.panel3.Controls.Add(this.dataGridViewPesq);
            this.panel3.Controls.Add(this.buttonPesquisar);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel3.Location = new System.Drawing.Point(-1, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(865, 462);
            this.panel3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tekton Pro Ext", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(476, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "*Clique sobre uma tarefa para selecioná-la e escolha Ver, Alterar ou Excluir.";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel4.Controls.Add(this.buttonVisualizar);
            this.panel4.Controls.Add(this.buttonNovaTarefa);
            this.panel4.Controls.Add(this.buttonExcluirTarefa);
            this.panel4.Controls.Add(this.buttonCancelar);
            this.panel4.Controls.Add(this.buttonAlterarTarefa);
            this.panel4.Location = new System.Drawing.Point(3, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 462);
            this.panel4.TabIndex = 22;
            // 
            // buttonVisualizar
            // 
            this.buttonVisualizar.BackColor = System.Drawing.Color.Black;
            this.buttonVisualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVisualizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonVisualizar.FlatAppearance.BorderSize = 0;
            this.buttonVisualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonVisualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonVisualizar.Font = new System.Drawing.Font("Tekton Pro Ext", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonVisualizar.ForeColor = System.Drawing.Color.White;
            this.buttonVisualizar.Location = new System.Drawing.Point(56, 132);
            this.buttonVisualizar.Name = "buttonVisualizar";
            this.buttonVisualizar.Size = new System.Drawing.Size(107, 40);
            this.buttonVisualizar.TabIndex = 22;
            this.buttonVisualizar.Text = "Ver";
            this.buttonVisualizar.UseVisualStyleBackColor = false;
            this.buttonVisualizar.Click += new System.EventHandler(this.buttonVisualizar_Click_1);
            // 
            // buttonExcluirTarefa
            // 
            this.buttonExcluirTarefa.BackColor = System.Drawing.Color.Black;
            this.buttonExcluirTarefa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExcluirTarefa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonExcluirTarefa.FlatAppearance.BorderSize = 0;
            this.buttonExcluirTarefa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonExcluirTarefa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonExcluirTarefa.Font = new System.Drawing.Font("Tekton Pro Ext", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonExcluirTarefa.ForeColor = System.Drawing.Color.White;
            this.buttonExcluirTarefa.Location = new System.Drawing.Point(56, 260);
            this.buttonExcluirTarefa.Name = "buttonExcluirTarefa";
            this.buttonExcluirTarefa.Size = new System.Drawing.Size(107, 40);
            this.buttonExcluirTarefa.TabIndex = 19;
            this.buttonExcluirTarefa.Text = "Excluir";
            this.buttonExcluirTarefa.UseVisualStyleBackColor = false;
            this.buttonExcluirTarefa.Click += new System.EventHandler(this.buttonExcluirTarefa_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.Black;
            this.buttonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonCancelar.Font = new System.Drawing.Font("Tekton Pro Ext", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonCancelar.ForeColor = System.Drawing.Color.White;
            this.buttonCancelar.Location = new System.Drawing.Point(56, 324);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(107, 40);
            this.buttonCancelar.TabIndex = 20;
            this.buttonCancelar.Text = "Fechar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAlterarTarefa
            // 
            this.buttonAlterarTarefa.BackColor = System.Drawing.Color.Black;
            this.buttonAlterarTarefa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAlterarTarefa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAlterarTarefa.FlatAppearance.BorderSize = 0;
            this.buttonAlterarTarefa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonAlterarTarefa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonAlterarTarefa.Font = new System.Drawing.Font("Tekton Pro Ext", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonAlterarTarefa.ForeColor = System.Drawing.Color.White;
            this.buttonAlterarTarefa.Location = new System.Drawing.Point(56, 196);
            this.buttonAlterarTarefa.Name = "buttonAlterarTarefa";
            this.buttonAlterarTarefa.Size = new System.Drawing.Size(107, 40);
            this.buttonAlterarTarefa.TabIndex = 21;
            this.buttonAlterarTarefa.Text = "Alterar";
            this.buttonAlterarTarefa.UseVisualStyleBackColor = false;
            this.buttonAlterarTarefa.Click += new System.EventHandler(this.buttonAlterarTarefa_Click);
            // 
            // labelTituloPesquisar
            // 
            this.labelTituloPesquisar.AutoSize = true;
            this.labelTituloPesquisar.Font = new System.Drawing.Font("Tekton Pro Ext", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloPesquisar.Location = new System.Drawing.Point(277, 44);
            this.labelTituloPesquisar.Name = "labelTituloPesquisar";
            this.labelTituloPesquisar.Size = new System.Drawing.Size(57, 20);
            this.labelTituloPesquisar.TabIndex = 18;
            this.labelTituloPesquisar.Text = "Título";
            // 
            // dataGridViewPesq
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tekton Pro Ext", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridViewPesq.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPesq.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPesq.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridViewPesq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewPesq.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tekton Pro Ext", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPesq.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPesq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewPesq.ColumnHeadersVisible = false;
            this.dataGridViewPesq.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColTitulo,
            this.ColDescricao,
            this.ColData});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tekton Pro Ext", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPesq.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewPesq.Location = new System.Drawing.Point(256, 120);
            this.dataGridViewPesq.MultiSelect = false;
            this.dataGridViewPesq.Name = "dataGridViewPesq";
            this.dataGridViewPesq.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tekton Pro Ext", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPesq.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tekton Pro Ext", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridViewPesq.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewPesq.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dataGridViewPesq.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tekton Pro Ext", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewPesq.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewPesq.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridViewPesq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPesq.Size = new System.Drawing.Size(578, 257);
            this.dataGridViewPesq.TabIndex = 9;
            // 
            // textBoxTituloPesq
            // 
            this.textBoxTituloPesq.Font = new System.Drawing.Font("Tekton Pro Ext", 9.749999F, System.Drawing.FontStyle.Bold);
            this.textBoxTituloPesq.Location = new System.Drawing.Point(339, 129);
            this.textBoxTituloPesq.Name = "textBoxTituloPesq";
            this.textBoxTituloPesq.Size = new System.Drawing.Size(338, 23);
            this.textBoxTituloPesq.TabIndex = 17;
            // 
            // ColId
            // 
            this.ColId.DataPropertyName = "Id";
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tekton Pro Ext", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            this.ColId.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            // 
            // ColTitulo
            // 
            this.ColTitulo.DataPropertyName = "Titulo";
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tekton Pro Ext", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            this.ColTitulo.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColTitulo.HeaderText = "Titulo";
            this.ColTitulo.Name = "ColTitulo";
            this.ColTitulo.ReadOnly = true;
            // 
            // ColDescricao
            // 
            this.ColDescricao.DataPropertyName = "Descricao";
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tekton Pro Ext", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            this.ColDescricao.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColDescricao.HeaderText = "Descricao";
            this.ColDescricao.Name = "ColDescricao";
            this.ColDescricao.ReadOnly = true;
            // 
            // ColData
            // 
            this.ColData.DataPropertyName = "Data";
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tekton Pro Ext", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            this.ColData.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColData.HeaderText = "Data";
            this.ColData.Name = "ColData";
            this.ColData.ReadOnly = true;
            // 
            // FrmMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(861, 541);
            this.Controls.Add(this.textBoxTituloPesq);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNovaTarefa;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelTituloPesquisar;
        private System.Windows.Forms.TextBox textBoxTituloPesq;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonExcluirTarefa;
        private System.Windows.Forms.Button buttonAlterarTarefa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridViewPesq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonVisualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColData;
    }
}