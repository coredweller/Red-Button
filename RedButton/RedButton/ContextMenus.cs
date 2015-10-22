using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedButton
{
    public class ContextMenus
    {
        private readonly NotifyIcon _icon;

        public ContextMenus(NotifyIcon icon) {
            _icon = icon;
        }

        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <returns>ContextMenuStrip</returns>
        public ContextMenuStrip Create() {
            // Add the default menu options.
            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripMenuItem item;

            // Red Button
            item = new ToolStripMenuItem();
            item.Text = "Red Button";
            item.Click += new EventHandler( RedButton_Click );
            //item.Image = Resources.Explorer;
            menu.Items.Add( item );

            // Exit.
            item = new ToolStripMenuItem();
            item.Text = "Exit";
            item.Click += new System.EventHandler( Exit_Click );
            //item.Image = Resources.Exit;
            menu.Items.Add( item );

            return menu;
        }

        /// <summary>
        /// Handles the Click event of the Red Button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void RedButton_Click( object sender, EventArgs e ) {
            _icon.Visible = true;
            //_icon.Icon = SystemIcons.Application;
            _icon.BalloonTipTitle = "RED BUTTON";
            _icon.BalloonTipText = "Brih Brih Brih";
            _icon.ShowBalloonTip( 3000 );
        }

        /// <summary>
        /// Processes a menu item.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void Exit_Click( object sender, EventArgs e ) {
            // Quit without further ado.
            Application.Exit();
        }
    }
}
