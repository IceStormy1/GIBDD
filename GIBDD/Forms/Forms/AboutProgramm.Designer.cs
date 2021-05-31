
namespace yt_DesignUI
{
    partial class AboutProgramm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutProgramm));
            this.egoldsFormStyle1 = new yt_DesignUI.Components.EgoldsFormStyle(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AboutProgramm_button_exit = new yt_DesignUI.yt_Button();
            this.SuspendLayout();
            // 
            // egoldsFormStyle1
            // 
            this.egoldsFormStyle1.AllowUserResize = false;
            this.egoldsFormStyle1.BackColor = System.Drawing.Color.RosyBrown;
            this.egoldsFormStyle1.ContextMenuForm = null;
            this.egoldsFormStyle1.ControlBoxButtonsWidth = 30;
            this.egoldsFormStyle1.EnableControlBoxIconsLight = false;
            this.egoldsFormStyle1.EnableControlBoxMouseLight = false;
            this.egoldsFormStyle1.Form = this;
            this.egoldsFormStyle1.FormStyle = yt_DesignUI.Components.EgoldsFormStyle.fStyle.UserStyle;
            this.egoldsFormStyle1.HeaderColor = System.Drawing.Color.RoyalBlue;
            this.egoldsFormStyle1.HeaderColorAdditional = System.Drawing.Color.Tomato;
            this.egoldsFormStyle1.HeaderColorGradientEnable = true;
            this.egoldsFormStyle1.HeaderColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.egoldsFormStyle1.HeaderHeight = 38;
            this.egoldsFormStyle1.HeaderImage = null;
            this.egoldsFormStyle1.HeaderTextColor = System.Drawing.Color.White;
            this.egoldsFormStyle1.HeaderTextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Индивидуальное задание для учебной практики";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Location = new System.Drawing.Point(33, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Работу выполнил Толмачев М.Е ВИС-22";
            // 
            // AboutProgramm_button_exit
            // 
            this.AboutProgramm_button_exit.BackColor = System.Drawing.Color.RoyalBlue;
            this.AboutProgramm_button_exit.BackColorAdditional = System.Drawing.Color.Tomato;
            this.AboutProgramm_button_exit.BackColorGradientEnabled = true;
            this.AboutProgramm_button_exit.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.AboutProgramm_button_exit.BorderColor = System.Drawing.Color.RoyalBlue;
            this.AboutProgramm_button_exit.BorderColorEnabled = true;
            this.AboutProgramm_button_exit.BorderColorOnHover = System.Drawing.Color.White;
            this.AboutProgramm_button_exit.BorderColorOnHoverEnabled = true;
            this.AboutProgramm_button_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutProgramm_button_exit.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.AboutProgramm_button_exit.ForeColor = System.Drawing.Color.White;
            this.AboutProgramm_button_exit.Location = new System.Drawing.Point(149, 73);
            this.AboutProgramm_button_exit.Name = "AboutProgramm_button_exit";
            this.AboutProgramm_button_exit.RippleColor = System.Drawing.Color.White;
            this.AboutProgramm_button_exit.RoundingEnable = true;
            this.AboutProgramm_button_exit.Size = new System.Drawing.Size(57, 26);
            this.AboutProgramm_button_exit.TabIndex = 6;
            this.AboutProgramm_button_exit.Text = "Закрыть";
            this.AboutProgramm_button_exit.TextHover = null;
            this.AboutProgramm_button_exit.UseDownPressEffectOnClick = true;
            this.AboutProgramm_button_exit.UseRippleEffect = true;
            this.AboutProgramm_button_exit.UseZoomEffectOnHover = true;
            this.AboutProgramm_button_exit.Click += new System.EventHandler(this.AboutProgramm_button_exit_Click);
            // 
            // AboutProgramm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 135);
            this.Controls.Add(this.AboutProgramm_button_exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutProgramm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.EgoldsFormStyle egoldsFormStyle1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private yt_Button AboutProgramm_button_exit;
    }
}