using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;

namespace MusicPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int currentSong;
        private NAudioEngine soundEngine;
        private bool isShiftDown;
        private bool dopGrid = true;
        private bool isProgressBarChaging;
        private bool lstBoxisOpen = false;

        public MainWindow()
        {
            InitializeComponent();
            listBox.ItemContainerGenerator.StatusChanged += ItemContainerGenerator_StatusChanged;
            soundEngine = NAudioEngine.Instance;
            spectrumAnalyzer.RegisterSoundPlayer(soundEngine);
            soundEngine.PropertyChanged += SoundEngine_PropertyChanged;
            
        }

       

        private void SoundEngine_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (NAudioEngine.Instance.IsPlaying && !isProgressBarChaging)
            {
                progress.Value = NAudioEngine.Instance.ActiveStream.CurrentTime.TotalSeconds;
                progress.Maximum = NAudioEngine.Instance.ActiveStream.TotalTime.TotalSeconds;
                if (progress.Value >= progress.Maximum)
                {
                    NextSong();
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            progress.Minimum = 0;
            progress.Maximum = 0;
            mainWindow.Title = "MyPlayer";

            SoundImage.Source = new BitmapImage(new Uri(@"Images/SoundOn.png", UriKind.Relative));
        }

        private void NextSong()
        {
            if ((listBox.ItemContainerGenerator.ContainerFromIndex(currentSong)) is ListBoxItem item)
            {
                item.Foreground = Brushes.White;
            }
            if (listBox.Items.Count == currentSong + 1)
            {
                currentSong = 0;
            }
            else
            {
                currentSong++;
            }
            NAudioEngine.Instance.OpenFile(listBox.Items[currentSong].ToString());
            NAudioEngine.Instance.InputStream().Volume = (float)SoundValue.Value;
            name.Content = listBox.Items[currentSong].ToString();
            if (NAudioEngine.Instance.CanPlay)
                NAudioEngine.Instance.Play();
            if ((listBox.ItemContainerGenerator.ContainerFromIndex(currentSong)) is ListBoxItem item2)
            {
                item2.Foreground = Brushes.Yellow;
            }
        }

        private void Btn_Go(object sender, RoutedEventArgs e)
        {
            if (NAudioEngine.Instance.IsPlaying)
            {
                StartPause.Source = new BitmapImage(new Uri(@"Images/start.png", UriKind.Relative));
                if (NAudioEngine.Instance.CanPause)
                    NAudioEngine.Instance.Pause();
            }
            else
            {
                StartPause.Source = new BitmapImage(new Uri(@"Images/pause.png", UriKind.Relative));
                if (NAudioEngine.Instance.CanPlay)
                    NAudioEngine.Instance.Play();
            }
        }

        private void Btn_Break(object sender, RoutedEventArgs e)
        {
            if (NAudioEngine.Instance.CanStop)
                NAudioEngine.Instance.Stop();
            NAudioEngine.Instance.ActiveStream.CurrentTime = TimeSpan.FromSeconds(0);
            progress.Value = 0;

            StartPause.Source = new BitmapImage(new Uri(@"Images/start.png", UriKind.Relative));
        }

        private void Btn_New(object sender, RoutedEventArgs e)
        {
            if ((listBox.ItemContainerGenerator.ContainerFromIndex(currentSong)) is ListBoxItem item)
            {
                item.Foreground = Brushes.White;
            }
            if (NAudioEngine.Instance.CanPause)
                NAudioEngine.Instance.Pause();
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "mp3 files(*.mp3)|*.mp3|All files (*.*)|*.*";
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StartPause.Source = new BitmapImage(new Uri(@"Images/pause.png", UriKind.Relative));

                if (!listBox.Items.Contains(file))
                {
                    if (dopGrid == true)
                    {
                        OpenRightPanelAnimation();
                        dopGrid = false;
                        lstBoxisOpen = true;
                    }
                    listBox.Items.Add(file.FileName);
                    NAudioEngine.Instance.OpenFile(file.FileName);
                    NAudioEngine.Instance.InputStream().Volume = (float)SoundValue.Value;
                    currentSong = listBox.Items.Count - 1;
                    name.Content = file.FileName;
                }
            }

            if ((listBox.ItemContainerGenerator.ContainerFromIndex(currentSong)) is ListBoxItem item2)
            {
                item2.Foreground = Brushes.Yellow;
            }
            if (NAudioEngine.Instance.CanPlay)
                NAudioEngine.Instance.Play();
        }

        private void SetValume(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (IsLoaded)
            {
                NAudioEngine.Instance.InputStream().Volume = (float)e.NewValue;
                if (Math.Abs(NAudioEngine.Instance.InputStream().Volume) < 0)
                {
                    SoundImage.Source = new BitmapImage(new Uri(@"Images/SoundOff.png", UriKind.Relative));
                }
                else if (NAudioEngine.Instance.InputStream().Volume > 0.01)
                {
                    SoundImage.Source = new BitmapImage(new Uri(@"Images/SoundOn.png", UriKind.Relative));
                }
            }
        }

        private void TimeLineChange(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        {
            NAudioEngine.Instance.ActiveStream.CurrentTime = TimeSpan.FromSeconds(((Slider)sender).Value);
            isProgressBarChaging = false;
        }

        private void DropMusic(object sender, System.Windows.DragEventArgs e)
        {
            var file = (string[])(e.Data.GetData(System.Windows.DataFormats.FileDrop));
            if (file != null)
                foreach (var item in file)
                {
                    if (!item.EndsWith(".mp3") || listBox.Items.Contains(item)) continue;
                    if (dopGrid == true)
                    {
                        OpenRightPanelAnimation();
                        dopGrid = false;
                        lstBoxisOpen = true;
                    }

                    listBox.Items.Add(item);
                }

            if (listBox.Items.Count == 0) return;
            NAudioEngine.Instance.OpenFile(listBox.Items[listBox.Items.Count - 1].ToString());
            NAudioEngine.Instance.InputStream().Volume = (float)SoundValue.Value;
            name.Content = listBox.Items[currentSong].ToString();
            StartPause.Source = new BitmapImage(new Uri(@"Images/pause.png", UriKind.Relative));
            if (NAudioEngine.Instance.CanPlay)
                NAudioEngine.Instance.Play();
        }

        private void ItemContainerGenerator_StatusChanged(object sender, EventArgs e)
        {
            if (listBox.ItemContainerGenerator.Status == System.Windows.Controls.Primitives.GeneratorStatus.ContainersGenerated)
            {
                if ((listBox.ItemContainerGenerator.ContainerFromIndex(currentSong)) is ListBoxItem item)
                {
                    item.Foreground = Brushes.Yellow;
                }
            }
        }

        private void NextSong(object sender, RoutedEventArgs e)
        {
            if ((listBox.ItemContainerGenerator.ContainerFromIndex(currentSong)) is ListBoxItem item)
            {
                item.Foreground = Brushes.White;
            }
            if (listBox.Items.Count == currentSong + 1)
            {
                currentSong = 0;
            }
            else
            {
                currentSong++;
            }
            NAudioEngine.Instance.OpenFile(listBox.Items[currentSong].ToString());
            NAudioEngine.Instance.InputStream().Volume = (float)SoundValue.Value;
            name.Content = listBox.Items[currentSong].ToString();
            if (NAudioEngine.Instance.CanPlay)
                NAudioEngine.Instance.Play();
            if ((listBox.ItemContainerGenerator.ContainerFromIndex(currentSong)) is ListBoxItem item2)
            {
                item2.Foreground = Brushes.Yellow;
            }
        }

        private void Btn_Preview(object sender, RoutedEventArgs e)
        {
            if ((listBox.ItemContainerGenerator.ContainerFromIndex(currentSong)) is ListBoxItem item)
            {
                item.Foreground = Brushes.White;
            }
            if (currentSong == 0)
            {
                currentSong = listBox.Items.Count - 1;
            }
            else
            {
                currentSong--;
            }
            NAudioEngine.Instance.OpenFile(listBox.Items[currentSong].ToString());
            NAudioEngine.Instance.InputStream().Volume = (float)SoundValue.Value;
            name.Content = listBox.Items[currentSong].ToString();
            if (NAudioEngine.Instance.CanPlay)
                NAudioEngine.Instance.Play();
            if ((listBox.ItemContainerGenerator.ContainerFromIndex(currentSong)) is ListBoxItem item2)
            {
                item2.Foreground = Brushes.Yellow;
            }
        }

        private void Btn_Next(object sender, RoutedEventArgs e)
        {
            if ((listBox.ItemContainerGenerator.ContainerFromIndex(currentSong)) is ListBoxItem item)
            {
                item.Foreground = Brushes.White;
            }
            if (listBox.Items.Count == currentSong + 1)
            {
                currentSong = 0;
            }
            else
            {
                currentSong++;
            }
            NAudioEngine.Instance.OpenFile(listBox.Items[currentSong].ToString());
            NAudioEngine.Instance.InputStream().Volume = (float)SoundValue.Value;
            if (NAudioEngine.Instance.CanPlay)
                NAudioEngine.Instance.Play();
            name.Content = listBox.Items[currentSong].ToString();
            if ((listBox.ItemContainerGenerator.ContainerFromIndex(currentSong)) is ListBoxItem item2)
            {
                item2.Foreground = Brushes.Yellow;
            }
        }

        private void MouseWeel(object sender, MouseWheelEventArgs e)
        {
            if (e.Delta > 0)
            {
                SoundValue.Value += 0.02;
            }
            else if (e.Delta < 0)
            {
                SoundValue.Value -= 0.02;
            }
        }

        private void SelectSong(object sender, RoutedEventArgs e)
        {
            if (isShiftDown) return;
            if ((listBox.ItemContainerGenerator.ContainerFromIndex(currentSong)) is ListBoxItem item)
            {
                item.Foreground = Brushes.White;
            }
            var a = (System.Windows.Controls.ListBox)sender;
            currentSong = a.SelectedIndex;
            if (currentSong == -1) return;
            NAudioEngine.Instance.OpenFile(listBox.Items[currentSong].ToString());
            NAudioEngine.Instance.InputStream().Volume = (float)SoundValue.Value;
            if (NAudioEngine.Instance.CanPlay)
                NAudioEngine.Instance.Play();
            name.Content = listBox.Items[currentSong].ToString();
            if ((listBox.ItemContainerGenerator.ContainerFromIndex(currentSong)) is ListBoxItem item2)
            {
                item2.Foreground = Brushes.Yellow;
            }
        }

        private void KeyBoardEventUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            isShiftDown = false;
        }

        private void KeyBoardEventDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            isShiftDown = true;
        }

        private void MenuClickDelete(object sender, RoutedEventArgs e)
        {
            if (NAudioEngine.Instance.CanPause)
                NAudioEngine.Instance.Pause();
            var selecteditems = listBox.SelectedItems;
            while (selecteditems.Count != 0)
            {
                if (selecteditems.Count != 0 && listBox.Items[currentSong] == selecteditems[0])
                {
                    if (currentSong == listBox.Items.Count - 1)
                    {
                        currentSong = 0;
                    }
                    else
                    {
                        currentSong++;
                    }
                    NAudioEngine.Instance.OpenFile(listBox.Items[currentSong].ToString());
                    NAudioEngine.Instance.InputStream().Volume = (float)SoundValue.Value;
                    name.Content = listBox.Items[currentSong].ToString();
                }
                listBox.Items.Remove(selecteditems[0]);
                currentSong--;
            }

            if (NAudioEngine.Instance.CanPlay)
                NAudioEngine.Instance.Play();
        }

        private void progress_DragStarted(object sender, System.Windows.Controls.Primitives.DragStartedEventArgs e)
        {
            isProgressBarChaging = true;
        }

        private void OpenCloseListSongs(object sender, RoutedEventArgs e)
        {
            if (lstBoxisOpen == false)
            {
                OpenRightPanelAnimation();
                lstBoxisOpen = !lstBoxisOpen;
            }
            else
            {
                CloseRightPamelAnimation();
                lstBoxisOpen = !lstBoxisOpen;
            }
        }

        private void CloseRightPamelAnimation()
        {
            DoubleAnimation animations = new DoubleAnimation();
            animations.From = mainWindow.Width;
            animations.To = mainWindow.Width - 300;
            animations.Duration = TimeSpan.FromMilliseconds(50);
            mainWindow.BeginAnimation(MainWindow.WidthProperty, animations);
            animations.From = 300;
            animations.To = 0;
            listBox.BeginAnimation(System.Windows.Controls.ListBox.WidthProperty, animations);
        }

        private void OpenRightPanelAnimation()
        {
            DoubleAnimation animations = new DoubleAnimation();
            animations.From = mainWindow.Width;
            animations.To = mainWindow.Width + 300;
            animations.Duration = TimeSpan.FromMilliseconds(50);
            mainWindow.BeginAnimation(MainWindow.WidthProperty, animations);
            animations.From = 0;
            animations.To = 300;
            listBox.BeginAnimation(System.Windows.Controls.ListBox.WidthProperty, animations);
        }

        
    }
}