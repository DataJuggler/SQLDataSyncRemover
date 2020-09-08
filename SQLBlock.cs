

#region using statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DataJuggler.Core.UltimateHelper;
using DataJuggler.Core.UltimateHelper.Objects;

#endregion

namespace SQLDataSyncRemover
{

    #region class SQLBlock
    /// <summary>
    /// This class represents a block of textline objects, split on the word Go.
    /// </summary>
    public class SQLBlock
    {
        
        #region Private Variables
        private List<TextLine> lines;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'SQLBlock' object.
        /// </summary>
        public SQLBlock()
        {
            // Create a new collection of 'TextLine' objects.
            Lines = new List<TextLine>();
        }
        #endregion
        
        #region Properties

            #region ContainsDataSync
            /// <summary>
            /// This read only property returns the value for 'ContainsDataSync'.
            /// </summary>
            public bool ContainsDataSync
            {
                get
                {
                    // initial value
                    bool containsDataSync = false;

                    // if the value for HasLines is true
                    if (HasLines)
                    {
                        // Iterate the collection of TextLine objects
                        foreach (TextLine line in Lines)
                        {
                            // if the text contains the word datasync
                            if (line.Text.ToLower().Contains("datasync"))
                            {
                                // set the return value
                                containsDataSync = true;

                                // break out of foreach loop
                                break;
                            }
                        }
                    }
                    
                    // return value
                    return containsDataSync;
                }
            }
            
            #endregion
            
            #region HasLines
            /// <summary>
            /// This property returns true if this object has a 'Lines'.
            /// </summary>
            public bool HasLines
            {
                get
                {
                    // initial value
                    bool hasLines = (this.Lines != null);
                    
                    // return value
                    return hasLines;
                }
            }
            #endregion
            
            #region Lines
            /// <summary>
            /// This property gets or sets the value for 'Lines'.
            /// </summary>
            public List<TextLine> Lines
            {
                get { return lines; }
                set { lines = value; }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
