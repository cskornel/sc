using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq;
using SimpleCounter.CounterClasses;

namespace SimpleCounter
{
    public partial class FormMain : Form
    {
        #region Declaration

        private FormTimer _formTimer1;
        private FormTimer _formTimer2;
        private Counter _counter;
        private MainFormData formData;
        private const int SnapDist = 200;
        private string savePath;
        private GlobalSettings _globalSettings;
        bool start = true;
        private string _assemblyVersion;

        #endregion

        #region Constructor

        public FormMain()
        {
            InitializeComponent();

            _counter = new Counter();
            formData = new MainFormData();
            savePath = "";
            _globalSettings = new GlobalSettings();

            //Mentett fájlok helyének meghatározása
            setSavePath();

            myControlInit();

            _formTimer1 = new FormTimer(_counter);
            _formTimer1.SetCounterDefaultColors();
            _formTimer2 = new FormTimer(_counter);
            _formTimer2.SetCounterDefaultColors();
            _formTimer2.Formatum = 1;
            _formTimer1.Hide();

            SetCounterData();
        }

        #endregion

        #region Methods

        private void SetCounterData()
        {
            // usercontrols

            ucMonitorControlBox1.Counter = _counter;
            ucMonitorControlBox1.FormTimer = _formTimer1;
            //ucMonitorControlBox.GlobalSettings = _globalSettings;

            ucFontSizeBox1.Counter = _counter;
            ucFontSizeBox1.FormTimer = _formTimer1;
            ucFontSizeBox1.GlobalSettings = _globalSettings;

            ucTimeDirection1.Counter = _counter;

            ucCounter1.Counter = _counter;
            ucCounter1.FormTimer = _formTimer1;

            ucEffectBox1.Counter = _counter;
            ucEffectBox1.FormTimer1 = _formTimer1;
            ucEffectBox1.FormTimer2 = _formTimer2;

            ucTimeSettings1.Counter = _counter;
            ucTimeSettings1.FormTimer1 = _formTimer1;
            ucTimeSettings1.FormTimer2 = _formTimer2;
            ucTimeSettings1.GlobalSettings = _globalSettings;
            ucTimeSettings1.UcCounter = ucCounter1;
            ucTimeSettings1.UcEffectBox = ucEffectBox1;

            ucMonitorPreviewBox1.Counter = _counter;
            ucMonitorPreviewBox1.GlobalSettings = _globalSettings;
            ucMonitorPreviewBox1.StartVideo();

            ucCounterTypeChanger1.Counter = _counter;
            ucCounterTypeChanger1.FormTimer1 = _formTimer1;
            ucCounterTypeChanger1.FormTimer2 = _formTimer2;
            ucCounterTypeChanger1.UcCounter = ucCounter1;

            

            // 2-es kimenet

            ucMonitorPreviewBox2.Counter = _counter;
            ucMonitorPreviewBox2.GlobalSettings = _globalSettings;
            ucMonitorPreviewBox2.StopVideo();

            ucMonitorControlBox2.Counter = _counter;
            ucMonitorControlBox2.FormTimer = _formTimer2;

            ucFontSizeBox2.Counter = _counter;
            ucFontSizeBox2.FormTimer = _formTimer2;
            ucFontSizeBox2.GlobalSettings = _globalSettings;

        }

        private void myControlInit()
        {
            //verzió infók lekérése, beállítása
            DateTime lastModified = new FileInfo(Assembly.GetExecutingAssembly().Location).LastWriteTime;
            _assemblyVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            Text = "Counter " + _assemblyVersion + " (" + lastModified.Date.ToString("yyyy.MM.dd") + ")";
            labelAboutVer.Text = "Verzió: " + _assemblyVersion;
            labelAboutDate.Text = "Kiadás dátuma: " + lastModified.Date.ToString("yyyy.MM.dd");

            //csatlakoztatott monitorok számának lekérése
            //nupdMonitor.Minimum = 1;
            //nupdMonitor.Maximum = Screen.AllScreens.Length;

            //egyéb értékadás controloknak
            btnStopStart.Enabled = true;
            btnStopStart.Text = "START";
            panelStopStart.BackColor = Color.Black;
            //labelTimer.Text = c.ToString();
            chbStopZero.Checked = true;
            chbStopZero.Text = "Auto stopp ha nulla \r\n( BE )";

            SetControlsLocation();
        }

        private void setSavePath()
        {
            string appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
            try
            {
                if (!Directory.Exists(appDataPath + @"\SimpleCounter"))
                {
                    Directory.CreateDirectory(appDataPath + @"\SimpleCounter");
                }

                savePath = appDataPath + @"\SimpleCounter";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SetUControlsLocation(int defaultLeft, int defaultSpace)
        {
            panelMainControls.VerticalScroll.Value = 0;

            ucMonitorPreviewBox1.Top = 8;
            ucMonitorPreviewBox1.Left = defaultLeft;

            ucMonitorControlBox1.Top = ucMonitorPreviewBox1.Top + ucMonitorPreviewBox1.Height + defaultSpace;
            ucMonitorControlBox1.Left = defaultLeft;

            ucFontSizeBox1.Top = ucMonitorControlBox1.Top + ucMonitorControlBox1.Height + defaultSpace;
            ucFontSizeBox1.Left = defaultLeft;

            ucCounterTypeChanger1.Top = ucFontSizeBox1.Top + ucFontSizeBox1.Height + defaultSpace;
            ucCounterTypeChanger1.Left = defaultLeft;

            ucTimeDirection1.Top = ucCounterTypeChanger1.Top + ucCounterTypeChanger1.Height + defaultSpace;
            ucTimeDirection1.Left = defaultLeft;

            ucCounter1.Top = ucTimeDirection1.Top + ucTimeDirection1.Height + defaultSpace;
            ucCounter1.Left = defaultLeft;

            ucTimeSettings1.Top = ucCounter1.Top + ucCounter1.Height + defaultSpace;
            ucTimeSettings1.Left = defaultLeft;

            ucEffectBox1.Top = ucTimeSettings1.Top + ucTimeSettings1.Height + defaultSpace;
            ucEffectBox1.Left = defaultLeft;

            panelMainControls.VerticalScroll.Value = 0;
        }

        private void SetControlsLocation()
        {
            SetUControlsLocation(3, 4);

            panelMainControls.AutoScrollMinSize = new Size(269, this.Height - panelTop.Height - panelStopStart.Height);

            if (ucTimeSettings1.Top + ucTimeSettings1.Height < panelMainControls.Height)
            {
                panelMainControls.AutoScroll = false;
                SetUControlsLocation(13, 4);
            }
            else
            {
                panelMainControls.AutoScroll = true;
                SetUControlsLocation(3, 4);
            }

        }

        #endregion

        #region Events

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztosan kilép a programból?", "Biztosan?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                //értékek mentése
                formData.Top = this.Top;
                formData.Left = this.Left;
                formData.Width = this.Width;
                formData.Height = this.Height;
                SaveMainFormDataXML(savePath + @"\formData.xml");
                SaveCounterXML(savePath + @"\counter.xml");

                //kilépés
                e.Cancel = false;
            }
        }

        private void checkBoxTopWindow_Click(object sender, EventArgs e)
        {
            TopMost = checkBoxTopWindow.Checked;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            checkBoxTopWindow_Click(this, new EventArgs());

#if DEBUG

#else
            ReadMainFormDataXML();
            ReadCounterDataXML();
            SetCounterData();
#endif

        }

        private void btnStopStart_Click(object sender, EventArgs e)
        {
            if (_counter.Enabled)
            {
                _counter.Enabled = false;
                btnStopStart.Text = "START";
                btnStopStart.BackColor = Color.SeaGreen;
            }
            else
            {
                start = true;
                _counter.Enabled = true;
                btnStopStart.Text = "STOP";
                btnStopStart.BackColor = Color.IndianRed;
            }

            timer1.Enabled = _counter.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //csak akkor megy a számláló, ha számláló típus van beálllítva
            if (_counter.CounterType == CounterTypeEnum.Counter)
            {
                if (chbStopZero.Checked && (_counter.UserTime == 0 && !start))
                {
                    btnStopStart_Click(sender, new EventArgs());
                }
                else
                {
                    _counter.Go();
                    ucCounter1.UpdateTime();
                    _formTimer1.TimerUpdate();
                    _formTimer2.TimerUpdate();
                    start = false;

                    if (_counter.CounterType == CounterTypeEnum.Counter && !_counter.HideText)
                    {
                        //effekt

                        //ha a számok elérik a megadott időkorlátot, pirosra változik a színük
                        if (_counter.FigylmeztetVisszaszamlalasnal2 &&
                            _counter.UserTime < _counter.FigyelmeztetIdo2 &&
                            _counter.UserTime >= 0 &&
                            !_counter.Direction
                            )
                        {
                            _formTimer1.SetCounterColor(Color.Red, Color.Black);
                        }
                        else if (_counter.FigylmeztetVisszaszamlalasnal1 &&
                            _counter.UserTime < _counter.FigyelmeztetIdo1 &&
                            _counter.UserTime >= 0 &&
                            !_counter.Direction
                            )
                        {
                            _formTimer1.SetCounterColor(Color.Orange, Color.Black);
                        }
                        else
                        {
                            _formTimer1.SetCounterDefaultColors();
                        }
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ReadMainFormDataXML();
            ReadCounterDataXML();
            //ucMonitorControlBox1.Show();
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                Top = 0;
                Left = Screen.FromControl(this).Bounds.Width - Width;
                //Height = Screen.FromControl(this).Bounds.Height;
                Height = Screen.PrimaryScreen.WorkingArea.Height;
            }
        }

        private void uc_ClientSizeChanged(object sender, EventArgs e)
        {
            SetControlsLocation();
        }

        private void panelMainControls_Resize(object sender, EventArgs e)
        {
            if (ucTimeSettings1.Top + ucTimeSettings1.Height < panelMainControls.Height)
            {
                panelMainControls.AutoScroll = false;
                SetUControlsLocation(13, 4);
            }
            else
            {
                panelMainControls.AutoScroll = true;
                SetUControlsLocation(3, 4);
            }

        }

        private void chbStopZero_CheckedChanged(object sender, EventArgs e)
        {
            string tmpStr = "Auto stopp ha nulla";
            if (chbStopZero.Checked)
            {
                chbStopZero.Text = tmpStr + " \r\n( BE )";
            }
            else
            {
                chbStopZero.Text = tmpStr + " \r\n( KI )";
            }
        }

        private void buttonMainPage_Click(object sender, EventArgs e)
        {
            customTabControlMain.SelectedIndex = 0;
        }

        private void buttonSecondPage_Click(object sender, EventArgs e)
        {
            customTabControlMain.SelectedIndex = 1;
        }

        private void buttonMainSettings_Click(object sender, EventArgs e)
        {
            customTabControlMain.SelectedIndex = 2;
        }

        // A főablak eszköztárán lévő gombok megnyomásakor ez mindig lefut, mert ez vált lapot a tabcontrolon
        private void radioButtonTabControl_CheckedChanged(object sender, EventArgs e)
        {
            int index = 0;
            index = radioButtonMainPage.Checked ? index + 0 : index;
            index = radioButtonSecondPage.Checked ? index + 1 : index;
            index = radioButtonMainSettings.Checked ? index + 2 : index;
            index = radioButtonLog.Checked ? index + 3 : index;
            index = radioButtonAbout.Checked ? index + 4 : index;

            customTabControlMain.SelectedIndex = index;

            switch (index)
            {
                case 0:
                    customTabControlMain.SelectedIndex = index;
                    ucMonitorControlBox1.SetCurrentMonitor();
                    ucMonitorPreviewBox1.StartVideo();
                    ucMonitorPreviewBox2.StopVideo();
                    break;
                case 1:
                    customTabControlMain.SelectedIndex = index;
                    ucMonitorControlBox2.SetCurrentMonitor();
                    ucMonitorPreviewBox1.StopVideo();
                    ucMonitorPreviewBox2.StartVideo();
                    break;
                case 2:
                    customTabControlMain.SelectedIndex = index;
                    ucMonitorPreviewBox1.StopVideo();
                    ucMonitorPreviewBox2.StopVideo();
                    break;
                case 3:
                    customTabControlMain.SelectedIndex = index;
                    ucMonitorPreviewBox1.StopVideo();
                    ucMonitorPreviewBox2.StopVideo();
                    break;
                case 4:
                    customTabControlMain.SelectedIndex = index;
                    ucMonitorPreviewBox1.StopVideo();
                    ucMonitorPreviewBox2.StopVideo();
                    break;

                default:
                    break;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/cskornel/sc/tree/master/public_release");
        }

        private void checkBoxMonitorAutostart_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMonitorAutostart.Checked)
            {
                _globalSettings.UCMonitorPreviewBoxAutostrtVideo = true;
                ucMonitorPreviewBox1.RefreshGlobalSettings();
                ucMonitorPreviewBox2.RefreshGlobalSettings();
            }
            else
            {
                _globalSettings.UCMonitorPreviewBoxAutostrtVideo = false;
                ucMonitorPreviewBox1.RefreshGlobalSettings();
                ucMonitorPreviewBox2.RefreshGlobalSettings();
            }
        }

        #endregion

        #region Extra Features

        //ragadós ablak
        private bool DoSnap(int pos, int edge)
        {
            int delta = pos - edge;
            return delta > 0 && delta <= SnapDist;
        }

        protected override void OnResizeEnd(EventArgs e)
        {
            base.OnResizeEnd(e);

            if (_globalSettings.RagadosAblak)
            {
                Screen scn = Screen.FromPoint(this.Location);
                if (DoSnap(this.Left, scn.WorkingArea.Left)) this.Left = scn.WorkingArea.Left;
                if (DoSnap(this.Top, scn.WorkingArea.Top)) this.Top = scn.WorkingArea.Top;
                if (DoSnap(scn.WorkingArea.Right, this.Right)) this.Left = scn.WorkingArea.Right - this.Width;
                if (DoSnap(scn.WorkingArea.Bottom, this.Bottom)) this.Top = scn.WorkingArea.Bottom - this.Height;
            }
        }

        #endregion

        #region XML kezelés

        private void SaveCounterXML(string strFileName)
        {
            XDocument tmpxml = new XDocument(new XElement("Counter"));
            tmpxml.Root.Add(_counter.ToXML());
            tmpxml.Save(strFileName);
        }

        private void SaveMainFormDataXML(string strFileName)
        {
            formData.AutoZeroChecked = chbStopZero.Checked;
            formData.UcMonitorPreviewBoxMinimize = ucMonitorPreviewBox1.Minimized;
            formData.UcMonitorControlBoxMinimize = ucMonitorControlBox1.Minimized;
            formData.UcFontSizeBoxMinimize = ucFontSizeBox1.Minimized;
            formData.UcCounterTypeChangerMinimize = ucCounterTypeChanger1.Minimized;
            formData.UcCounterMinimize = ucCounter1.Minimized;
            formData.UcTimeDirectionMinimize = ucTimeDirection1.Minimized;
            formData.UcTimeSettingsMinimize = ucTimeSettings1.Minimized;

            XDocument tmpxml = new XDocument(new XElement("Mainform"));
            tmpxml.Root.Add(formData.ToXML());
            tmpxml.Save(strFileName);
        }

        //form pozíció
        private void ReadMainFormDataXML()
        {
            try
            {
                if (File.Exists(savePath + @"\formData.xml"))
                {
                    XDocument xmlFormData = XDocument.Load(savePath + @"\formData.xml");
                    MainFormData tmpFormData = new MainFormData(int.Parse(xmlFormData.Root.Element("Mainform").Attribute("top").Value),
                                                                int.Parse(xmlFormData.Root.Element("Mainform").Attribute("left").Value),
                                                                int.Parse(xmlFormData.Root.Element("Mainform").Attribute("width").Value),
                                                                int.Parse(xmlFormData.Root.Element("Mainform").Attribute("height").Value),
                                                                int.Parse(xmlFormData.Root.Element("Mainform").Attribute("zChecked").Value) == 1 ? true : false,
                                                                int.Parse(xmlFormData.Root.Element("Mainform").Attribute("ucMonitorPreviewBoxMinimize").Value) == 1 ? true : false,
                                                                int.Parse(xmlFormData.Root.Element("Mainform").Attribute("ucucMonitorControlBoxMinimize").Value) == 1 ? true : false,
                                                                int.Parse(xmlFormData.Root.Element("Mainform").Attribute("ucFontSizeBoxMinimize").Value) == 1 ? true : false,
                                                                int.Parse(xmlFormData.Root.Element("Mainform").Attribute("ucCounterTypeChangerMinimize").Value) == 1 ? true : false,
                                                                int.Parse(xmlFormData.Root.Element("Mainform").Attribute("ucCounterMinimize").Value) == 1 ? true : false,
                                                                int.Parse(xmlFormData.Root.Element("Mainform").Attribute("ucTimeDirectionMinimize").Value) == 1 ? true : false,
                                                                int.Parse(xmlFormData.Root.Element("Mainform").Attribute("ucTimeSettingsMinimize").Value) == 1 ? true : false

                                                                );
                    this.Top = tmpFormData.Top;
                    this.Left = tmpFormData.Left;
                    this.Width = tmpFormData.Width;
                    this.Height = tmpFormData.Height;
                    if (tmpFormData.UcMonitorPreviewBoxMinimize) ucMonitorPreviewBox1.Minimize();
                    if (tmpFormData.UcMonitorControlBoxMinimize) ucMonitorControlBox1.Minimize();
                    if (tmpFormData.UcFontSizeBoxMinimize) ucFontSizeBox1.Minimize();
                    if (tmpFormData.UcCounterTypeChangerMinimize) ucCounterTypeChanger1.Minimize();
                    if (tmpFormData.UcCounterMinimize) ucCounter1.Minimize();
                    if (tmpFormData.UcTimeDirectionMinimize) ucTimeDirection1.Minimize();
                    if (tmpFormData.UcTimeSettingsMinimize) ucTimeSettings1.Minimize();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ReadCounterDataXML()
        {
            try
            {
                if (File.Exists(savePath + @"\counter.xml"))
                {
                    XDocument xmlFormData = XDocument.Load(savePath + @"\counter.xml");

                    _counter.Id = int.Parse(xmlFormData.Root.Element("Counter").Attribute("id").Value);
                    //_counter.FontSize = int.Parse(xmlFormData.Root.Element("Counter").Attribute("fontsize").Value);
                    _counter.UserTime = int.Parse(xmlFormData.Root.Element("Counter").Attribute("time").Value);
                    _counter.CurrentMonitor = int.Parse(xmlFormData.Root.Element("Counter").Attribute("currentMonitor").Value) <= (Screen.AllScreens.Length - 1) ? int.Parse(xmlFormData.Root.Element("Counter").Attribute("currentMonitor").Value) : 0;
                    _counter.CounterType = (CounterTypeEnum)int.Parse(xmlFormData.Root.Element("Counter").Attribute("counterType").Value);
                    _counter.Direction = int.Parse(xmlFormData.Root.Element("Counter").Attribute("direction").Value) == 1;
                    _counter.SzovegesOra = int.Parse(xmlFormData.Root.Element("Counter").Attribute("szovegesOra").Value) == 1;
                    _counter.HideText = int.Parse(xmlFormData.Root.Element("Counter").Attribute("hideText").Value) == 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        #endregion

        private void ucEffectBox1_Load(object sender, EventArgs e)
        {

        }
    }
}
