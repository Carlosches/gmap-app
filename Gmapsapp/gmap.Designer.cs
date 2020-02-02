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
            this.btnRoute = new System.Windows.Forms.Button();
            this.btnDeleted = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSatelite = new System.Windows.Forms.Button();
            this.btnRelief = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataLocations)).BeginInit();
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
            this.gmap.Size = new System.Drawing.Size(585, 426);
            this.gmap.TabIndex = 0;
            this.gmap.Zoom = 9D;
            this.gmap.OnMapDoubleClick += new GMap.NET.WindowsForms.MapDoubleClick(this.doubleClick);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(640, 25);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(240, 20);
            this.txtDescription.TabIndex = 1;
            // 
            // dataLocations
            // 
            this.dataLocations.AllowUserToAddRows = false;
            this.dataLocations.Location = new System.Drawing.Point(640, 221);
            this.dataLocations.Name = "dataLocations";
            this.dataLocations.ReadOnly = true;
            this.dataLocations.Size = new System.Drawing.Size(240, 173);
            this.dataLocations.TabIndex = 12;
            this.dataLocations.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.selectLocation);
            // 
            // txtLongitude
            // 
            this.txtLongitude.Location = new System.Drawing.Point(640, 131);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(240, 20);
            this.txtLongitude.TabIndex = 5;
            // 
            // txtLatitude
            // 
            this.txtLatitude.Location = new System.Drawing.Point(640, 74);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(240, 20);
            this.txtLatitude.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(637, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Description";
            // 
            // labelLongitude
            // 
            this.labelLongitude.AutoSize = true;
            this.labelLongitude.Location = new System.Drawing.Point(640, 106);
            this.labelLongitude.Name = "labelLongitude";
            this.labelLongitude.Size = new System.Drawing.Size(54, 13);
            this.labelLongitude.TabIndex = 8;
            this.labelLongitude.Text = "Longitude";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(640, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Latitude";
            // 
            // btnRoute
            // 
            this.btnRoute.Image = global::Gmapsapp.Properties.Resources.camino;
            this.btnRoute.Location = new System.Drawing.Point(712, 400);
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
            this.btnDeleted.Location = new System.Drawing.Point(771, 172);
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
            this.btnAdd.Location = new System.Drawing.Point(643, 172);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 43);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSatelite
            // 
            this.btnSatelite.Location = new System.Drawing.Point(106, 445);
            this.btnSatelite.Name = "btnSatelite";
            this.btnSatelite.Size = new System.Drawing.Size(75, 23);
            this.btnSatelite.TabIndex = 15;
            this.btnSatelite.Text = "satelite";
            this.btnSatelite.UseVisualStyleBackColor = true;
            this.btnSatelite.Click += new System.EventHandler(this.btnSatelite_Click);
            // 
            // btnRelief
            // 
            this.btnRelief.Location = new System.Drawing.Point(315, 444);
            this.btnRelief.Name = "btnRelief";
            this.btnRelief.Size = new System.Drawing.Size(75, 23);
            this.btnRelief.TabIndex = 16;
            this.btnRelief.Text = "relief";
            this.btnRelief.UseVisualStyleBackColor = true;
            this.btnRelief.Click += new System.EventHandler(this.btnRelief_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Location = new System.Drawing.Point(214, 444);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(75, 23);
            this.btnNormal.TabIndex = 17;
            this.btnNormal.Text = "Normal";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 499);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.btnRelief);
            this.Controls.Add(this.btnSatelite);
            this.Controls.Add(this.btnRoute);
            this.Controls.Add(this.btnDeleted);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelLongitude);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLatitude);
            this.Controls.Add(this.txtLongitude);
            this.Controls.Add(this.dataLocations);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.gmap);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Map";
            this.Text = "Maps";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLocations)).EndInit();
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
    }
}

