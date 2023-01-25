﻿namespace Unite_BuildDisplay
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.heldItemsList = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pokemonList = new System.Windows.Forms.ImageList(this.components);
            this.battleItemsList = new System.Windows.Forms.ImageList(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.ImageList = this.heldItemsList;
            this.button1.Location = new System.Drawing.Point(12, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 3;
            this.button1.Text = "Held Item 1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // heldItemsList
            // 
            this.heldItemsList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("heldItemsList.ImageStream")));
            this.heldItemsList.TransparentColor = System.Drawing.Color.White;
            this.heldItemsList.Images.SetKeyName(0, "Aeos+Cookie.jpg");
            this.heldItemsList.Images.SetKeyName(1, "Assault+Vest.jpg");
            this.heldItemsList.Images.SetKeyName(2, "Attack+Weight.jpg");
            this.heldItemsList.Images.SetKeyName(3, "Buddy+Barrier.jpg");
            this.heldItemsList.Images.SetKeyName(4, "Choice+Specs.jpg");
            this.heldItemsList.Images.SetKeyName(5, "Energy+Amplifier.jpg");
            this.heldItemsList.Images.SetKeyName(6, "Exp+Share.jpg");
            this.heldItemsList.Images.SetKeyName(7, "Float+Stone.jpg");
            this.heldItemsList.Images.SetKeyName(8, "Focus+Band.jpg");
            this.heldItemsList.Images.SetKeyName(9, "Leftovers.jpg");
            this.heldItemsList.Images.SetKeyName(10, "Muscle+Band.jpg");
            this.heldItemsList.Images.SetKeyName(11, "Razor+Claw.jpg");
            this.heldItemsList.Images.SetKeyName(12, "Rocky+Helmet.jpg");
            this.heldItemsList.Images.SetKeyName(13, "Scope+Lens.jpg");
            this.heldItemsList.Images.SetKeyName(14, "Score+Shield.jpg");
            this.heldItemsList.Images.SetKeyName(15, "Shell+Bell.jpg");
            this.heldItemsList.Images.SetKeyName(16, "Special+Attack+Specs.jpg");
            this.heldItemsList.Images.SetKeyName(17, "Weakness+Policy.jpg");
            this.heldItemsList.Images.SetKeyName(18, "Wise+Glasses.jpg");
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.ImageList = this.heldItemsList;
            this.button2.Location = new System.Drawing.Point(93, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 75);
            this.button2.TabIndex = 4;
            this.button2.Text = "Held Item 2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.ImageList = this.heldItemsList;
            this.button3.Location = new System.Drawing.Point(176, 233);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 75);
            this.button3.TabIndex = 5;
            this.button3.Text = "Held Item 3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.ImageList = this.pokemonList;
            this.button4.Location = new System.Drawing.Point(12, 57);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 156);
            this.button4.TabIndex = 1;
            this.button4.Text = "Change Pokemon";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pokemonList
            // 
            this.pokemonList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("pokemonList.ImageStream")));
            this.pokemonList.TransparentColor = System.Drawing.Color.Transparent;
            this.pokemonList.Images.SetKeyName(0, "absol.jpg");
            this.pokemonList.Images.SetKeyName(1, "aegislash.jpg");
            this.pokemonList.Images.SetKeyName(2, "azumarill.jpg");
            this.pokemonList.Images.SetKeyName(3, "blastoise.jpg");
            this.pokemonList.Images.SetKeyName(4, "blissey.jpg");
            this.pokemonList.Images.SetKeyName(5, "buzzwole.jpg");
            this.pokemonList.Images.SetKeyName(6, "charizard.jpg");
            this.pokemonList.Images.SetKeyName(7, "cinderace.jpg");
            this.pokemonList.Images.SetKeyName(8, "clefable.jpg");
            this.pokemonList.Images.SetKeyName(9, "cramorant.jpg");
            this.pokemonList.Images.SetKeyName(10, "crustle.jpg");
            this.pokemonList.Images.SetKeyName(11, "decidueye.jpg");
            this.pokemonList.Images.SetKeyName(12, "delphox.jpg");
            this.pokemonList.Images.SetKeyName(13, "dodrio.jpg");
            this.pokemonList.Images.SetKeyName(14, "dragapult.jpg");
            this.pokemonList.Images.SetKeyName(15, "dragonite.jpg");
            this.pokemonList.Images.SetKeyName(16, "duraludon.jpg");
            this.pokemonList.Images.SetKeyName(17, "eldegoss.jpg");
            this.pokemonList.Images.SetKeyName(18, "espeon.jpg");
            this.pokemonList.Images.SetKeyName(19, "garchomp.jpg");
            this.pokemonList.Images.SetKeyName(20, "gardevoir.jpg");
            this.pokemonList.Images.SetKeyName(21, "gengar.jpg");
            this.pokemonList.Images.SetKeyName(22, "glaceon.jpg");
            this.pokemonList.Images.SetKeyName(23, "greedent.jpg");
            this.pokemonList.Images.SetKeyName(24, "greninja.jpg");
            this.pokemonList.Images.SetKeyName(25, "hoopa.jpg");
            this.pokemonList.Images.SetKeyName(26, "lucario.jpg");
            this.pokemonList.Images.SetKeyName(27, "machamp.jpg");
            this.pokemonList.Images.SetKeyName(28, "mamoswine.jpg");
            this.pokemonList.Images.SetKeyName(29, "mew.jpg");
            this.pokemonList.Images.SetKeyName(30, "mr. mime.jpg");
            this.pokemonList.Images.SetKeyName(31, "ninetails.jpg");
            this.pokemonList.Images.SetKeyName(32, "pikachu.jpg");
            this.pokemonList.Images.SetKeyName(33, "sableye.jpg");
            this.pokemonList.Images.SetKeyName(34, "scizor.jpg");
            this.pokemonList.Images.SetKeyName(35, "slowbro.jpg");
            this.pokemonList.Images.SetKeyName(36, "snorlax.jpg");
            this.pokemonList.Images.SetKeyName(37, "sylveon.jpg");
            this.pokemonList.Images.SetKeyName(38, "talonflame.jpg");
            this.pokemonList.Images.SetKeyName(39, "trevenant.jpg");
            this.pokemonList.Images.SetKeyName(40, "tsareena.jpg");
            this.pokemonList.Images.SetKeyName(41, "tyranitar.jpg");
            this.pokemonList.Images.SetKeyName(42, "urshifu.jpg");
            this.pokemonList.Images.SetKeyName(43, "venusaur.jpg");
            this.pokemonList.Images.SetKeyName(44, "wigglytuff.jpg");
            this.pokemonList.Images.SetKeyName(45, "zeraora.jpg");
            this.pokemonList.Images.SetKeyName(46, "zoroark.jpg");
            // 
            // battleItemsList
            // 
            this.battleItemsList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("battleItemsList.ImageStream")));
            this.battleItemsList.TransparentColor = System.Drawing.Color.Transparent;
            this.battleItemsList.Images.SetKeyName(0, "Eject+Button.jpg");
            this.battleItemsList.Images.SetKeyName(1, "Fluffy+Tail.jpg");
            this.battleItemsList.Images.SetKeyName(2, "Full+Heal.jpg");
            this.battleItemsList.Images.SetKeyName(3, "Goal+Getter.jpg");
            this.battleItemsList.Images.SetKeyName(4, "Potion.jpg");
            this.battleItemsList.Images.SetKeyName(5, "Slow+Smoke.jpg");
            this.battleItemsList.Images.SetKeyName(6, "X+Attack.jpg");
            this.battleItemsList.Images.SetKeyName(7, "X+Speed.jpg");
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.ImageList = this.battleItemsList;
            this.button5.Location = new System.Drawing.Point(176, 138);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 75);
            this.button5.TabIndex = 2;
            this.button5.Text = "Battle Item";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pokemon UNITE Build Display";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Bisque;
            this.label2.Location = new System.Drawing.Point(189, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "by vec";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Unite_BuildDisplay.Properties.Resources.background_small;
            this.ClientSize = new System.Drawing.Size(263, 333);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "UNITE Viewer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ImageList heldItemsList;
        private System.Windows.Forms.ImageList battleItemsList;
        private System.Windows.Forms.ImageList pokemonList;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
