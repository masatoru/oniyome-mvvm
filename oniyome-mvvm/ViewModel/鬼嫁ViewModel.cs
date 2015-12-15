using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using oniyome.Model;

namespace oniyome.ViewModel
{
	public class 鬼嫁ViewModel : BindableBase
	{
		public 俺か嫁 俺 { get; set; }
		public 俺か嫁 嫁 { get; set; }

		//塗るCommand
		private ICommand ネイル塗るCommand_;
		public ICommand ネイル塗るCommand
		{
			get { return this.ネイル塗るCommand_ ??
					(this.ネイル塗るCommand_ = new DelegateCommand(ネイル塗るExecute, Canネイル塗る)); }
		}
		private bool Canネイル塗る()
		{
			return true;
		}
		int 指の数 = 1;
		private void ネイル塗るExecute()
		{
			if (指の数 > 5) return;
			俺.手[指の数-1].ネイル済み = true;
			switch (指の数)
			{
				case 3:
					俺.画像 = "起きてる2";
					break;
				case 5:
					嫁.喋る = "寝てんじゃねえよゴラァ！！";
					嫁.画像 = "鬼嫁";
					俺.画像 = "寝てる";
					俺.喋る = "zzzzzzzzzzz";
					break;
			}
			指の数++;
		}
		//コンストラクタ
		public 鬼嫁ViewModel()
		{
			俺 = new 俺か嫁();
			嫁 = new 俺か嫁();

			嫁.喋る = "寝ないでよ";
			嫁.画像 = "塗る";
			俺.喋る = "大丈夫です、" + Environment.NewLine + "起きてます。";
			俺.画像 = "起きてる";
		}
	}
}
