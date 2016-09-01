using System.Media;

namespace Sorts
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbBubble = new System.Windows.Forms.RadioButton();
            this.rbHeap = new System.Windows.Forms.RadioButton();
            this.rbInsertion = new System.Windows.Forms.RadioButton();
            this.rbMerge = new System.Windows.Forms.RadioButton();
            this.rbQuick = new System.Windows.Forms.RadioButton();
            this.rbRadix = new System.Windows.Forms.RadioButton();
            this.rbSelection = new System.Windows.Forms.RadioButton();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbBubble
            // 
            this.rbBubble.AutoSize = true;
            this.rbBubble.Location = new System.Drawing.Point(27, 48);
            this.rbBubble.Name = "rbBubble";
            this.rbBubble.Size = new System.Drawing.Size(80, 17);
            this.rbBubble.TabIndex = 8;
            this.rbBubble.Text = "Bubble Sort";
            this.rbBubble.UseVisualStyleBackColor = true;
            this.rbBubble.CheckedChanged += new System.EventHandler(this.rbBubble_CheckedChanged);
            // 
            // rbHeap
            // 
            this.rbHeap.AutoSize = true;
            this.rbHeap.Location = new System.Drawing.Point(27, 246);
            this.rbHeap.Name = "rbHeap";
            this.rbHeap.Size = new System.Drawing.Size(73, 17);
            this.rbHeap.TabIndex = 9;
            this.rbHeap.Text = "Heap Sort";
            this.rbHeap.UseVisualStyleBackColor = true;
            this.rbHeap.CheckedChanged += new System.EventHandler(this.rbHeap_CheckedChanged);
            // 
            // rbInsertion
            // 
            this.rbInsertion.AutoSize = true;
            this.rbInsertion.Location = new System.Drawing.Point(27, 99);
            this.rbInsertion.Name = "rbInsertion";
            this.rbInsertion.Size = new System.Drawing.Size(87, 17);
            this.rbInsertion.TabIndex = 10;
            this.rbInsertion.Text = "Insertion Sort";
            this.rbInsertion.UseVisualStyleBackColor = true;
            this.rbInsertion.CheckedChanged += new System.EventHandler(this.rbInsertion_CheckedChanged);
            // 
            // rbMerge
            // 
            this.rbMerge.AutoSize = true;
            this.rbMerge.Location = new System.Drawing.Point(27, 196);
            this.rbMerge.Name = "rbMerge";
            this.rbMerge.Size = new System.Drawing.Size(77, 17);
            this.rbMerge.TabIndex = 11;
            this.rbMerge.Text = "Merge Sort";
            this.rbMerge.UseVisualStyleBackColor = true;
            this.rbMerge.CheckedChanged += new System.EventHandler(this.rbMerge_CheckedChanged);
            // 
            // rbQuick
            // 
            this.rbQuick.AutoSize = true;
            this.rbQuick.Location = new System.Drawing.Point(27, 291);
            this.rbQuick.Name = "rbQuick";
            this.rbQuick.Size = new System.Drawing.Size(75, 17);
            this.rbQuick.TabIndex = 12;
            this.rbQuick.Text = "Quick Sort";
            this.rbQuick.UseVisualStyleBackColor = true;
            this.rbQuick.CheckedChanged += new System.EventHandler(this.rbQuick_CheckedChanged);
            // 
            // rbRadix
            // 
            this.rbRadix.AutoSize = true;
            this.rbRadix.Location = new System.Drawing.Point(27, 333);
            this.rbRadix.Name = "rbRadix";
            this.rbRadix.Size = new System.Drawing.Size(74, 17);
            this.rbRadix.TabIndex = 13;
            this.rbRadix.Text = "Radix Sort";
            this.rbRadix.UseVisualStyleBackColor = true;
            this.rbRadix.CheckedChanged += new System.EventHandler(this.rbRadix_CheckedChanged);
            // 
            // rbSelection
            // 
            this.rbSelection.AutoSize = true;
            this.rbSelection.Location = new System.Drawing.Point(27, 145);
            this.rbSelection.Name = "rbSelection";
            this.rbSelection.Size = new System.Drawing.Size(91, 17);
            this.rbSelection.TabIndex = 14;
            this.rbSelection.Text = "Selection Sort";
            this.rbSelection.UseVisualStyleBackColor = true;
            this.rbSelection.CheckedChanged += new System.EventHandler(this.rbSelection_CheckedChanged);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(238, 48);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbResult.Size = new System.Drawing.Size(677, 302);
            this.tbResult.TabIndex = 15;
            this.tbResult.TextChanged += new System.EventHandler(this.tbResult_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Analizar Todos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 478);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.rbSelection);
            this.Controls.Add(this.rbRadix);
            this.Controls.Add(this.rbQuick);
            this.Controls.Add(this.rbMerge);
            this.Controls.Add(this.rbInsertion);
            this.Controls.Add(this.rbHeap);
            this.Controls.Add(this.rbBubble);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbBubble;
        private System.Windows.Forms.RadioButton rbHeap;
        private System.Windows.Forms.RadioButton rbInsertion;
        private System.Windows.Forms.RadioButton rbMerge;
        private System.Windows.Forms.RadioButton rbQuick;
        private System.Windows.Forms.RadioButton rbRadix;
        private System.Windows.Forms.RadioButton rbSelection;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button button1;

    }
}

