namespace Famões_Clube_Atlético
{
    partial class CalendarioAdmin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.local = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.escalao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdia = new System.Windows.Forms.TextBox();
            this.txtlocal = new System.Windows.Forms.TextBox();
            this.txthora = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtescalao = new System.Windows.Forms.TextBox();
            this.escalaoo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dia,
            this.horas,
            this.local,
            this.escalao});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(473, 342);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dia
            // 
            this.dia.DataPropertyName = "dia";
            this.dia.Frozen = true;
            this.dia.HeaderText = "Dia";
            this.dia.Name = "dia";
            this.dia.ReadOnly = true;
            this.dia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dia.Width = 80;
            // 
            // horas
            // 
            this.horas.DataPropertyName = "horas";
            this.horas.Frozen = true;
            this.horas.HeaderText = "Horas";
            this.horas.Name = "horas";
            this.horas.ReadOnly = true;
            this.horas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // local
            // 
            this.local.DataPropertyName = "localizacao";
            this.local.Frozen = true;
            this.local.HeaderText = "Local de Jogo";
            this.local.Name = "local";
            this.local.ReadOnly = true;
            this.local.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.local.Width = 150;
            // 
            // escalao
            // 
            this.escalao.DataPropertyName = "escalaoo";
            this.escalao.Frozen = true;
            this.escalao.HeaderText = "Escalão";
            this.escalao.Name = "escalao";
            this.escalao.ReadOnly = true;
            this.escalao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(516, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dia:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(516, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Local de Jogo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(516, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Horas:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtdia
            // 
            this.txtdia.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdia.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtdia.Location = new System.Drawing.Point(519, 56);
            this.txtdia.Name = "txtdia";
            this.txtdia.Size = new System.Drawing.Size(189, 22);
            this.txtdia.TabIndex = 7;
            this.txtdia.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // txtlocal
            // 
            this.txtlocal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlocal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtlocal.Location = new System.Drawing.Point(519, 146);
            this.txtlocal.Name = "txtlocal";
            this.txtlocal.Size = new System.Drawing.Size(189, 22);
            this.txtlocal.TabIndex = 8;
            this.txtlocal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txthora
            // 
            this.txthora.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthora.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txthora.Location = new System.Drawing.Point(519, 100);
            this.txthora.Name = "txthora";
            this.txthora.Size = new System.Drawing.Size(189, 22);
            this.txthora.TabIndex = 9;
            this.txthora.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(519, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Registar jogo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtescalao
            // 
            this.txtescalao.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtescalao.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtescalao.Location = new System.Drawing.Point(519, 192);
            this.txtescalao.Name = "txtescalao";
            this.txtescalao.Size = new System.Drawing.Size(189, 22);
            this.txtescalao.TabIndex = 15;
            // 
            // escalaoo
            // 
            this.escalaoo.AutoSize = true;
            this.escalaoo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escalaoo.Location = new System.Drawing.Point(516, 171);
            this.escalaoo.Name = "escalaoo";
            this.escalaoo.Size = new System.Drawing.Size(70, 18);
            this.escalaoo.TabIndex = 14;
            this.escalaoo.Text = "Escalão:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(519, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 35);
            this.button2.TabIndex = 16;
            this.button2.Text = "Apagar jogo";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CalendarioAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtescalao);
            this.Controls.Add(this.escalaoo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txthora);
            this.Controls.Add(this.txtlocal);
            this.Controls.Add(this.txtdia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CalendarioAdmin";
            this.Size = new System.Drawing.Size(748, 342);
            this.Load += new System.EventHandler(this.CalendarioAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdia;
        private System.Windows.Forms.TextBox txtlocal;
        private System.Windows.Forms.TextBox txthora;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtescalao;
        private System.Windows.Forms.Label escalaoo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn local;
        private System.Windows.Forms.DataGridViewTextBoxColumn escalao;
    }
}
