﻿namespace MemoScope.Modules.RootPath
{
    partial class RootPathModule
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtlvDistribution = new WinFwk.UITools.DefaultListView();
            ((System.ComponentModel.ISupportInitialize)(this.dtlvDistribution)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultListView1
            // 
            this.dtlvDistribution.CellEditUseWholeCell = false;
            this.dtlvDistribution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtlvDistribution.FullRowSelect = true;
            this.dtlvDistribution.HideSelection = false;
            this.dtlvDistribution.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.dtlvDistribution.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.dtlvDistribution.Location = new System.Drawing.Point(0, 0);
            this.dtlvDistribution.Name = "defaultListView1";
            this.dtlvDistribution.ShowGroups = false;
            this.dtlvDistribution.ShowImagesOnSubItems = true;
            this.dtlvDistribution.Size = new System.Drawing.Size(762, 483);
            this.dtlvDistribution.TabIndex = 0;
            this.dtlvDistribution.UseCompatibleStateImageBehavior = false;
            this.dtlvDistribution.View = System.Windows.Forms.View.Details;
            this.dtlvDistribution.VirtualMode = true;
            // 
            // ModulesModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtlvDistribution);
            this.Name = "ModulesModule";
            this.Size = new System.Drawing.Size(762, 483);
            ((System.ComponentModel.ISupportInitialize)(this.dtlvDistribution)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WinFwk.UITools.DefaultListView dtlvDistribution;
    }
}
