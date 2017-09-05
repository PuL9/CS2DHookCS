using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CS2DHookCS;
using CS2DHookCS.CS2D;
using CS2DHookCS.Engine;

namespace CS2DHookCS.UI
{
    public partial class NewForm : Form
    {
        public NewForm()
        {
            InitializeComponent();
            ComboBoxHitscan.SelectedIndex = 0;

            Patches.AntiFlash.Set(CheckboxAntiFlash.Checked);
            Patches.AntiSmoke.Set(CheckboxAntiFlash.Checked);
            Patches.AntiTree.Set(CheckboxAntiTree.Checked);
            Patches.AntiFX.Set(CheckboxAntiFX.Checked);
            Patches.Scopex2.Set(Checkboxx2Scope.Checked);
            Patches.SetScopeAlpha(TrackbarScopeAlpha.Value / 100f);
            Patches.SetMapAlpha(TrackbarMapAlpha.Value / 100f);
            Patches.SetMapAlpha(TrackbarMapAlpha.Value / 100f);
            Patches.HideMapBg.Set(CheckboxHideMapBg.Checked);
            Aimbot.HitscanType = ComboBoxHitscan.SelectedIndex;
            Aimbot.ScanRange = TrackBarHitscanRange.Value;
            Globals.MapBgColor = Color.Black;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        #region Trackbars
        private void TrackBarHitscanRange_Scroll(object sender)
        {
            GroupboxHitscan.SubTitle = TrackBarHitscanRange.Value.ToString();
            Aimbot.ScanRange = TrackBarHitscanRange.Value;
        }

        private void TrackbarScopeAlpha_Scroll(object sender)
        {
            GroupboxScopeAlpha.SubTitle = TrackbarScopeAlpha.Value.ToString();
            Patches.SetScopeAlpha((TrackbarScopeAlpha.Value / 100f));
        }

        private void TrackbarMapAlpha_Scroll(object sender)
        {
            GroupboxMapAlpha.SubTitle = TrackbarMapAlpha.Value.ToString();
            Patches.SetMapAlpha((TrackbarMapAlpha.Value / 100f));
        }

        private void TrackbarSpeedhack_Scroll(object sender)
        {
            GroupboxSpeedhack.SubTitle = TrackbarSpeedhack.Value.ToString();
            Globals.Speedhack = TrackbarSpeedhack.Value;
        }

        private void TrackbarSpinbot_Scroll(object sender)
        {
            Globals.Spinbot = TrackbarSpinbot.Value;
            GroupBoxSpinBot.SubTitle = TrackbarSpinbot.Value.ToString();
        }

        #endregion

        #region Checkboxes
        private void CheckboxAntiFlash_CheckedChanged(object sender)
        {
            Patches.AntiFlash.Set(CheckboxAntiFlash.Checked);
            Patches.AntiSmoke.Set(CheckboxAntiFlash.Checked);
        }

        private void CheckboxAntiTree_CheckedChanged(object sender)
        {
            Patches.AntiTree.Set(CheckboxAntiTree.Checked);
        }

        private void CheckboxAntiFX_CheckedChanged(object sender)
        {
            Patches.AntiFX.Set(CheckboxAntiFX.Checked);
        }

        private void Checkboxx2Scope_CheckedChanged(object sender)
        {
            Patches.Scopex2.Set(Checkboxx2Scope.Checked);
        }

        private void CheckboxHideMapBg_CheckedChanged(object sender)
        {
            Patches.HideMapBg.Set(CheckboxHideMapBg.Checked);
        }

        private void CheckBoxSpinbot_CheckedChanged(object sender)
        {
            Patches.DontRotate.Set(CheckBoxSpinbot.Checked);
        }
        #endregion Checkboxes

        private void ButtonMapBgColor_Click(object sender, EventArgs e)
        {
            using(var cp = new ColorDialog())
            {
                if(cp.ShowDialog() == DialogResult.OK)
                {
                    Globals.MapBgColor = cp.Color;
                }
            }
        }
    }
}
