﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "21BDB3155EAFF84854AE60A0439501EDA5740C0FA2525CD81C3DEABE78FB34B7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MusicPlayer;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WPFSoundVisualizationLib;


namespace MusicPlayer {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MusicPlayer.MainWindow mainWindow;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ColumnDefinition ListOfSongsGrid;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OpenCloseListOfSongs;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label name;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WPFSoundVisualizationLib.SpectrumAnalyzer spectrumAnalyzer;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBox;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement Player;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider progress;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider SoundValue;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Preview;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image StartPause;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Next;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image SoundImage;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MusicPlayer;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.mainWindow = ((MusicPlayer.MainWindow)(target));
            
            #line 9 "..\..\MainWindow.xaml"
            this.mainWindow.Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 9 "..\..\MainWindow.xaml"
            this.mainWindow.Drop += new System.Windows.DragEventHandler(this.DropMusic);
            
            #line default
            #line hidden
            
            #line 9 "..\..\MainWindow.xaml"
            this.mainWindow.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.KeyBoardEventDown);
            
            #line default
            #line hidden
            
            #line 9 "..\..\MainWindow.xaml"
            this.mainWindow.PreviewKeyUp += new System.Windows.Input.KeyEventHandler(this.KeyBoardEventUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ListOfSongsGrid = ((System.Windows.Controls.ColumnDefinition)(target));
            return;
            case 3:
            this.OpenCloseListOfSongs = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\MainWindow.xaml"
            this.OpenCloseListOfSongs.Click += new System.Windows.RoutedEventHandler(this.OpenCloseListSongs);
            
            #line default
            #line hidden
            return;
            case 4:
            this.name = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.spectrumAnalyzer = ((WPFSoundVisualizationLib.SpectrumAnalyzer)(target));
            return;
            case 6:
            this.listBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 41 "..\..\MainWindow.xaml"
            this.listBox.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.SelectSong);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 44 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuClickDelete);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Player = ((System.Windows.Controls.MediaElement)(target));
            
            #line 57 "..\..\MainWindow.xaml"
            this.Player.MediaEnded += new System.Windows.RoutedEventHandler(this.NextSong);
            
            #line default
            #line hidden
            return;
            case 9:
            this.progress = ((System.Windows.Controls.Slider)(target));
            
            #line 58 "..\..\MainWindow.xaml"
            this.progress.AddHandler(System.Windows.Controls.Primitives.Thumb.DragCompletedEvent, new System.Windows.Controls.Primitives.DragCompletedEventHandler(this.TimeLineChange));
            
            #line default
            #line hidden
            
            #line 58 "..\..\MainWindow.xaml"
            this.progress.AddHandler(System.Windows.Controls.Primitives.Thumb.DragStartedEvent, new System.Windows.Controls.Primitives.DragStartedEventHandler(this.progress_DragStarted));
            
            #line default
            #line hidden
            return;
            case 10:
            this.SoundValue = ((System.Windows.Controls.Slider)(target));
            
            #line 59 "..\..\MainWindow.xaml"
            this.SoundValue.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.SetValume);
            
            #line default
            #line hidden
            
            #line 59 "..\..\MainWindow.xaml"
            this.SoundValue.MouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.MouseWeel);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 73 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Btn_Preview);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Preview = ((System.Windows.Controls.Image)(target));
            return;
            case 13:
            
            #line 76 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Btn_Go);
            
            #line default
            #line hidden
            return;
            case 14:
            this.StartPause = ((System.Windows.Controls.Image)(target));
            return;
            case 15:
            
            #line 79 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Btn_Break);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 82 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Btn_New);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 83 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Btn_Next);
            
            #line default
            #line hidden
            return;
            case 18:
            this.Next = ((System.Windows.Controls.Image)(target));
            return;
            case 19:
            this.SoundImage = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

