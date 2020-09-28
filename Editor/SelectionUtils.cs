using JetBrains.Annotations;
using System.Linq;
using UnityEditor;

namespace Kogane
{
	/// <summary>
	/// Selection 関連の汎用的な関数を管理するクラス
	/// </summary>
	public static class SelectionUtils
	{
		//================================================================================
		// 関数(static)
		//================================================================================
		/// <summary>
		/// 選択中のフォルダとそれに含まれるすべてのサブフォルダのパスを返します
		/// </summary>
		[NotNull]
		public static string[] GetSelectedFolderPaths()
		{
			return Selection
					.GetFiltered<DefaultAsset>( SelectionMode.DeepAssets )
					.Select( x => AssetDatabase.GetAssetPath( x ) )
					.Where( x => AssetDatabase.IsValidFolder( x ) )
					.ToArray()
				;
		}
	}
}