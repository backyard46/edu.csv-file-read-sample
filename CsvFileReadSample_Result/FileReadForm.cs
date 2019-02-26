using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CsvFileReadSample_Result
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
            if (File.Exists(textFileName.Text))
            {
                // 指定されたファイルが存在する場合
                string mojiCode = (radioUTF.Checked ? "utf-8" : "sjis");
                char separator = (radioComma.Checked ? ',' : '|');

                // usingでStreamReaderの利用を宣言してファイルを読み込む
                using (StreamReader reader = new StreamReader(textFileName.Text, Encoding.GetEncoding(mojiCode)))
                {
                    string oneLineString = string.Empty;
                    string[] oneLineData;

                    gridMainData.Columns.Clear();
                    gridMainData.Rows.Clear();

                    // 最初の1行を読んで見出しにする
                    oneLineString = reader.ReadLine();
                    oneLineData = oneLineString.Split(separator);
                    // 見出しを作る（Columnsに列名情報をAddする）
                    foreach (string columnName in oneLineData)
                    {
                        gridMainData.Columns.Add(columnName, columnName);
                    }

                    // 2行目以降、最後の行までを1行ずつ読んでDataGridViewに追加する
                    while (!reader.EndOfStream)
                    {
                        oneLineString = reader.ReadLine();
                        gridMainData.Rows.Add(oneLineString.Split(separator));
                    }
                }
            }
            else
            {
                MessageBox.Show("指定されたファイル " + textFileName.Text + " は存在しません。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        /// <summary>
        /// ファイル指定ボタン押下時処理。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFileSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.FileName = textFileName.Text;
            dialog.Multiselect = false;
            DialogResult result = dialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                textFileName.Text = dialog.FileName;
                // 選択情報の保存(設定ファイル)
                Properties.Settings.Default.LastSelectedFile = dialog.FileName;
                Properties.Settings.Default.Save();
            }
            else
            {
            }
        }


        /// <summary>
        /// フォームロード時処理。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileReadForm_Load(object sender, EventArgs e)
        {
            textFileName.Text = Properties.Settings.Default.LastSelectedFile;
            if (Properties.Settings.Default.MojiCode != "UTF-8") radioSJIS.Checked = true;
            if (Properties.Settings.Default.Separator != "Bar") radioComma.Checked = true;
        }


        /// <summary>
        /// フォームクローズ時処理。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileReadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 情報の保存(設定ファイル)
            Properties.Settings.Default.LastSelectedFile = textFileName.Text;
            if (radioUTF.Checked) Properties.Settings.Default.MojiCode = "UTF-8"; else Properties.Settings.Default.MojiCode = "Shift JIS";
            if (radioComma.Checked) Properties.Settings.Default.Separator = "Comma"; else Properties.Settings.Default.Separator = "Bar";
            Properties.Settings.Default.Save();
        }


        /// <summary>
        /// 閉じるボタン押下時処理。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// ファイルを保存するボタン押下時処理。
        /// 元のファイルを「～.csv_bak」に改名退避してから保存する。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWrite_Click(object sender, EventArgs e)
        {
            string mojiCode = (radioUTF.Checked ? "utf-8" : "sjis");
            char separator = (radioComma.Checked ? ',' : '|');

            // テキストボックスが空、またはグリッドが空の場合は処理中止
            if (textFileName.Text.Length == 0 || gridMainData.Rows.Count == 0)
            {
                return;                
            }

            try
            {
                // 旧ファイルを退避する
                File.Copy(textFileName.Text, textFileName.Text + ".bak", true);
            }
            catch (IOException ex)
            {
                // ファイル退避に失敗した場合（IOExceptionを継承した例外が発生する）
                MessageBox.Show("既存ファイルの退避に失敗しました。ファイル、フォルダの状態を確認してください。"
                    + "\r\n" + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // usingでStreamWriteの利用を宣言
                using (StreamWriter writer = new StreamWriter(textFileName.Text, false, Encoding.GetEncoding(mojiCode)))
                {
                    int columnCount = gridMainData.Columns.Count;   // 列数

                    // 書き出しは1行まとめてではなく、項目ごとに改行無しで書き連ねる。
                    // 一行分の文字列を作ってWriteLineで一気に行単位書き込みをしても結果は同じ。

                    // 見出し行を書き出す。
                    for (int idx = 0; idx < columnCount; idx++)
                    {
                        // 行末だけカンマ無しになるようにして書き出す。
                        writer.Write(gridMainData.Columns[idx].Name);
                        if (idx < columnCount - 1)
                        {
                            writer.Write(separator);
                        }
                        else
                        {
                            writer.Write("\r\n");
                        }
                    }

                    // データ本体を書き出す。
                    foreach (DataGridViewRow row in gridMainData.Rows)
                    {
                        // 新規追加用の行の場合など、先頭セルのValueがnullになるのでその場合はスキップする。
                        if (row.Cells[0].Value != null)
                        {
                            for (int idx = 0; idx < columnCount; idx++)
                            {
                                // 行末だけカンマ無しになるようにして書き出す。
                                writer.Write(row.Cells[idx].Value.ToString());
                                if (idx < columnCount - 1)
                                {
                                    writer.Write(separator);
                                }
                                else
                                {
                                    writer.Write("\r\n");
                                }
                            }
                        }
                    }
                    writer.Flush();
                    MessageBox.Show("ファイル保存が完了しました。", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException ex)
            {
                // ファイル書き出し失敗時
                MessageBox.Show("ファイルの保存に失敗しました。保存先ファイルやフォルダをご確認ください。\r\n"
                    + "旧ファイルは、拡張子末尾に「_bak」がついたファイルとして退避されていますので、\r\n"
                    + "お手数ですが手作業で元に戻してください。\r\n" 
                    + ex.Message , "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
