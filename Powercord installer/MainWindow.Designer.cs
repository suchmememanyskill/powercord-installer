
namespace Powercord_installer
{
    partial class Powercord_Installer
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
            this.rtb_console = new System.Windows.Forms.RichTextBox();
            this.btn_install = new System.Windows.Forms.Button();
            this.btn_updatePowercord = new System.Windows.Forms.Button();
            this.btn_updateNodePkg = new System.Windows.Forms.Button();
            this.btn_plug = new System.Windows.Forms.Button();
            this.btn_unplug = new System.Windows.Forms.Button();
            this.btn_openPlugins = new System.Windows.Forms.Button();
            this.btn_openThemes = new System.Windows.Forms.Button();
            this.btn_killDiscord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_console
            // 
            this.rtb_console.BackColor = System.Drawing.Color.Black;
            this.rtb_console.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_console.Dock = System.Windows.Forms.DockStyle.Right;
            this.rtb_console.ForeColor = System.Drawing.Color.White;
            this.rtb_console.Location = new System.Drawing.Point(159, 0);
            this.rtb_console.Name = "rtb_console";
            this.rtb_console.ReadOnly = true;
            this.rtb_console.Size = new System.Drawing.Size(401, 450);
            this.rtb_console.TabIndex = 2;
            this.rtb_console.Text = "";
            this.rtb_console.TextChanged += new System.EventHandler(this.rtb_console_TextChanged);
            // 
            // btn_install
            // 
            this.btn_install.BackColor = System.Drawing.Color.LightGray;
            this.btn_install.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_install.Location = new System.Drawing.Point(12, 12);
            this.btn_install.Name = "btn_install";
            this.btn_install.Size = new System.Drawing.Size(132, 23);
            this.btn_install.TabIndex = 3;
            this.btn_install.Text = "Install Powercord";
            this.btn_install.UseVisualStyleBackColor = false;
            this.btn_install.EnabledChanged += new System.EventHandler(this.ButtonEnabledColors);
            this.btn_install.Click += new System.EventHandler(this.btn_install_Click);
            // 
            // btn_updatePowercord
            // 
            this.btn_updatePowercord.BackColor = System.Drawing.Color.LightGray;
            this.btn_updatePowercord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updatePowercord.Location = new System.Drawing.Point(12, 41);
            this.btn_updatePowercord.Name = "btn_updatePowercord";
            this.btn_updatePowercord.Size = new System.Drawing.Size(132, 23);
            this.btn_updatePowercord.TabIndex = 4;
            this.btn_updatePowercord.Text = "Update Powercord";
            this.btn_updatePowercord.UseVisualStyleBackColor = false;
            this.btn_updatePowercord.EnabledChanged += new System.EventHandler(this.ButtonEnabledColors);
            this.btn_updatePowercord.Click += new System.EventHandler(this.btn_updatePowercord_Click);
            // 
            // btn_updateNodePkg
            // 
            this.btn_updateNodePkg.BackColor = System.Drawing.Color.LightGray;
            this.btn_updateNodePkg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateNodePkg.Location = new System.Drawing.Point(12, 70);
            this.btn_updateNodePkg.Name = "btn_updateNodePkg";
            this.btn_updateNodePkg.Size = new System.Drawing.Size(132, 23);
            this.btn_updateNodePkg.TabIndex = 5;
            this.btn_updateNodePkg.Text = "Update Node Packages";
            this.btn_updateNodePkg.UseVisualStyleBackColor = false;
            this.btn_updateNodePkg.EnabledChanged += new System.EventHandler(this.ButtonEnabledColors);
            this.btn_updateNodePkg.Click += new System.EventHandler(this.btn_updateNodePkg_Click);
            // 
            // btn_plug
            // 
            this.btn_plug.BackColor = System.Drawing.Color.LightGray;
            this.btn_plug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_plug.Location = new System.Drawing.Point(12, 99);
            this.btn_plug.Name = "btn_plug";
            this.btn_plug.Size = new System.Drawing.Size(132, 23);
            this.btn_plug.TabIndex = 6;
            this.btn_plug.Text = "(Re)plug";
            this.btn_plug.UseVisualStyleBackColor = false;
            this.btn_plug.EnabledChanged += new System.EventHandler(this.ButtonEnabledColors);
            this.btn_plug.Click += new System.EventHandler(this.btn_plug_Click);
            // 
            // btn_unplug
            // 
            this.btn_unplug.BackColor = System.Drawing.Color.LightGray;
            this.btn_unplug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_unplug.Location = new System.Drawing.Point(12, 128);
            this.btn_unplug.Name = "btn_unplug";
            this.btn_unplug.Size = new System.Drawing.Size(132, 23);
            this.btn_unplug.TabIndex = 7;
            this.btn_unplug.Text = "Unplug";
            this.btn_unplug.UseVisualStyleBackColor = false;
            this.btn_unplug.EnabledChanged += new System.EventHandler(this.ButtonEnabledColors);
            this.btn_unplug.Click += new System.EventHandler(this.btn_unplug_Click);
            // 
            // btn_openPlugins
            // 
            this.btn_openPlugins.BackColor = System.Drawing.Color.LightGray;
            this.btn_openPlugins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_openPlugins.Location = new System.Drawing.Point(12, 157);
            this.btn_openPlugins.Name = "btn_openPlugins";
            this.btn_openPlugins.Size = new System.Drawing.Size(132, 23);
            this.btn_openPlugins.TabIndex = 8;
            this.btn_openPlugins.Text = "Open plugins dir";
            this.btn_openPlugins.UseVisualStyleBackColor = false;
            this.btn_openPlugins.EnabledChanged += new System.EventHandler(this.ButtonEnabledColors);
            this.btn_openPlugins.Click += new System.EventHandler(this.btn_openPlugins_Click);
            // 
            // btn_openThemes
            // 
            this.btn_openThemes.BackColor = System.Drawing.Color.LightGray;
            this.btn_openThemes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_openThemes.Location = new System.Drawing.Point(12, 186);
            this.btn_openThemes.Name = "btn_openThemes";
            this.btn_openThemes.Size = new System.Drawing.Size(132, 23);
            this.btn_openThemes.TabIndex = 9;
            this.btn_openThemes.Text = "Open themes dir";
            this.btn_openThemes.UseVisualStyleBackColor = false;
            this.btn_openThemes.EnabledChanged += new System.EventHandler(this.ButtonEnabledColors);
            this.btn_openThemes.Click += new System.EventHandler(this.btn_openThemes_Click);
            // 
            // btn_killDiscord
            // 
            this.btn_killDiscord.BackColor = System.Drawing.Color.LightGray;
            this.btn_killDiscord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_killDiscord.Location = new System.Drawing.Point(12, 215);
            this.btn_killDiscord.Name = "btn_killDiscord";
            this.btn_killDiscord.Size = new System.Drawing.Size(132, 23);
            this.btn_killDiscord.TabIndex = 10;
            this.btn_killDiscord.Text = "Kill discord canary";
            this.btn_killDiscord.UseVisualStyleBackColor = false;
            this.btn_killDiscord.EnabledChanged += new System.EventHandler(this.ButtonEnabledColors);
            this.btn_killDiscord.Click += new System.EventHandler(this.btn_killDiscord_Click);
            // 
            // Powercord_Installer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.btn_killDiscord);
            this.Controls.Add(this.btn_openThemes);
            this.Controls.Add(this.btn_openPlugins);
            this.Controls.Add(this.btn_unplug);
            this.Controls.Add(this.btn_plug);
            this.Controls.Add(this.btn_updateNodePkg);
            this.Controls.Add(this.btn_updatePowercord);
            this.Controls.Add(this.btn_install);
            this.Controls.Add(this.rtb_console);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Powercord_Installer";
            this.Text = "Powercord installer";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtb_console;
        private System.Windows.Forms.Button btn_install;
        private System.Windows.Forms.Button btn_updatePowercord;
        private System.Windows.Forms.Button btn_updateNodePkg;
        private System.Windows.Forms.Button btn_plug;
        private System.Windows.Forms.Button btn_unplug;
        private System.Windows.Forms.Button btn_openPlugins;
        private System.Windows.Forms.Button btn_openThemes;
        private System.Windows.Forms.Button btn_killDiscord;
    }
}

