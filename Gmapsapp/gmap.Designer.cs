namespace Gmapsapp
{
    partial class Map
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Map));
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dataLocations = new System.Windows.Forms.DataGridView();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLongitude = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRelief = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.minutesScroll = new System.Windows.Forms.TrackBar();
            this.txtScroll = new System.Windows.Forms.Label();
            this.sqLiteCommandBuilder1 = new System.Data.SQLite.SQLiteCommandBuilder();
            this.minutesScroll2 = new System.Windows.Forms.TrackBar();
            this.txtScroll2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.labelDelay = new System.Windows.Forms.Label();
            this.labelEarly = new System.Windows.Forms.Label();
            this.labelDel = new System.Windows.Forms.Label();
            this.btnSatelite = new System.Windows.Forms.Button();
            this.btnRoute = new System.Windows.Forms.Button();
            this.btnDeleted = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataLocations)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minutesScroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesScroll2)).BeginInit();
            this.SuspendLayout();
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemory = 5;
            this.gmap.Location = new System.Drawing.Point(21, 12);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 24;
            this.gmap.MinZoom = 0;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(627, 426);
            this.gmap.TabIndex = 0;
            this.gmap.Zoom = 9D;
            this.gmap.OnMapDoubleClick += new GMap.NET.WindowsForms.MapDoubleClick(this.doubleClick);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(11, 32);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(240, 20);
            this.txtDescription.TabIndex = 1;
            // 
            // dataLocations
            // 
            this.dataLocations.AllowUserToAddRows = false;
            this.dataLocations.Location = new System.Drawing.Point(692, 239);
            this.dataLocations.Name = "dataLocations";
            this.dataLocations.ReadOnly = true;
            this.dataLocations.Size = new System.Drawing.Size(240, 173);
            this.dataLocations.TabIndex = 12;
            this.dataLocations.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.selectLocation);
            // 
            // txtLongitude
            // 
            this.txtLongitude.Location = new System.Drawing.Point(11, 129);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(240, 20);
            this.txtLongitude.TabIndex = 5;
            // 
            // txtLatitude
            // 
            this.txtLatitude.Location = new System.Drawing.Point(11, 80);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(240, 20);
            this.txtLatitude.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Description";
            // 
            // labelLongitude
            // 
            this.labelLongitude.AutoSize = true;
            this.labelLongitude.Location = new System.Drawing.Point(11, 113);
            this.labelLongitude.Name = "labelLongitude";
            this.labelLongitude.Size = new System.Drawing.Size(54, 13);
            this.labelLongitude.TabIndex = 8;
            this.labelLongitude.Text = "Longitude";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Latitude";
            // 
            // btnRelief
            // 
            this.btnRelief.Image = global::Gmapsapp.Properties.Resources.mapa;
            this.btnRelief.Location = new System.Drawing.Point(325, 445);
            this.btnRelief.Name = "btnRelief";
            this.btnRelief.Size = new System.Drawing.Size(83, 40);
            this.btnRelief.TabIndex = 16;
            this.btnRelief.Text = "Relief";
            this.btnRelief.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRelief.UseVisualStyleBackColor = true;
            this.btnRelief.Click += new System.EventHandler(this.btnRelief_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Image = global::Gmapsapp.Properties.Resources.mapas_y_ubicacion;
            this.btnNormal.Location = new System.Drawing.Point(214, 444);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(95, 46);
            this.btnNormal.TabIndex = 17;
            this.btnNormal.Text = "Normal";
            this.btnNormal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLongitude);
            this.groupBox1.Controls.Add(this.labelLongitude);
            this.groupBox1.Controls.Add(this.txtLatitude);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(672, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 170);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Image = global::Gmapsapp.Properties.Resources.calculadora;
            this.button1.Location = new System.Drawing.Point(48, 633);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 44);
            this.button1.TabIndex = 19;
            this.button1.Text = "Calculate probability";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCalculateDelay);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(385, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 31);
            this.label2.TabIndex = 20;
            this.label2.Text = "Probability";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(200, 510);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 29);
            this.label4.TabIndex = 21;
            this.label4.Text = "Delay";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(667, 510);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 29);
            this.label5.TabIndex = 22;
            this.label5.Text = "Early";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 548);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "maximum minute delay";
            // 
            // minutesScroll
            // 
            this.minutesScroll.Location = new System.Drawing.Point(21, 564);
            this.minutesScroll.Maximum = 100;
            this.minutesScroll.Name = "minutesScroll";
            this.minutesScroll.Size = new System.Drawing.Size(445, 45);
            this.minutesScroll.TabIndex = 26;
            this.minutesScroll.TickFrequency = 5;
            this.minutesScroll.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // txtScroll
            // 
            this.txtScroll.AutoSize = true;
            this.txtScroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScroll.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtScroll.Location = new System.Drawing.Point(210, 600);
            this.txtScroll.Name = "txtScroll";
            this.txtScroll.Size = new System.Drawing.Size(21, 24);
            this.txtScroll.TabIndex = 27;
            this.txtScroll.Text = "0";
            // 
            // sqLiteCommandBuilder1
            // 
            this.sqLiteCommandBuilder1.DataAdapter = null;
            this.sqLiteCommandBuilder1.QuoteSuffix = "]";
            // 
            // minutesScroll2
            // 
            this.minutesScroll2.Location = new System.Drawing.Point(490, 564);
            this.minutesScroll2.Maximum = 100;
            this.minutesScroll2.Name = "minutesScroll2";
            this.minutesScroll2.Size = new System.Drawing.Size(445, 45);
            this.minutesScroll2.TabIndex = 29;
            this.minutesScroll2.TickFrequency = 5;
            this.minutesScroll2.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // txtScroll2
            // 
            this.txtScroll2.AutoSize = true;
            this.txtScroll2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScroll2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtScroll2.Location = new System.Drawing.Point(692, 600);
            this.txtScroll2.Name = "txtScroll2";
            this.txtScroll2.Size = new System.Drawing.Size(21, 24);
            this.txtScroll2.TabIndex = 30;
            this.txtScroll2.Text = "0";
            // 
            // button2
            // 
            this.button2.Image = global::Gmapsapp.Properties.Resources.calculadora;
            this.button2.Location = new System.Drawing.Point(505, 634);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 43);
            this.button2.TabIndex = 31;
            this.button2.Text = "Calculate probability";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnCalculateEarly);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(644, 548);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "maximum minute early";
            // 
            // labelDelay
            // 
            this.labelDelay.Location = new System.Drawing.Point(0, 0);
            this.labelDelay.Name = "labelDelay";
            this.labelDelay.Size = new System.Drawing.Size(100, 23);
            this.labelDelay.TabIndex = 36;
            // 
            // labelEarly
            // 
            this.labelEarly.AutoSize = true;
            this.labelEarly.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEarly.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelEarly.Location = new System.Drawing.Point(692, 653);
            this.labelEarly.Name = "labelEarly";
            this.labelEarly.Size = new System.Drawing.Size(0, 24);
            this.labelEarly.TabIndex = 35;
            // 
            // labelDel
            // 
            this.labelDel.AutoSize = true;
            this.labelDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelDel.Location = new System.Drawing.Point(222, 652);
            this.labelDel.Name = "labelDel";
            this.labelDel.Size = new System.Drawing.Size(0, 24);
            this.labelDel.TabIndex = 37;
            // 
            // btnSatelite
            // 
            this.btnSatelite.Image = global::Gmapsapp.Properties.Resources.satelite;
            this.btnSatelite.Location = new System.Drawing.Point(106, 445);
            this.btnSatelite.Name = "btnSatelite";
            this.btnSatelite.Size = new System.Drawing.Size(84, 45);
            this.btnSatelite.TabIndex = 15;
            this.btnSatelite.Text = "Satelite";
            this.btnSatelite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSatelite.UseVisualStyleBackColor = true;
            this.btnSatelite.Click += new System.EventHandler(this.btnSatelite_Click);
            // 
            // btnRoute
            // 
            this.btnRoute.Image = global::Gmapsapp.Properties.Resources.camino;
            this.btnRoute.Location = new System.Drawing.Point(774, 418);
            this.btnRoute.Name = "btnRoute";
            this.btnRoute.Size = new System.Drawing.Size(83, 50);
            this.btnRoute.TabIndex = 13;
            this.btnRoute.Text = "Route";
            this.btnRoute.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRoute.UseVisualStyleBackColor = true;
            this.btnRoute.Click += new System.EventHandler(this.btnRoute_Click);
            // 
            // btnDeleted
            // 
            this.btnDeleted.Image = global::Gmapsapp.Properties.Resources.dejar1;
            this.btnDeleted.Location = new System.Drawing.Point(828, 190);
            this.btnDeleted.Name = "btnDeleted";
            this.btnDeleted.Size = new System.Drawing.Size(95, 43);
            this.btnDeleted.TabIndex = 11;
            this.btnDeleted.Text = "Deleted";
            this.btnDeleted.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleted.UseVisualStyleBackColor = true;
            this.btnDeleted.Click += new System.EventHandler(this.btnDeleted_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::Gmapsapp.Properties.Resources.marcador1;
            this.btnAdd.Location = new System.Drawing.Point(696, 190);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 43);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 749);
            this.Controls.Add(this.labelDel);
            this.Controls.Add(this.labelEarly);
            this.Controls.Add(this.labelDelay);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtScroll2);
            this.Controls.Add(this.minutesScroll2);
            this.Controls.Add(this.txtScroll);
            this.Controls.Add(this.minutesScroll);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.btnRelief);
            this.Controls.Add(this.btnSatelite);
            this.Controls.Add(this.btnRoute);
            this.Controls.Add(this.btnDeleted);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataLocations);
            this.Controls.Add(this.gmap);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Map";
            this.Text = "Maps";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLocations)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minutesScroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesScroll2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DataGridView dataLocations;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLongitude;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDeleted;
        private System.Windows.Forms.Button btnRoute;
        private System.Windows.Forms.Button btnSatelite;
        private System.Windows.Forms.Button btnRelief;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar minutesScroll;
        private System.Windows.Forms.Label txtScroll;
        private System.Data.SQLite.SQLiteCommandBuilder sqLiteCommandBuilder1;
        private System.Windows.Forms.TrackBar minutesScroll2;
        private System.Windows.Forms.Label txtScroll2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelDelay;
        private System.Windows.Forms.Label labelEarly;
        private System.Windows.Forms.Label labelDel;
    }
}

