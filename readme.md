# 概要
ITSS準拠の研修カリキュラム「プログラミングの基礎（B121）」のうち、「入出力」の実習としてC#によるファイル操作を行うサンプルです。
各課題は別々のプログラム（別プロジェクト）として作成してください。

# 課題

## 事前準備

特に準備はありませんが、Visual StudioでC#のWindows Formプロジェクト、またはコンソールアプリケーションプロジェクトを作成してください。

## 課題1 プログラム実行と処理の把握

### 新人用課題文
サンプルプログラム「CsvFileReadSample」をデバッグモードで動かし、一体何をやってるかを把握してください。

![CsvFileReadSample](images/CsvFileReadSampleForm.png)

### 講師用補足
CsvFileを読み込んでDataGridViewに表示するプログラムです。処理内容は大まかに下記のようになっています。

1. StreamReaderファイルを開く。
1. 最初の1行だけを読み、DataGridViewの見出し行を作る。
1. WhileでEndOfStreamまでファイルを1行ずつ読み、各行をSplitしたものをDataGridView.RowsのAddメソッドで表示する。



---

## 課題2 ファイル名の選択

### 新人用課題文
課題1のプロジェクトをコピーして課題2用のプロジェクトを作り、プログラムを改造して、好きなファイルを選択指定できるようにしてください。
C#では「OpenFileDialog」という部品を使うと、Windowsのアプリケーションでファイルを開く時などによく登場するファイル選択指定画面を表示させることができます。このOpenFileDialogの使い方をGoogleなどで検索し、下記の改造を加えてください。

- ファイル名指定を行うボタンを追加する（ボタンが押されるとOpenFileDialogが開く）。
- 指定されたファイル名を表示するテキストボックスを追加する（OpenFileDialogで度のファイルを指定したを見られるようにする）。
- OpenFileDialogで指定されたCSVファイルを読み込んで表示するよう、ファイル読み込み処理を変更する。

### 講師用補足
ここではOpenFileDialogでのファイル指定と、ダイアログからの情報取り出しを行います。標準のクラスを利用し、そこから情報を引き出す方法の習得と、その方法をGoogleなどでうまく検索して自力で実装に至る作業の練習です。
個人のあやふやなブログなどに行き着いて悩んでいるようであれば、いったんはマイクロソフトの標準的なドキュメントサイトを教え、まずはその内容を読むこと、そして次に、ある程度信頼のおける大手サイトまたは古くからの技術系個人サイトなどに誘導し、ネットの情報がすべて正しいとは限らないことも体験できると良い経験になると思います。

- 参考サイト: [方法: OpenFileDialogコンポーネントを使用してファイルを開く（Microsoft）](https://docs.microsoft.com/ja-jp/dotnet/framework/winforms/controls/how-to-open-files-using-the-openfiledialog-component)


---

## 課題3 SJISファイルの読み込み

### 新人用課題文
CsvFileフォルダに用意されている「懇親会予算見積もり_SJIS.csv」というファイルを文字化けさせずに読み込み、表示されるようにプログラムを改造してください。課題2までのファイルは「UTF-8」という文字コードで情報が記述されていますが、ここで対象とするファイルは「Shift-JIS（シフトジス）」と呼ばれる昔から利用されている日本語専用の文字コードで記述されています。

### 講師用補足
テキストファイルの文字コード違いによる文字化けと対応方法に関する課題です。.NET Frameworkではファイル読み込み時のエンコード方式を指定するだけで切り替えが可能で、既にUTF-8を指定して読み込む処理が記載されているので、そこを書き換えれば良いことに気づけば、あとは直ぐに終わると思います。



---

## 課題4 カンマ区切り数字の読み込み

### 新人用課題文
CSVファイルに「3,500円」のようなカンマ入り数値が入っている場合に、読み込むファイルやプログラムにどのような工夫が必要かを考え、その工夫を施してファイルの読み込みができるようにプログラムを改造してください。対応方法は何通りか考えられます。読み込むファイルに手を加えても構いません。

### 講師用補足
金額などにカンマが入っていることはよくあることで、その形式で「カンマ区切り」タイプのデータを作る場合の方法は大きく2通りあります。

- 各データをダブルクォーテーションなどで囲む。
- カンマ区切りではなく、実際のデータに出てこない文字、縦棒やタブ記号などで区切った形式に変更する。

ここではいずれで対応しても構いませんが、おそらく後者の方が簡単なので、悩んでいるようであればヒントを出してあげてください。



---

## 課題5 ファイル内容の編集と保存（オプション課題）
この課題はここまでの課題が完了した人向けの上級課題です。

### 新人用課題文
下記の改造を施してみてください。

- 画面上でデータを編集可能にする（データの追加はできなくてもいいので、変更だけでOKです）。
- 編集した内容を、元のファイルか別のファイル名で保存できるようにする。

### 講師用補足
課題1～4では読み込みと表示のみを行っていますが、この「表示のみ」を「変更可能」に変え、さらにファイルに書き戻すという課題です。特に書き込みについて処理例は出していないので、自力で調べて実装することになるかと思います。



---

# サンプルソース概略

## AddNumbers


## CreateKukuList

