using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace GithubIssueNotifier.Utils
{
    static class Utilities
    {
        #region Images

        public static Image GetImage(Assembly assembly, string embeddedResourceName)
        {
            if(assembly == null)
                assembly = System.Reflection.Assembly.GetExecutingAssembly();
            Stream file = assembly.GetManifestResourceStream(embeddedResourceName);
            if (file == null)
                return null;
            return Image.FromStream(file);
        }

        public static Image GetImage(string embeddedResourceName)
        {
            return Utilities.GetImage(null, embeddedResourceName);
        }

        public static Icon GetIcon(Assembly assembly, string embeddedResourceName)
        {
            if (assembly == null)
                assembly = System.Reflection.Assembly.GetExecutingAssembly();
            Stream file = assembly.GetManifestResourceStream(embeddedResourceName);
            if (file == null)
                return null;
            return new Icon(file);
        }

        public static Icon GetIcon(string embeddedResourceName)
        {
            return Utilities.GetIcon(null, embeddedResourceName);
        }

        #endregion

        #region ListBoxes

        public static List<string> GetItems(this ListBox listbox)
        {
            return listbox.Items.Cast<string>().ToList();
        }

        public static void Populate(this ListBox listbox, List<string> items, bool clearFirst = true)
        {
            if (clearFirst)
                listbox.Items.Clear();
            foreach (string item in items)
            {
                listbox.Items.Add(item);
            }
        }

        public static void MoveSelectedTo(this ListBox from, ListBox to)
        {
            for (int i = from.Items.Count - 1; i >= 0; i--)
            {
                if (from.GetSelected(i))
                {
                    to.Items.Add(from.Items[i]);
                    from.Items.RemoveAt(i);
                }
            }
        }

        public static void RemoveSelected(this ListBox lstbx)
        {
            for (int i = lstbx.Items.Count - 1; i >= 0; i--)
            {
                if (lstbx.GetSelected(i))
                {
                    lstbx.Items.RemoveAt(i);
                }
            }
        }

        public static void AddFromTextBox(this ListBox listBox, TextBox textbox)
        {
            if ((!string.IsNullOrWhiteSpace(textbox.Text)) && (!listBox.Items.Contains(textbox.Text)))
            {
                listBox.Items.Add(textbox.Text);
            }
            textbox.Text = "";
            textbox.Focus();
        }

        #endregion

        #region NotifyIcon tweaks

        public static void SetNotifyTextExtended(this NotifyIcon ni, string text)
        {
            if (text.Length >= 128) 
                throw new ArgumentOutOfRangeException("Text limited to 127 characters");

            Type notifyIconType = typeof(NotifyIcon);
            BindingFlags hidden = BindingFlags.NonPublic | BindingFlags.Instance;
            notifyIconType.GetField("text", hidden).SetValue(ni, text);
            if ((bool)notifyIconType.GetField("added", hidden).GetValue(ni))
                notifyIconType.GetMethod("UpdateIcon", hidden).Invoke(ni, new object[] { true });
        }

        public static void OverlayText(this NotifyIcon ni, Icon icon, string text)
        {
            ni.OverlayText(icon, text, new System.Drawing.Font("Arial", 12, FontStyle.Bold), Color.Red);
        }

        public static void OverlayText(this NotifyIcon ni, Icon icon, string text,  Font font,  Color color)
        {
            Bitmap bmp = icon.ToBitmap();
            Graphics imageGraphics = Graphics.FromImage(bmp);
            SolidBrush drawBrush = new SolidBrush(color);
            StringFormat drawFormat = new StringFormat();
            imageGraphics.DrawString(text, font, drawBrush, (text.Length>2) ? 4 : 8, 12, drawFormat);
            font.Dispose();
            drawBrush.Dispose();
            imageGraphics.Dispose();
            ni.Icon = Icon.FromHandle(bmp.GetHicon());
        }

        #endregion
    }
}
