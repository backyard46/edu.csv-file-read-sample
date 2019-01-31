using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CsvFileReadSample
{
    public partial class FileReadForm : Form
    {
        public FileReadForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ファイルを開くボタン押下時処理。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            // 課題1
            // ファイル名を自分で指定できるようにしてください。
            // 「FleOpenDialog」で検索して、C#が持っているファイル指定用の画面を使い、ファイルを選択利用できるようにしましょう。

            // 課題2
            // Shift-JISで記述されたCSVファイルを開けるように改造してみましょう。

            // usingでStreamReaderの利用を宣言してファイルを読み込む
            using (StreamReader reader = new StreamReader("CsvFile/懇親会予算見積もり.csv", Encoding.GetEncoding("utf-8")))
            {
                string oneLineString = string.Empty;
                string[] oneLineData;

                // 最初の1行を読んで見出しにする
                oneLineString = reader.ReadLine();
                oneLineData = oneLineString.Split(',');
                // 見出しを作る（Columnsに列名情報をAddする）
                foreach (string columnName in oneLineData)
                {
                    gridMainData.Columns.Add(columnName,columnName);
                }

                // 2行目以降、最後の行までを1行ずつ読んでDataGridViewに追加する
                while (!reader.EndOfStream)
                {
                    oneLineString = reader.ReadLine();
                    gridMainData.Rows.Add(oneLineString.Split(','));
                }
            }

        }
    }
}
