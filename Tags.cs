#pragma warning disable 
using System;

/*
 * https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/xmldoc/recommended-tags-for-documentation-comments
 * 
 *  <c>              短いソースコード(シンボル名程度）
 *  <code>           複数行のソースコード
 *  <example>        メソッドまたは他のライブラリメンバーの使用例
 *  <exception>*     スローされる例外
 *  <include>*       外部ファイル(xml)のコメントを参照
 *  <list>           コメント内で段組み
 *  <para>           コメント内で段落
 *  <param>*         コメント内で引数
 *  <paramref>       コメント内でパラメーター名を参照
 *  <permission>*    アクセスの記述（謎）
 *  <remarks>        summary の補足
 *  <inheritdoc>     継承元クラスのコメントを参照
 *  <see>*           シンボルへのリンク生成
 *  <seealso>*       Webリンク作成
 *  <summary>        コメント(定型出力される)
 *  <typeparam>*     ジェネリック型のコメント
 *  <typeparamref>   謎。<typeparam> で良さげ
 *  <returns>        メソッドの戻り値コメント
 *  <value>          get/setプロパティの説明
 * 
 *  (* は、コンパイラによって構文が検証されることを示します。)
 * 
 */
namespace XmlDocumentComment
{
    /// <summary>
    /// The main <c>Tags</c> class.
    /// </summary>
    class Tags
    {
        /// <summary>
        /// 普段はこんな感じにテキトーに書いたりしますよね。ちなみに
        /// summary 内で改行してもポップアップには反映されません。
        /// </summary>
        void 初めに() { }

        /// <summary>
        /// summary 内に "<" または ">" を書くとタグと解釈されて、コメントが表示されなくなります。
        /// VisualStudio が波線などで警告をしてくれたりもしてくれないので気を付けましょう。
        /// "<" は "&lt;" で  ">" は "&gt;" で記述できます。
        /// </summary>
        void 注意() { }

        /// <summary>
        /// &lt;c&gt; タグを使用すると、summary 内のシンボル名をコードとしてマークできます。
        /// 複数行をコードとして示す場合は &lt;code&gt; を使用します。
        /// If you run <c>C</c>, your app will die.
        /// </summary>
        void C() => C();

        /// <summary>
        /// &lt;code&gt; タグを使用すると、summary 内の文字列をコードとしてマークできます。
        /// 複数行なら &lt;code&gt; と案内してるのに、ポップアップウィンドウでは一行で表示されるようです。
        /// <code>
        /// if (x == 0) {
        ///     return false;
        /// } else {
        ///     return true;
        /// }
        /// </code>
        /// </summary>
        void Code() { }

        /// <summary>
        /// &lt;example&gt; タグを使用すると、メソッドまたは他のライブラリメンバーの使用例を指定できます。
        /// 一般的に内部では &lt;code&gt; タグが使用されます。
        /// <example>
        /// This sample shows how to call the <see cref="GetZero"/> method.
        /// <code>
        /// class TestClass
        /// {
        ///     static int Main()
        ///     {
        ///         return GetZero();
        ///     }
        /// }
        /// </code>
        /// </example>
        /// </summary>
        void Example() { }

        /// <summary>
        /// &lt;exception&gt; タグを使用すると、スローされる例外を指定できます。
        /// このタブは メソッド，プロパティ，イベント，インデクサー の定義に適用できます。
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when argument is negative value.</exception>
        int Exception(int x) => (x >= 0) ? x : throw new ArgumentException();

        /// <include file='IncludeDocs.xml' path='MyDocs/MyMembers[@name="test1"]/*' />
        void Include() { }

        /// <summary>
        /// &lt;list&gt; ブロックを使用して、テーブルまたは定義リストの見出し行を定義します。
        /// テーブルを定義するときにのみ、見出しの用語のエントリを指定する必要があります。
        /// <list type="bullet|number|table">
        ///     <item>
        ///         <term>term1</term>
        ///         <description>description1</description>
        ///     </item>
        ///     <item>
        ///         <term>term2</term>
        ///         <description>description2</description>
        ///     </item>
        /// </list>
        /// </summary>
        void List() { }

        /// <summary>
        /// <para>&lt;para&gt; で囲むと段落にできます</para>
        /// <para><para>&lt;para&gt; を &lt;para&gt; で囲んでもネスト表示にはなりません</para></para>
        /// </summary>
        void Para() { }

        /// <summary>
        /// &lt;param&gt; タグの文字列は IntelliSense，オブジェクトブラウザー，コードコメント，Webレポート に表示されます。
        /// </summary>
        /// <param name="width">幅です</param>
        /// <param name="height">高さです</param>
        void Param(int width, int height) { }

        /// <summary>
        /// &lt;paramref&gt; タグを使用すると、&lt;summary&gt; または &lt;remarks&gt; ブロックなどの
        /// コードコメント内の単語がパラメーターを参照することを示すことができます。
        /// The <paramref name="value"/> parameter takes a number.
        /// </summary>
        void ParamRef(int value) { }

        /// <summary>
        /// &lt;remarks&gt; タグを使用して、型の情報を追加し、&lt;summary&gt; で指定された情報を補足します。
        /// </summary>
        /// <remarks>
        /// summary の補足情報を記入します。 オブジェクトブラウザーに 『コメント』 として表示されます。
        /// </remarks>
        void Remarks() { }

        /// <summary>
        /// &lt;permission&gt; タグを使用すると、メンバーのアクセスをドキュメント化できます。
        /// </summary>
        /// <permission cref="System.Security.PermissionSet">Everyone can access this method.</permission>
        void Permission() { }

        //void InheritDoc() { } -> see InheritDoc.cs

        /// <summary>
        /// &lt;see&gt; タグを使用すると、テキスト内からリンクを指定できます。
        /// コード要素のドキュメント ページへの内部ハイパーリンクを作成するには、cref 属性を使用します。
        /// また、href はハイパーリンクとして機能する有効な属性です。
        /// <see cref="System.Console.WriteLine(string)"/> for information about output statements.
        /// </summary>
        void See() { }

        /// <summary>
        /// &lt;see&gt; タグを使用すると、テキスト内からリンクを指定できます。
        /// テキストが「関連項目」セクションに配置されていることを示すには、&lt;seealso&gt; を使用します。
        /// コード要素のドキュメント ページへの内部ハイパーリンクを作成するには、cref 属性を使用します。
        /// また、href はハイパーリンクとして機能する有効な属性です。
        /// <seealso href="https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/xmldoc/seealso">MSDocs-seealso</seealso>
        /// </summary>
        void SeeAlso() { }

        /// <summary>
        /// &lt;summary&gt; タグは、型または型メンバーの説明に使用します。
        /// 一番使うタグです。
        /// </summary>
        void Summary() { }

        /// <summary>
        /// &lt;typeparam&gt; タグは、型パラメーターを説明するためにジェネリック型または
        /// メソッドの宣言のコメントで使用する必要があります。
        /// ジェネリック型またはメソッドの型パラメーターごとにタグを追加します。
        /// </summary>
        /// <typeparam name="T">The element type of the array</typeparam>
        void TypeParam<T>(T x) { }


        /// <summary>
        /// &lt;typeparamref&gt; タグは、ドキュメントファイルを使用するとき書式 (斜体など) を指定できる
        /// らしいけど、 &lt;typeparamref&gt; を指定すると、ポップアップコメントが出なくなる。謎い。
        /// </summary>
        /// <typeparamref name="T">The element type of the array</typeparam>
        void TypeParamRef<T>(T x) { }

        /// <summary>
        /// &lt;returns&gt; タグは、戻り値を説明するためにメソッドの宣言のコメントで使用する必要があります。
        /// </summary>
        /// <returns>計算結果です</returns>
        int Returns() => 0;

        /// <summary>
        /// &lt;value&gt; タグを使用して、プロパティが表す値を記述することができます。
        /// </summary>
        /// <value>Value プロパティは _value フィールドの値を get/set します。</value>
        int Value
        {
            get => _value;
            set
            {
                _value = value;
                NotifyPropertyChanged(nameof(Value));
            }
        }
        int _value;

        void NotifyPropertyChanged(string name) { }
    }
}
