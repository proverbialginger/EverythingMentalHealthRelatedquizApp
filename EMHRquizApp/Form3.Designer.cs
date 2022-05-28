namespace EMHRquizApp
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.answerA = new System.Windows.Forms.RadioButton();
            this.answerB = new System.Windows.Forms.RadioButton();
            this.answerC = new System.Windows.Forms.RadioButton();
            this.answerD = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Which one of the following is a mental illness?";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Blue;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(410, 306);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Blue;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(59, 305);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // answerA
            // 
            this.answerA.AutoSize = true;
            this.answerA.Location = new System.Drawing.Point(70, 118);
            this.answerA.Name = "answerA";
            this.answerA.Size = new System.Drawing.Size(78, 17);
            this.answerA.TabIndex = 4;
            this.answerA.TabStop = true;
            this.answerA.Text = "Depression";
            this.answerA.UseVisualStyleBackColor = true;
            // 
            // answerB
            // 
            this.answerB.AutoSize = true;
            this.answerB.Location = new System.Drawing.Point(381, 118);
            this.answerB.Name = "answerB";
            this.answerB.Size = new System.Drawing.Size(170, 17);
            this.answerB.TabIndex = 5;
            this.answerB.TabStop = true;
            this.answerB.Text = "Post Traumatic Stress Disorder";
            this.answerB.UseVisualStyleBackColor = true;
            // 
            // answerC
            // 
            this.answerC.AutoSize = true;
            this.answerC.Location = new System.Drawing.Point(70, 164);
            this.answerC.Name = "answerC";
            this.answerC.Size = new System.Drawing.Size(59, 17);
            this.answerC.TabIndex = 6;
            this.answerC.TabStop = true;
            this.answerC.Text = "Anxiety";
            this.answerC.UseVisualStyleBackColor = true;
            // 
            // answerD
            // 
            this.answerD.AutoSize = true;
            this.answerD.Location = new System.Drawing.Point(381, 164);
            this.answerD.Name = "answerD";
            this.answerD.Size = new System.Drawing.Size(118, 17);
            this.answerD.TabIndex = 7;
            this.answerD.TabStop = true;
            this.answerD.Text = "All of the mentioned";
            this.answerD.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(562, 401);
            this.Controls.Add(this.answerD);
            this.Controls.Add(this.answerC);
            this.Controls.Add(this.answerB);
            this.Controls.Add(this.answerA);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Question Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.RadioButton answerA;
        private System.Windows.Forms.RadioButton answerB;
        private System.Windows.Forms.RadioButton answerC;
        private System.Windows.Forms.RadioButton answerD;
    }
}