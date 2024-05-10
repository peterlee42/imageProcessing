namespace ImageProcessing
{
    partial class ImageProcessingForm
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
            this.btnGreenFilter = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnBlueFilter = new System.Windows.Forms.Button();
            this.btnRedFilter = new System.Windows.Forms.Button();
            this.btnDarken = new System.Windows.Forms.Button();
            this.btnLighten = new System.Windows.Forms.Button();
            this.btnNegative = new System.Windows.Forms.Button();
            this.btnSunset = new System.Windows.Forms.Button();
            this.btnGrayscale = new System.Windows.Forms.Button();
            this.btnPolarize = new System.Windows.Forms.Button();
            this.btnFlipHoriz = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnFlipVert = new System.Windows.Forms.Button();
            this.btnRot180 = new System.Windows.Forms.Button();
            this.btnFlipCorners = new System.Windows.Forms.Button();
            this.btnPixellate = new System.Windows.Forms.Button();
            this.btnTile = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGreenFilter
            // 
            this.btnGreenFilter.Location = new System.Drawing.Point(904, 138);
            this.btnGreenFilter.Margin = new System.Windows.Forms.Padding(6);
            this.btnGreenFilter.Name = "btnGreenFilter";
            this.btnGreenFilter.Size = new System.Drawing.Size(175, 44);
            this.btnGreenFilter.TabIndex = 3;
            this.btnGreenFilter.Text = "Green Filter";
            this.btnGreenFilter.UseVisualStyleBackColor = true;
            this.btnGreenFilter.Click += new System.EventHandler(this.btnGreenFilter_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(844, 82);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(6);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(138, 44);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(40, 35);
            this.picImage.Margin = new System.Windows.Forms.Padding(6);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(640, 462);
            this.picImage.TabIndex = 3;
            this.picImage.TabStop = false;
            this.picImage.Click += new System.EventHandler(this.picImage_Click);
            // 
            // btnBlueFilter
            // 
            this.btnBlueFilter.Location = new System.Drawing.Point(1085, 138);
            this.btnBlueFilter.Margin = new System.Windows.Forms.Padding(6);
            this.btnBlueFilter.Name = "btnBlueFilter";
            this.btnBlueFilter.Size = new System.Drawing.Size(175, 44);
            this.btnBlueFilter.TabIndex = 4;
            this.btnBlueFilter.Text = "Blue Filter";
            this.btnBlueFilter.UseVisualStyleBackColor = true;
            this.btnBlueFilter.Click += new System.EventHandler(this.btnBlueFilter_Click);
            // 
            // btnRedFilter
            // 
            this.btnRedFilter.Location = new System.Drawing.Point(723, 138);
            this.btnRedFilter.Margin = new System.Windows.Forms.Padding(6);
            this.btnRedFilter.Name = "btnRedFilter";
            this.btnRedFilter.Size = new System.Drawing.Size(175, 44);
            this.btnRedFilter.TabIndex = 2;
            this.btnRedFilter.Text = "Red Filter";
            this.btnRedFilter.UseVisualStyleBackColor = true;
            this.btnRedFilter.Click += new System.EventHandler(this.btnRedFilter_Click);
            // 
            // btnDarken
            // 
            this.btnDarken.Location = new System.Drawing.Point(904, 191);
            this.btnDarken.Name = "btnDarken";
            this.btnDarken.Size = new System.Drawing.Size(175, 44);
            this.btnDarken.TabIndex = 6;
            this.btnDarken.Text = "Darken";
            this.btnDarken.UseVisualStyleBackColor = true;
            this.btnDarken.Click += new System.EventHandler(this.btnDarken_Click);
            // 
            // btnLighten
            // 
            this.btnLighten.Location = new System.Drawing.Point(1085, 191);
            this.btnLighten.Name = "btnLighten";
            this.btnLighten.Size = new System.Drawing.Size(175, 44);
            this.btnLighten.TabIndex = 7;
            this.btnLighten.Text = "Lighten";
            this.btnLighten.UseVisualStyleBackColor = true;
            this.btnLighten.Click += new System.EventHandler(this.btnLighten_Click);
            // 
            // btnNegative
            // 
            this.btnNegative.Location = new System.Drawing.Point(723, 191);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(175, 44);
            this.btnNegative.TabIndex = 5;
            this.btnNegative.Text = "Negative";
            this.btnNegative.UseVisualStyleBackColor = true;
            this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);
            // 
            // btnSunset
            // 
            this.btnSunset.Location = new System.Drawing.Point(723, 241);
            this.btnSunset.Name = "btnSunset";
            this.btnSunset.Size = new System.Drawing.Size(175, 44);
            this.btnSunset.TabIndex = 8;
            this.btnSunset.Text = "Sunset Filter";
            this.btnSunset.UseVisualStyleBackColor = true;
            this.btnSunset.Click += new System.EventHandler(this.btnSunset_Click);
            // 
            // btnGrayscale
            // 
            this.btnGrayscale.Location = new System.Drawing.Point(904, 241);
            this.btnGrayscale.Name = "btnGrayscale";
            this.btnGrayscale.Size = new System.Drawing.Size(175, 44);
            this.btnGrayscale.TabIndex = 9;
            this.btnGrayscale.Text = "Grayscale";
            this.btnGrayscale.UseVisualStyleBackColor = true;
            this.btnGrayscale.Click += new System.EventHandler(this.btnGrayscale_Click);
            // 
            // btnPolarize
            // 
            this.btnPolarize.Location = new System.Drawing.Point(1085, 241);
            this.btnPolarize.Name = "btnPolarize";
            this.btnPolarize.Size = new System.Drawing.Size(175, 44);
            this.btnPolarize.TabIndex = 10;
            this.btnPolarize.Text = "Polarize";
            this.btnPolarize.UseVisualStyleBackColor = true;
            this.btnPolarize.Click += new System.EventHandler(this.btnPolarize_Click);
            // 
            // btnFlipHoriz
            // 
            this.btnFlipHoriz.Location = new System.Drawing.Point(723, 291);
            this.btnFlipHoriz.Name = "btnFlipHoriz";
            this.btnFlipHoriz.Size = new System.Drawing.Size(175, 44);
            this.btnFlipHoriz.TabIndex = 11;
            this.btnFlipHoriz.Text = "Flip Horizontally";
            this.btnFlipHoriz.UseVisualStyleBackColor = true;
            this.btnFlipHoriz.Click += new System.EventHandler(this.btnFlipHoriz_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(1010, 82);
            this.btnReset.Margin = new System.Windows.Forms.Padding(6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(138, 44);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnFlipVert
            // 
            this.btnFlipVert.Location = new System.Drawing.Point(904, 291);
            this.btnFlipVert.Name = "btnFlipVert";
            this.btnFlipVert.Size = new System.Drawing.Size(175, 44);
            this.btnFlipVert.TabIndex = 12;
            this.btnFlipVert.Text = "Flip Vertically";
            this.btnFlipVert.UseVisualStyleBackColor = true;
            this.btnFlipVert.Click += new System.EventHandler(this.btnFlipVert_Click);
            // 
            // btnRot180
            // 
            this.btnRot180.Location = new System.Drawing.Point(1085, 291);
            this.btnRot180.Name = "btnRot180";
            this.btnRot180.Size = new System.Drawing.Size(175, 44);
            this.btnRot180.TabIndex = 13;
            this.btnRot180.Text = "Rotate 180";
            this.btnRot180.UseVisualStyleBackColor = true;
            this.btnRot180.Click += new System.EventHandler(this.btnRot180_Click);
            // 
            // btnFlipCorners
            // 
            this.btnFlipCorners.Location = new System.Drawing.Point(723, 341);
            this.btnFlipCorners.Name = "btnFlipCorners";
            this.btnFlipCorners.Size = new System.Drawing.Size(175, 44);
            this.btnFlipCorners.TabIndex = 14;
            this.btnFlipCorners.Text = "Flip Corners";
            this.btnFlipCorners.UseVisualStyleBackColor = true;
            this.btnFlipCorners.Click += new System.EventHandler(this.btnFlipCorners_Click);
            // 
            // btnPixellate
            // 
            this.btnPixellate.Location = new System.Drawing.Point(904, 341);
            this.btnPixellate.Name = "btnPixellate";
            this.btnPixellate.Size = new System.Drawing.Size(175, 44);
            this.btnPixellate.TabIndex = 15;
            this.btnPixellate.Text = "Pixellate";
            this.btnPixellate.UseVisualStyleBackColor = true;
            this.btnPixellate.Click += new System.EventHandler(this.btnPixellate_Click);
            // 
            // btnTile
            // 
            this.btnTile.Location = new System.Drawing.Point(1085, 341);
            this.btnTile.Name = "btnTile";
            this.btnTile.Size = new System.Drawing.Size(175, 44);
            this.btnTile.TabIndex = 16;
            this.btnTile.Text = "Tile";
            this.btnTile.UseVisualStyleBackColor = true;
            this.btnTile.Click += new System.EventHandler(this.btnTile_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(723, 391);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(175, 44);
            this.btnSort.TabIndex = 17;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // ImageProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 519);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnTile);
            this.Controls.Add(this.btnPixellate);
            this.Controls.Add(this.btnFlipCorners);
            this.Controls.Add(this.btnRot180);
            this.Controls.Add(this.btnFlipVert);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnFlipHoriz);
            this.Controls.Add(this.btnPolarize);
            this.Controls.Add(this.btnGrayscale);
            this.Controls.Add(this.btnSunset);
            this.Controls.Add(this.btnNegative);
            this.Controls.Add(this.btnLighten);
            this.Controls.Add(this.btnDarken);
            this.Controls.Add(this.btnRedFilter);
            this.Controls.Add(this.btnBlueFilter);
            this.Controls.Add(this.btnGreenFilter);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.picImage);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ImageProcessingForm";
            this.Text = "Image Processing";
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGreenFilter;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button btnBlueFilter;
        private System.Windows.Forms.Button btnRedFilter;
        private System.Windows.Forms.Button btnDarken;
        private System.Windows.Forms.Button btnLighten;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.Button btnSunset;
        private System.Windows.Forms.Button btnGrayscale;
        private System.Windows.Forms.Button btnPolarize;
        private System.Windows.Forms.Button btnFlipHoriz;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnFlipVert;
        private System.Windows.Forms.Button btnRot180;
        private System.Windows.Forms.Button btnFlipCorners;
        private System.Windows.Forms.Button btnPixellate;
        private System.Windows.Forms.Button btnTile;
        private System.Windows.Forms.Button btnSort;
    }
}

