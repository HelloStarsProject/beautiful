using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace WindowsDream
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public List<Item> Items { get; set; }
        public MainPage()
        {
            this.InitializeComponent();

            Items = new List<Item>();
            Item item_0 = new Item() { Name = "系统", Describe = "显示、声音、通知、电源", IconUri = "logo001.png" };
            Item item_1 = new Item() { Name = "设备", Describe = "蓝牙、打印机、鼠标", IconUri = "logo001.png" };
            Item item_2 = new Item() { Name = "手机", Describe = "连接Android设备和iPhone", IconUri = "logo001.png" };
            Item item_3 = new Item() { Name = "网络和Internet", Describe = "WLAN、飞行模式、VPN", IconUri = "logo001.png" };
            Item item_4 = new Item() { Name = "个性化", Describe = "背景、锁屏、颜色", IconUri = "logo001.png" };
            Item item_5 = new Item() { Name = "应用", Describe = "卸载、默认应用、可选功能", IconUri = "logo001.png" };
            Item item_6 = new Item() { Name = "帐户", Describe = "你的帐户、电子邮件、同步设置、工作、家庭", IconUri = "logo001.png" };
            Item item_7 = new Item() { Name = "时间和语言", Describe = "语音、区域、日期", IconUri = "logo001.png" };
            Item item_8 = new Item() { Name = "游戏", Describe = "游戏栏、截图、直播、游戏模式", IconUri = "logo001.png" };
            Item item_9 = new Item() { Name = "轻松使用", Describe = "讲述人、放大镜、高对比度", IconUri = "logo001.png" };
            Item item_10 = new Item() { Name = "搜索", Describe = "查找我的文件、权限", IconUri = "logo001.png" };
            Item item_11 = new Item() { Name = "Cortana", Describe = "Cortana语言、权限、通知", IconUri = "logo001.png" };
            Item item_12 = new Item() { Name = "隐私", Describe = "位置 、相机", IconUri = "logo001.png" };
            Item item_13 = new Item() { Name = "更新和安全", Describe = "Windows更新、恢复、备份", IconUri = "logo001.png" };

            Items.Add(item_0);
            Items.Add(item_1);
            Items.Add(item_2);
            Items.Add(item_3);
            Items.Add(item_4);
            Items.Add(item_5);
            Items.Add(item_6);
            Items.Add(item_7);
            Items.Add(item_8);
            Items.Add(item_9);
            Items.Add(item_10);
            Items.Add(item_11);
            Items.Add(item_12);
            Items.Add(item_13);

            listView.ItemsSource = Items;
            gridView.ItemsSource = Items;
        }


        public class Item
        {
            //黑体字
            public string Name { get; set; }

            //小体字
            public string Describe { get; set; }

            //图标
            public string IconUri { get; set; }


        }


    }
}
