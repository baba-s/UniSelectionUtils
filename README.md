# UniSelectionUtils

Selection 型に関係する汎用的な関数を管理するクラス

## 使用例

```cs
using Kogane;
using UnityEditor;
using UnityEngine;

public class Example
{
    [MenuItem("Tools/Hoge")]
    private static void Hoge()
    {
        // Project ビューで選択されているフォルダと、
        // そのフォルダ内のすべてのサブフォルダのパスを取得する
        foreach ( var x in SelectionUtils.GetSelectedFolderPaths() )
        {
            Debug.Log( x );
        }
    }
}
```
