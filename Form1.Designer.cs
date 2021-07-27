
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
            this.Topbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NbRedClick = new System.Windows.Forms.TextBox();
            this.NbGreenClick = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NbBlueClick = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.reset_colors_buttons = new System.Windows.Forms.Button();
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
            this.buttonRouge.Click += new System.EventHandler(this.buttonRouge_Click);
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
            this.buttonVert.Click += new System.EventHandler(this.buttonVert_Click);
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
            // Topbox
            // 
            this.Topbox.FormattingEnabled = true;
            this.Topbox.Location = new System.Drawing.Point(92, 12);
            this.Topbox.Name = "Topbox";
            this.Topbox.Size = new System.Drawing.Size(615, 108);
            this.Topbox.TabIndex = 7;
            this.Topbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Topbox_MouseClick);
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
            // NbRedClick
            // 
            this.NbRedClick.BackColor = System.Drawing.Color.Red;
            this.NbRedClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NbRedClick.ForeColor = System.Drawing.Color.White;
            this.NbRedClick.Location = new System.Drawing.Point(200, 275);
            this.NbRedClick.Name = "NbRedClick";
            this.NbRedClick.Size = new System.Drawing.Size(29, 22);
            this.NbRedClick.TabIndex = 9;
            this.NbRedClick.Text = "0";
            // 
            // NbGreenClick
            // 
            this.NbGreenClick.BackColor = System.Drawing.Color.Green;
            this.NbGreenClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NbGreenClick.ForeColor = System.Drawing.Color.White;
            this.NbGreenClick.Location = new System.Drawing.Point(450, 275);
            this.NbGreenClick.Name = "NbGreenClick";
            this.NbGreenClick.Size = new System.Drawing.Size(29, 22);
            this.NbGreenClick.TabIndex = 11;
            this.NbGreenClick.Text = "0";
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
            // NbBlueClick
            // 
            this.NbBlueClick.BackColor = System.Drawing.Color.Blue;
            this.NbBlueClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NbBlueClick.ForeColor = System.Drawing.Color.White;
            this.NbBlueClick.Location = new System.Drawing.Point(685, 275);
            this.NbBlueClick.Name = "NbBlueClick";
            this.NbBlueClick.Size = new System.Drawing.Size(29, 22);
            this.NbBlueClick.TabIndex = 13;
            this.NbBlueClick.Text = "0";
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
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(285, 415);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(206, 23);
            this.exit.TabIndex = 14;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // reset_colors_buttons
            // 
            this.reset_colors_buttons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_colors_buttons.Location = new System.Drawing.Point(76, 331);
            this.reset_colors_buttons.Name = "reset_colors_buttons";
            this.reset_colors_buttons.Size = new System.Drawing.Size(638, 23);
            this.reset_colors_buttons.TabIndex = 15;
            this.reset_colors_buttons.Text = "Initialisation des compteurs";
            this.reset_colors_buttons.UseVisualStyleBackColor = true;
            this.reset_colors_buttons.Click += new System.EventHandler(this.reset_colors_buttons_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reset_colors_buttons);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.NbBlueClick);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NbGreenClick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NbRedClick);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Topbox);
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
        private System.Windows.Forms.ListBox Topbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NbRedClick;
        private System.Windows.Forms.TextBox NbGreenClick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NbBlueClick;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button reset_colors_buttons;
    }
}

