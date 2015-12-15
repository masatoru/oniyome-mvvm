using Microsoft.Practices.Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oniyome.Model
{
	public class 俺か嫁 : BindableBase
	{
		public 俺か嫁()
		{
			手 = new ObservableCollection<指>();
			手.Add(new 指("小指"));
			手.Add(new 指("薬指"));
			手.Add(new 指("中指"));
			手.Add(new 指("人差し指"));
			手.Add(new 指("親指"));
		}
		//手 俺だけ使う
		public ObservableCollection<指> 手 { get; set; }

		//俺喋る
		public string 喋る_;
		public string 喋る
		{
			get { return 喋る_; }
			set { this.SetProperty(ref this.喋る_, value); }
		}
		//俺画像
		public string 画像_;
		public string 画像
		{
			get { return 画像_; }
			set { this.SetProperty(ref this.画像_, value); }
		}
	}

	public class 指 : BindableBase
	{
		public 指(string name) { どの指 = name; ネイル済み = false; }

		public string どの指_;
		public string どの指
		{
			get { return どの指_; }
			set { this.SetProperty(ref this.どの指_, value); }
		}
		public bool ネイル済み_;
		public bool ネイル済み
		{
			get { return ネイル済み_; }
			set { this.SetProperty(ref this.ネイル済み_, value); }
		}
	}
}
