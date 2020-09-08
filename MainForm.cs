

#region using statements

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataJuggler.Core.UltimateHelper;
using DataJuggler.Core.UltimateHelper.Objects;
using DataJuggler.Win.Controls;

#endregion

namespace SQLDataSyncRemover
{

    #region class Form1
    /// <summary>
    /// This is the MainForm for this application.
    /// </summary>
    public partial class MainForm : Form
    {
        
        #region Private Variables
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'Form1' object.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion
        
        #region Events
            
            #region RemoveDataSyncButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'RemoveDataSyncButton' is clicked.
            /// </summary>
            private void RemoveDataSyncButton_Click(object sender, EventArgs e)
            {
                // get the text
                string filePath = SQLFileControl.Text;

                // local
                List<SQLBlock> sqlBlocks = new List<SQLBlock>();

                // If the filePath string exists
                if (TextHelper.Exists(filePath))
                {
                    // parse the text lines
                    string fileText = File.ReadAllText(filePath);
                    
                    // If the fileText string exists
                    if (TextHelper.Exists(fileText))
                    {
                        // get the text lines
                        List<TextLine> lines = WordParser.GetTextLines(fileText);

                        // If the lines collection exists and has one or more items
                        if (ListHelper.HasOneOrMoreItems(lines))
                        {
                            // create the block
                            SQLBlock block = new SQLBlock();

                            // Iterate the collection of TextLine objects
                            foreach (TextLine line in lines)
                            {
                                // if this is a go line
                                if (line.Text.ToLower().Trim() == "go")
                                {
                                    // add this block
                                    sqlBlocks.Add(block);

                                    // Create a new block
                                    block = new SQLBlock();
                                }
                                else
                                {
                                    // add this line
                                    block.Lines.Add(line);
                                }
                            }

                            // Create a new instance of a 'StringBuilder' object.
                            StringBuilder sb = new StringBuilder();

                            // If the sqlBlocks collection exists and has one or more items
                            if (ListHelper.HasOneOrMoreItems(sqlBlocks))
                            {
                                // Iterate the collection of SQLBlock objects
                                foreach (SQLBlock tempBlock in sqlBlocks)
                                {
                                    // if this block does not contain the text DataSync
                                    if (!tempBlock.ContainsDataSync)
                                    {
                                        // Iterate the collection of TextLine objects
                                        foreach (TextLine textLine in tempBlock.Lines)
                                        {
                                            // Add this line
                                            sb.Append(textLine.Text);

                                            // Put the new line back
                                            sb.Append(Environment.NewLine);
                                        }

                                        // Add a newline
                                        sb.Append(Environment.NewLine);

                                        // Append the word GO
                                        sb.Append("GO");

                                        // Add a newline
                                        sb.Append(Environment.NewLine);
                                    }
                                }

                                 // Get the new SQL
                                string sql = sb.ToString().Trim();

                                // Copy to the clipboard
                                Clipboard.SetText(sql);

                                // Show the user a message
                                MessageBoxHelper.ShowMessage("DataSync has been removed and the SQL has been copied to your clipboard.", "SQL Copied");
                            }
                        }
                    }
                }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
