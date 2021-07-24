
namespace RGB
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonRouge = new System.Windows.Forms.Button();
            this.buttonVert = new System.Windows.Forms.Button();
            this.buttonBleu = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nbclickRouge = new System.Windows.Forms.TextBox();
            this.nbclickVert = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nbclickBleu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.initialise = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRouge
            // 
            this.buttonRouge.BackColor = System.Drawing.Color.Red;
            this.buttonRouge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRouge.Location = new System.Drawing.Point(90, 159);
            this.buttonRouge.Name = "buttonRouge";
            this.buttonRouge.Size = new System.Drawing.Size(134, 79);
            this.buttonRouge.TabIndex = 3;
            this.buttonRouge.Text = "Rouge";
            this.buttonRouge.UseVisualStyleBackColor = false;
            this.buttonRouge.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonVert
            // 
            this.buttonVert.BackColor = System.Drawing.Color.Green;
            this.buttonVert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVert.Location = new System.Drawing.Point(335, 159);
            this.buttonVert.Name = "buttonVert";
            this.buttonVert.Size = new System.Drawing.Size(134, 79);
            this.buttonVert.TabIndex = 4;
            this.buttonVert.Text = "Vert";
            this.buttonVert.UseVisualStyleBackColor = false;
            this.buttonVert.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonBleu
            // 
            this.buttonBleu.BackColor = System.Drawing.Color.Blue;
            this.buttonBleu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBleu.Location = new System.Drawing.Point(571, 159);
            this.buttonBleu.Name = "buttonBleu";
            this.buttonBleu.Size = new System.Drawing.Size(134, 79);
            this.buttonBleu.TabIndex = 5;
            this.buttonBleu.Text = "Bleu";
            this.buttonBleu.UseVisualStyleBackColor = false;
            this.buttonBleu.Click += new System.EventHandler(this.buttonBleu_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(92, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(615, 108);
            this.listBox1.TabIndex = 7;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre de Cliques :";
            // 
            // nbclickRouge
            // 
            this.nbclickRouge.BackColor = System.Drawing.Color.Red;
            this.nbclickRouge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbclickRouge.ForeColor = System.Drawing.Color.White;
            this.nbclickRouge.Location = new System.Drawing.Point(200, 275);
            this.nbclickRouge.Name = "nbclickRouge";
            this.nbclickRouge.Size = new System.Drawing.Size(29, 22);
            this.nbclickRouge.TabIndex = 9;
            this.nbclickRouge.Text = "0";
            // 
            // nbclickVert
            // 
            this.nbclickVert.BackColor = System.Drawing.Color.Green;
            this.nbclickVert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbclickVert.ForeColor = System.Drawing.Color.White;
            this.nbclickVert.Location = new System.Drawing.Point(450, 275);
            this.nbclickVert.Name = "nbclickVert";
            this.nbclickVert.Size = new System.Drawing.Size(29, 22);
            this.nbclickVert.TabIndex = 11;
            this.nbclickVert.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre de Cliques :";
            // 
            // nbclickBleu
            // 
            this.nbclickBleu.BackColor = System.Drawing.Color.Blue;
            this.nbclickBleu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbclickBleu.ForeColor = System.Drawing.Color.White;
            this.nbclickBleu.Location = new System.Drawing.Point(685, 275);
            this.nbclickBleu.Name = "nbclickBleu";
            this.nbclickBleu.Size = new System.Drawing.Size(29, 22);
            this.nbclickBleu.TabIndex = 13;
            this.nbclickBleu.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(558, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre de Cliques :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(285, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // initialise
            // 
            this.initialise.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialise.Location = new System.Drawing.Point(76, 331);
            this.initialise.Name = "initialise";
            this.initialise.Size = new System.Drawing.Size(638, 23);
            this.initialise.TabIndex = 15;
            this.initialise.Text = "Initialisation des compteurs";
            this.initialise.UseVisualStyleBackColor = true;
            this.initialise.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.initialise);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nbclickBleu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nbclickVert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nbclickRouge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonBleu);
            this.Controls.Add(this.buttonVert);
            this.Controls.Add(this.buttonRouge);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "For MARION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRouge;
        private System.Windows.Forms.Button buttonVert;
        private System.Windows.Forms.Button buttonBleu;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nbclickRouge;
        private System.Windows.Forms.TextBox nbclickVert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nbclickBleu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button initialise;
    }
}

