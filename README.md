# [C#] XMLドキュメントコメント

C# ソースコードのドキュメントコメントを調査しました。

これまで \<summary\> くらいしか使っていなかのですが、（自分用だけど）Nugetパッケージを作る機会も増えてきたので。

[ドキュメント コメント用の推奨タグ - C# プログラミング ガイド | Microsoft Docs](https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/xmldoc/recommended-tags-for-documentation-comments)



### Note

- コメント内で `<` や `>` を書くと、コメントウィンドウが表示されなくなる。\&lt;  \&gt;  を使おう。
- `<typeparamref>` を使っても なぜかコメントウィンドウが表示されなくなる。（`summary` すら）

### TagList

\* は、コンパイラによって構文が検証されることを示します。  **Bold は よく使いそうなタグです。** 

| Tag                | Comment                                      |
| ------------------ | -------------------------------------------- |
| **\<c\>**          | **短いソースコード(シンボル名程度）**        |
| \<code\>           | 複数行のソースコード                         |
| \<example\>        | メソッドまたは他のライブラリメンバーの使用例 |
| **\<exception\>*** | **スローされる例外**                         |
| \<include\>*       | 外部ファイル(xml)のコメントを参照            |
| \<list\>           | コメント内で段組み                           |
| **\<para\>**       | **コメント内で段落**                         |
| \<param\>*         | 引数                                         |
| \<paramref\>       | コメント内でパラメーター名を参照             |
| \<permission\>*    | アクセスの記述（謎）                         |
| **\<remarks\>**    | **summary の補足**                           |
| \<inheritdoc\>     | 継承元クラスのコメントを参照                 |
| \<see\>*           | シンボルへのリンク生成                       |
| **\<seealso\>***   | **Webリンク作成**                            |
| \<summary\>        | コメント(定型出力される)                     |
| **\<typeparam\>*** | **ジェネリック型のコメント**                 |
| \<typeparamref\>   | 謎。\<typeparam\> で良さげ                   |
| \<returns\>        | メソッドの戻り値コメント                     |
| \<value\>          | get/setプロパティの説明                      |



### DocumentationFile

`<DocumentationFile>` を使用すれば、ビルド時にドキュメントコメントを作成できます。

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <TargetFramework>net5.0</TargetFramework>
    <DocumentationFile>XmlDocumentCommentTag.xml</DocumentationFile>
  </PropertyGroup>
</Project>
```



### Environment

- VisualStudio2019 16.9.4
- .NET 5.0 + C# 9.0

